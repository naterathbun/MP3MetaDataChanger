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
        public string FilePathOfSelectedMP3 { get; set; } = "";
        public string FilePathOfWorkingDirectory { get; set; } = "";
        
        // Form Required
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        // Button Event Handlers
        private void button1_Click(object sender, EventArgs e)
        {
            GetUserSelectedFilePath();
        }

        private void updateArtistButton_Click(object sender, EventArgs e)
        {
            WriteUserEnteredArtistToFile();
        }

        private void updateTrackButton_Click(object sender, EventArgs e)
        {
            WriteUserEnteredTitleToFile();
        }

        private void updateAlbumButton_Click(object sender, EventArgs e)
        {
            WriteUserEnteredAlbumToFile();
        }

        private void updateGenreButton_Click(object sender, EventArgs e)
        {
            WriteUserEnteredGenreToFile();
        }

        private void renameFileButton_Click(object sender, EventArgs e)
        {
            RenameFileToUserEnteredName();
        }


        // File IO Methods
        public void GetUserSelectedFilePath()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePathOfSelectedMP3 = openFileDialog1.FileName;
                FilePathOfWorkingDirectory = System.IO.Path.GetDirectoryName(FilePathOfSelectedMP3);
                UpdateCurrentMetaInformationLabels();
            }
        }

        public void RenameFileToUserEnteredName()
        {
            if (FilePathOfSelectedMP3 != "" && renameFileBox.Text != "")
            {
                System.IO.File.Copy(FilePathOfSelectedMP3, FilePathOfWorkingDirectory + @"\" + renameFileBox.Text + ".mp3");
                System.IO.File.Delete(FilePathOfSelectedMP3);

                FilePathOfSelectedMP3 = FilePathOfWorkingDirectory + @"\" + renameFileBox.Text + ".mp3";
                renameFileBox.Text = "";
            }
            UpdateCurrentMetaInformationLabels();
        }


        // Update Actual File Meta Data
        public void WriteUserEnteredArtistToFile()
        {
            if (FilePathOfSelectedMP3 != "")
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Artists = new string[] { newArtistBox.Text };
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredTitleToFile()
        {
            if (FilePathOfSelectedMP3 != "")
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Title = newTrackBox.Text;
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredAlbumToFile()
        {
            if (FilePathOfSelectedMP3 != "")
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Album = newAlbumBox.Text;
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredGenreToFile()
        {
            if (FilePathOfSelectedMP3 != "")
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Genres = new string[] { newGenreBox.Text };
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        // Update Labels with Current Info from the File
        public void UpdateCurrentMetaInformationLabels()
        {
            if (FilePathOfSelectedMP3 != "")
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);

                UpdateCurrentArtistLabel(tagFile);
                UpdateCurrentTrackLabel(tagFile);
                UpdateCurrentAlbumLabel(tagFile);
                UpdateCurrentGenreLabel(tagFile);
                UpdateActiveFilePathLabel();
                UpdateActiveFileNameLabel();
            }
        }

        public void UpdateCurrentArtistLabel(TagLib.File tagFile)
        {
            this.currentArtistLabel.Text = tagFile.Tag.JoinedArtists;
        }

        public void UpdateCurrentTrackLabel(TagLib.File tagFile)
        {
            this.currentTrackLabel.Text = tagFile.Tag.Title;
        }

        public void UpdateCurrentAlbumLabel(TagLib.File tagFile)
        {
            this.currentAlbumLabel.Text = tagFile.Tag.Album;
        }

        public void UpdateCurrentGenreLabel(TagLib.File tagFile)
        {
            this.currentGenreLabel.Text = tagFile.Tag.JoinedGenres;
        }

        public void UpdateActiveFilePathLabel()
        {
            this.activeFilePathLabel.Text = FilePathOfSelectedMP3;
        }

        public void UpdateActiveFileNameLabel()
        {
            currentFileNameLabel.Text = System.IO.Path.GetFileName(FilePathOfSelectedMP3);
        }

    }
}
