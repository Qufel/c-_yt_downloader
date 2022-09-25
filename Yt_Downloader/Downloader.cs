using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using FFMpegCore;

namespace Yt_Downloader
{
    public static class Downloader
    {
        //Main.Videos and Main.Save_to_path reference
        private static List<Video> videos = Main.Videos;
        private static string path = Main.Save_to_path;
        public static async void Download(Video videoToDownload, bool isAudioOnly)
        {
            if (!Directory.Exists(path))
            {
                Main.ShowErrorBox("Provided download path is invalid!");
                return;
            }

            var targetBitrate = videoToDownload.Bitrate;
            if (!isAudioOnly)
                targetBitrate = 70;

            var yt = new YoutubeClient();
            var streamMainfest = await yt.Videos.Streams.GetManifestAsync(videoToDownload.ID);

            #region Stream Extraction
            //audio tracks itags: 249, 250, 251
            //whick give bitrate around: 50k, 70k, 160k
            var audioInfo = streamMainfest
                .GetAudioOnlyStreams()
                .Where(s => s.Container.Name == "webm"); 
            
            //searching for closest bitrate to targeted
            List<double> bitrates = new List<double>();
            audioInfo.ToList().ForEach(a => bitrates.Add(a.Bitrate.KiloBitsPerSecond));
            double closest = bitrates.Aggregate((x, y) => Math.Abs(x - videoToDownload.Bitrate) < Math.Abs(y - videoToDownload.Bitrate) ? x : y);
            int closestIndex = bitrates.FindIndex(a => a == closest);

            //throw error if index not found
            if(closestIndex == -1)
            {
                Main.ShowErrorBox("Targeted audio bitrate not found!");
                return;
            }

            //final audio stream
            var audio = audioInfo.ToList()[closestIndex];

            //video tracks itags: 160, 133, 134, 135, 136, 137, 299
            //which give resolutions: 144p, 240p, 360p, 480p, 720p, 1080p, 1080p60
            var targetResolution = videoToDownload.Resolution;
            var videoInfo = streamMainfest
                .GetVideoOnlyStreams()
                .Where(s => s.Container.Name == "mp4" && s.VideoQuality.Label == $"{targetResolution}p");
            if (!isAudioOnly)
            {
                //check if video contains targeted resoultion with 60 frames
                if(videoInfo.Count() == 0)
                    videoInfo = streamMainfest
                        .GetVideoOnlyStreams()
                        .Where(s => s.Container.Name == "mp4" && s.VideoQuality.Label == $"{targetResolution}p60");

                //throw error if found non
                if(videoInfo.Count() == 0)
                {
                    Main.ShowErrorBox("Targeted video resolution not found!");
                    return;
                }
            }

            //final videoStream
            var video = videoInfo.Count() != 0 ? videoInfo.First() : null;
            #endregion
            //product: audio and video(null if audio_only) stream

            //progress
            if (isAudioOnly)
            {
                var filePath = $"{path}/{videoToDownload.Title}.{videoToDownload.Extension}";
                var progress = new Progress<double>(p =>
                {
                    videoToDownload.ChangeProgress(p).ChangeStatus("Downloading...");
                    if (p == 1)
                    {
                        videoToDownload.ChangeStatus("Finished");

                        //Metadata assignment
                        FFMpegArguments
                            .FromFileInput(filePath)
                            .OutputToFile(filePath, true, options => options
                            .WithAudioBitrate(Convert.ToInt32(audio.Bitrate.KiloBitsPerSecond))
                            );
                    }
                    Main.RefreshDownloadList();
                });
                try
                {
                    await yt.Videos.Streams.DownloadAsync(audio, filePath, progress);
                }
                catch
                {
                    videoToDownload.ChangeStatus("Already exists");
                    Main.RefreshDownloadList();
                }
            }
            else
            {

            }

        }
    }
}
