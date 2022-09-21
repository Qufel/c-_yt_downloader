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

            if (video_radio.Checked)
                file_type = 0;
            else if (audio_radio.Checked)
                file_type = 1;

            switch (file_type)
            {
                case 0: extension = video_combobox.Text; break;
                case 1: extension = audio_combobox.Text; break;
            }
            Console.WriteLine("Adding to list");
            Main.AddVideo(url_entry.Text, extension);
            url_entry.Text = "";
        }

    }
}