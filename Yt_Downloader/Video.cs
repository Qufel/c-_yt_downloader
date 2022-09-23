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
        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        private int progress = 0;
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

        public Video ChangeStatus(string new_status)
        {
            Status = new_status;
            return this;
        }
        public Video ChangeProgress(int new_progress)
        {
            Progress = new_progress;
            return this;
        }
    }
}
