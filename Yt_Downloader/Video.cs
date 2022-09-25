using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yt_Downloader
{
    public class Video
    {
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private string id = "";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string title = "";
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string author = "";
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        private int length = 0;
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        private string extension = "";
        public double Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        private double progress = 0;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string status = "";
        public int Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }
        private int resolution;
        public int Bitrate
        {
            get { return bitrate; }
            set { bitrate = value; }
        }
        private int bitrate;
        public bool EmbedThumbnail
        {
            get { return embedThumbnail; }
            set { embedThumbnail = value; }
        }
        private bool embedThumbnail = false;
        public bool HasDownloaded
        {
            get { return hasDownloaded; }
            set { hasDownloaded = value; }
        }
        private bool hasDownloaded = false;
        
        public Video(string id, string title, string author , int length , string extension , int progress , string status)
        {
            ID = id;
            Title = title;
            Author = author;
            Length = length;
            Extension = extension;
            Progress = progress;
            Status = status;
        }
        public Video SetResolution(int res)
        {
            Resolution = res;
            return this;
        }
        public Video SetBitrate(int bitrate)
        {
            Bitrate = bitrate;
            return this;
        }
        public Video SetEmbedThumbnail(bool embed)
        {
            EmbedThumbnail = embed;
            return this;
        }
        public Video ChangeStatus(string new_status)
        {
            Status = new_status;
            return this;
        }
        public Video ChangeProgress(double new_progress)
        {
            Progress = new_progress;
            return this;
        }
        public Video HasDownloadedFile(bool hasDownloaded)
        {
            HasDownloaded = hasDownloaded;
            return this;
        }
    }
}
