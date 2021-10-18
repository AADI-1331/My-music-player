namespace Mymusicplayer
{
    partial class MyMusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusicPlayer));
            this.toppannel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllogo = new System.Windows.Forms.Label();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.toppannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // toppannel
            // 
            this.toppannel.BackColor = System.Drawing.Color.LimeGreen;
            this.toppannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toppannel.BackgroundImage")));
            this.toppannel.Controls.Add(this.pictureBox1);
            this.toppannel.Controls.Add(this.lbllogo);
            this.toppannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppannel.Location = new System.Drawing.Point(0, 0);
            this.toppannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppannel.Name = "toppannel";
            this.toppannel.Size = new System.Drawing.Size(785, 53);
            this.toppannel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.Color.Transparent;
            this.lbllogo.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogo.Location = new System.Drawing.Point(11, 19);
            this.lbllogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(145, 20);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "Music Player App";
            // 
            // ListBoxSongs
            // 
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.Location = new System.Drawing.Point(599, 91);
            this.ListBoxSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxSongs.Name = "ListBoxSongs";
            this.ListBoxSongs.Size = new System.Drawing.Size(149, 238);
            this.ListBoxSongs.TabIndex = 1;
            this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.Orange;
            this.btnSelectSongs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSelectSongs.Location = new System.Drawing.Point(599, 331);
            this.btnSelectSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(147, 28);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(11, 91);
            this.axWindowsMediaPlayerMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(531, 267);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblDevelopedBy.ForeColor = System.Drawing.Color.DimGray;
            this.lblDevelopedBy.Location = new System.Drawing.Point(321, 361);
            this.lblDevelopedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(149, 13);
            this.lblDevelopedBy.TabIndex = 4;
            this.lblDevelopedBy.Text = "Developed By:Aaditya Jaiswal";
            // 
            // MyMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 377);
            this.Controls.Add(this.lblDevelopedBy);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.toppannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Music Player";
            this.toppannel.ResumeLayout(false);
            this.toppannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Label lblDevelopedBy;
    }
}

