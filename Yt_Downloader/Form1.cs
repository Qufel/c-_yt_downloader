using System.Text.RegularExpressions;

namespace Yt_Downloader
{
    public partial class Form1 : Form
    {
        public static ListView download_list = new ListView();
        public Form1()
        {
            InitializeComponent();
            download_list = video_list;
        }

        private void ext_CheckedChanged(object sender, EventArgs e)
        {
            if (video_radio.Checked)
            {
                audio_combobox.Enabled = false;
                bit_combobox.Enabled = false; 
                
                video_combobox.Enabled = true;
                res_combobox.Enabled = true;
            }
            else if (audio_radio.Checked)
            {
                audio_combobox.Enabled = true;
                bit_combobox.Enabled = true;

                video_combobox.Enabled = false;
                res_combobox.Enabled = false;
            }
        }

        private void select_folder(object sender, EventArgs e)
        {
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Main.Save_to_path = folderBrowser.SelectedPath;
            }

            path_entry.Text = Main.Save_to_path;
        }

        private void path_entry_changed(object sender, EventArgs e)
        {
            Main.Save_to_path = path_entry.Text;
        }

        private void add_video(object sender, EventArgs e)
        {
            var file_type = 0;
            var extension = video_combobox.Text;
            var url = url_entry.Text;
            var embed = embed_thumbnail_check.Checked;

            if (video_radio.Checked)
                file_type = 0;
            else if (audio_radio.Checked)
                file_type = 1;

            switch (file_type)
            {
                case 0: extension = video_combobox.Text; break;
                case 1: extension = audio_combobox.Text; break;
            }

            #region error handling
            var regex = "youtu(?:\\.be|be\\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)";
            Regex r = new Regex(regex);

            if (url == "")
            {
                Main.ShowErrorBox("URL not provided!");
                return;
            }
            else
            {
                var tmp = url;
                tmp.Replace("https://", "");
                if (!r.IsMatch(tmp))
                {
                    Main.ShowErrorBox("Incorrect video URL");
                    return;
                }
            }

            if (extension == "")
            {
                Main.ShowErrorBox("File format not provided!");
                return;
            }
            switch (file_type)
            {
                case 0:
                    if(res_combobox.Text == "")
                    {
                        Main.ShowErrorBox("Video resolution not provided!");
                        return;
                    }
                    break;
                case 1:
                    if (bit_combobox.Text == "")
                    {
                        Main.ShowErrorBox("Audio bitrate not provided!");
                        return;
                    }
                    break;
            }
            #endregion

            var bitrate = bit_combobox.Text;
            var resolution = res_combobox.Text;

            Console.WriteLine("Adding to list");
            Main.AddVideo(url, extension, bitrate, resolution, embed);
            url_entry.Text = "";
        }

        private void remove_selected(object sender, EventArgs e)
        {
            var items = video_list.CheckedItems.Cast<ListViewItem>();
            List<string> ids = new List<string>();
            items.ToList().ForEach(x => ids.Add(x.Text));

            Main.RemoveVideos(ids);
        }

        private void download_selected(object sender, EventArgs e)
        {
            var items = video_list.CheckedItems.Cast<ListViewItem>();
            List<string> ids = new List<string>();
            items.ToList().ForEach(x => ids.Add(x.Text));

            Main.DownloadSelected(ids);
        }
    }
}