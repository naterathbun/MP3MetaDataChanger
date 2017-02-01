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
        public string FilePathOfSelectedMP3 { get; set; } = string.Empty;

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
            TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
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
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePathOfSelectedMP3 = openFileDialog1.FileName;
                UpdateCurrentMetaInformationLabels();
            }
        }



        // Update Labels with Current Info
        private void UpdateCurrentMetaInformationLabels()
        {
            TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);

            UpdateCurrentArtistLabel(tagFile);
            UpdateCurrentTrackLabel(tagFile);
            UpdateCurrentAlbumLabel(tagFile);
            UpdateCurrentGenreLabel(tagFile);
            UpdateActiveFilePathLabel();
        }

        private void UpdateCurrentArtistLabel(TagLib.File tagFile)
        {
            this.currentArtistLabel.Text = tagFile.Tag.JoinedAlbumArtists;
        }

        private void UpdateCurrentTrackLabel(TagLib.File tagFile)
        {
            this.currentTrackLabel.Text = tagFile.Tag.Title;
        }

        private void UpdateCurrentAlbumLabel(TagLib.File tagFile)
        {
            this.currentAlbumLabel.Text = tagFile.Tag.Album;
        }

        private void UpdateCurrentGenreLabel(TagLib.File tagFile)
        {
            this.currentGenreLabel.Text = tagFile.Tag.JoinedGenres;
        }

        private void UpdateActiveFilePathLabel()
        {
            this.activeFilePathLabel.Text = FilePathOfSelectedMP3;
        }

    }
}
