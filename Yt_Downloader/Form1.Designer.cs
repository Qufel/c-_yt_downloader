namespace Yt_Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.bit_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.res_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.audio_radio = new System.Windows.Forms.RadioButton();
            this.audio_combobox = new System.Windows.Forms.ComboBox();
            this.video_radio = new System.Windows.Forms.RadioButton();
            this.video_combobox = new System.Windows.Forms.ComboBox();
            this.browse_directory_btn = new System.Windows.Forms.Button();
            this.path_entry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.url_entry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.video_list = new System.Windows.Forms.ListView();
            this.url = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.author = new System.Windows.Forms.ColumnHeader();
            this.extension = new System.Windows.Forms.ColumnHeader();
            this.length = new System.Windows.Forms.ColumnHeader();
            this.progress = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.bit_combobox);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.res_combobox);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.checkBox1);
            this.gb1.Controls.Add(this.add_btn);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.audio_radio);
            this.gb1.Controls.Add(this.audio_combobox);
            this.gb1.Controls.Add(this.video_radio);
            this.gb1.Controls.Add(this.video_combobox);
            this.gb1.Controls.Add(this.browse_directory_btn);
            this.gb1.Controls.Add(this.path_entry);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.url_entry);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(860, 150);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "URL and Directory";
            // 
            // bit_combobox
            // 
            this.bit_combobox.FormattingEnabled = true;
            this.bit_combobox.Items.AddRange(new object[] {
            "mp4",
            "webm"});
            this.bit_combobox.Location = new System.Drawing.Point(266, 120);
            this.bit_combobox.Name = "bit_combobox";
            this.bit_combobox.Size = new System.Drawing.Size(121, 23);
            this.bit_combobox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bitrate:";
            // 
            // res_combobox
            // 
            this.res_combobox.FormattingEnabled = true;
            this.res_combobox.Items.AddRange(new object[] {
            "mp4",
            "webm"});
            this.res_combobox.Location = new System.Drawing.Point(266, 92);
            this.res_combobox.Name = "res_combobox";
            this.res_combobox.Size = new System.Drawing.Size(121, 23);
            this.res_combobox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resolution:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(393, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Embed thumbnail";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(779, 121);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Download as:";
            // 
            // audio_radio
            // 
            this.audio_radio.AutoSize = true;
            this.audio_radio.Location = new System.Drawing.Point(8, 120);
            this.audio_radio.Name = "audio_radio";
            this.audio_radio.Size = new System.Drawing.Size(57, 19);
            this.audio_radio.TabIndex = 8;
            this.audio_radio.Text = "Audio";
            this.audio_radio.UseVisualStyleBackColor = true;
            // 
            // audio_combobox
            // 
            this.audio_combobox.FormattingEnabled = true;
            this.audio_combobox.Location = new System.Drawing.Point(69, 119);
            this.audio_combobox.Name = "audio_combobox";
            this.audio_combobox.Size = new System.Drawing.Size(121, 23);
            this.audio_combobox.TabIndex = 7;
            // 
            // video_radio
            // 
            this.video_radio.AutoSize = true;
            this.video_radio.Checked = true;
            this.video_radio.Location = new System.Drawing.Point(8, 95);
            this.video_radio.Name = "video_radio";
            this.video_radio.Size = new System.Drawing.Size(55, 19);
            this.video_radio.TabIndex = 6;
            this.video_radio.TabStop = true;
            this.video_radio.Text = "Video";
            this.video_radio.UseVisualStyleBackColor = true;
            // 
            // video_combobox
            // 
            this.video_combobox.FormattingEnabled = true;
            this.video_combobox.Items.AddRange(new object[] {
            "mp4",
            "webm"});
            this.video_combobox.Location = new System.Drawing.Point(69, 91);
            this.video_combobox.Name = "video_combobox";
            this.video_combobox.Size = new System.Drawing.Size(121, 23);
            this.video_combobox.TabIndex = 5;
            // 
            // browse_directory_btn
            // 
            this.browse_directory_btn.Location = new System.Drawing.Point(779, 48);
            this.browse_directory_btn.Name = "browse_directory_btn";
            this.browse_directory_btn.Size = new System.Drawing.Size(75, 23);
            this.browse_directory_btn.TabIndex = 4;
            this.browse_directory_btn.Text = "Browse";
            this.browse_directory_btn.UseVisualStyleBackColor = true;
            // 
            // path_entry
            // 
            this.path_entry.Location = new System.Drawing.Point(76, 48);
            this.path_entry.Name = "path_entry";
            this.path_entry.Size = new System.Drawing.Size(697, 23);
            this.path_entry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save to:";
            // 
            // url_entry
            // 
            this.url_entry.Location = new System.Drawing.Point(76, 19);
            this.url_entry.Name = "url_entry";
            this.url_entry.Size = new System.Drawing.Size(778, 23);
            this.url_entry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video URL:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.video_list);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download List";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(749, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Download All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Download Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // video_list
            // 
            this.video_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.url,
            this.title,
            this.author,
            this.extension,
            this.length,
            this.progress,
            this.status});
            this.video_list.GridLines = true;
            this.video_list.Location = new System.Drawing.Point(6, 22);
            this.video_list.Name = "video_list";
            this.video_list.Size = new System.Drawing.Size(848, 324);
            this.video_list.TabIndex = 0;
            this.video_list.UseCompatibleStateImageBehavior = false;
            this.video_list.View = System.Windows.Forms.View.Details;
            // 
            // url
            // 
            this.url.Text = "URL";
            this.url.Width = 250;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 150;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.Width = 100;
            // 
            // extension
            // 
            this.extension.Text = "Extension";
            this.extension.Width = 80;
            // 
            // length
            // 
            this.length.Text = "Length";
            this.length.Width = 80;
            // 
            // progress
            // 
            this.progress.Text = "Progress";
            this.progress.Width = 80;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb1;
        private GroupBox groupBox2;
        private ListView video_list;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader url;
        private ColumnHeader title;
        private ColumnHeader author;
        private ColumnHeader extension;
        private ColumnHeader length;
        private ColumnHeader progress;
        private ColumnHeader status;
        private TextBox url_entry;
        private Label label1;
        private TextBox path_entry;
        private Label label2;
        private Button browse_directory_btn;
        private Button button1;
        private Button button3;
        private Button button2;
        private ComboBox video_combobox;
        private RadioButton audio_radio;
        private ComboBox audio_combobox;
        private RadioButton video_radio;
        private Label label3;
        private CheckBox checkBox1;
        private Button add_btn;
        private ErrorProvider errorProvider1;
        private ComboBox bit_combobox;
        private Label label5;
        private ComboBox res_combobox;
        private Label label4;
    }
}