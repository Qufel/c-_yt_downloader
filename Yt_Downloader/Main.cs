using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Yt_Downloader
{
    public static class Main
    {
        public static string Save_to_path
        {
            get { return save_to_path; }
            set { save_to_path = value; }
        }
        private static string save_to_path = "C:/";

        public static List<Video> Videos
        {
            get { return videos; }
            set { videos = value; }
        }
        private static List<Video> videos = new List<Video>();

        //Downloading
        public static void DownloadSelected(List<string> ids)
        {
            string[] audioFormats = { "mp3", "aac", "wav", "ogg" };
            var to_download = new List<Video>();
            for (int i = 0; i < videos.Count; i++)
            {
                if (ids.Contains(videos[i].ID))
                    to_download.Add(videos[i]);
            }
            foreach (var item in to_download)
            {
                bool isAudioOnly = audioFormats.Contains(item.Extension) ? true : false;
                Downloader.Download(item, isAudioOnly);
            }
        }

        //video and errors
        public static async void AddVideo(string url, string extension, string bitrate, string resolution, bool embed)
        {
            bitrate = bitrate.Replace("k", "");
            var bit = bitrate != "" ? Int32.Parse(bitrate) : 0;

            resolution = resolution.Replace("p", "");
            var res = resolution != "" ? Int32.Parse(resolution) : 0;

            var yt = new YoutubeClient();
            var video = await yt.Videos.GetAsync(url);

            var id = video.Id;
            var title = video.Title;
            var author = video.Author.ChannelTitle;
            var length = video.Duration != null ? Convert.ToInt32(video.Duration.Value.TotalSeconds) : 0;

            var file = new Video(id,title,author,length,extension,0,"Pending");
            file.SetBitrate(bit).SetResolution(res).SetEmbedThumbnail(embed);

            videos.Add(file);
            RefreshDownloadList();
        }
        public static void RemoveVideos(List<string> ids)
        {
            for (int i = 0; i < videos.Count; i++)
            {
                if (ids.Contains(videos[i].ID))
                    videos.Remove(videos[i]);
            }
            RefreshDownloadList();
        }
        public static void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //for code purposes
        private static void RefreshDownloadList()
        {
            Form1.download_list.Items.Clear();
            for(int i = 0; i < videos.Count; i++)
            {
                var video = videos[i];
                var time = SecondsToTime(video.Length);

                string[] tmp = { video.ID, video.Title, video.Author, video.Extension, time, "0%", video.Status };
                var item = new ListViewItem(tmp);
                Form1.download_list.Items.Add(item);
            }
        }

        private static string SecondsToTime(int s)
        {
            int hours = Convert.ToInt32(s / 3600);
            string _hours = hours < 10 ? $"0{hours}" : Convert.ToString(hours);

            int minutes = Convert.ToInt32((s % 3600)/60);
            string _minutes = minutes < 10 ? $"0{minutes}" : Convert.ToString(minutes);

            int seconds = s % 60;
            string _seconds = seconds < 10 ? $"0{seconds}" : Convert.ToString(seconds);

            return _hours + ":" + _minutes + ":" + _seconds;
        }
    }
}
