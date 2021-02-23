using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mymusicplayer
{
    public partial class MyMusicPlayer : Form
    {
        public MyMusicPlayer()
        {
            InitializeComponent();
        }
        // create the global variables of string type array to save the titles and path of the track
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple files
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//save the name of track in file array
                paths = ofd.FileNames;//save the paths of track in path array
                //display th music titles in list box
                for(int i=0;i<files.Length;i++)
                {
                    ListBoxSongs.Items.Add(files[i]);//display songs in list box
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }
    }
}
