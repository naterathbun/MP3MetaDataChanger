using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3MetaDataChanger
{
    public partial class Form1 : Form
    {
        string filePathOfSelectedMP3 = string.Empty;

        public Form1()
        {
            InitializeComponent();
  
        }


        // Update Meta Slots
        private void updateArtistButton_Click(object sender, EventArgs e)
        {

        }

        private void updateTrackButton_Click(object sender, EventArgs e)
        {

        }

        private void updateAlbumButton_Click(object sender, EventArgs e)
        {
            TagLib.File tagFile = TagLib.File.Create(filePathOfSelectedMP3);
            tagFile.Tag.Album = "IS GOOD"; // have this set based on the text box for album
            tagFile.Save();                 // updates the file
        }

        private void updateGenreButton_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Load File
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                
            }
        }



    }
}
