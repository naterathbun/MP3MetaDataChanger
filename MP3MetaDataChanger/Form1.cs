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
        // File Path Strings
        public string FilePathOfSelectedMP3 { get; private set; } = "";

        public string FilePathOfWorkingDirectory { get; private set; } = "";


        // WinForm Required
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // Button Click Event Handlers
        private void SelectFileButton_Click(object sender, EventArgs e)
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
        

        // Update Labels with Current Info from the File
        public void UpdateCurrentMetaInformationLabels()
        {
            if (FileIsSelected())
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


        // Update Actual File Meta Data
        public void WriteUserEnteredArtistToFile()
        {
            if (FileIsSelected())
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Artists = new string[] { newArtistBox.Text };
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredTitleToFile()
        {
            if (FileIsSelected())
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Title = newTrackBox.Text;
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredAlbumToFile()
        {
            if (FileIsSelected())
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Album = newAlbumBox.Text;
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void WriteUserEnteredGenreToFile()
        {
            if (FileIsSelected())
            {
                TagLib.File tagFile = TagLib.File.Create(FilePathOfSelectedMP3);
                tagFile.Tag.Genres = new string[] { newGenreBox.Text };
                tagFile.Save();
            }
            UpdateCurrentMetaInformationLabels();
        }
        

        // File IO Methods
        public void GetUserSelectedFilePath()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetFilePathOfSelectedMP3();

                if (SelectedFileIsAnMP3())
                {
                    SetFilePathOfWorkingDirectory();
                    UpdateCurrentMetaInformationLabels();
                }
            }
        }

        public void RenameFileToUserEnteredName()
        {
            string FilePathOfRenamedMP3 = FilePathOfWorkingDirectory + @"\" + renameFileBox.Text + ".mp3";

            if (FileIsSelected() && RenameFileBoxIsNotBlank())
            {
                System.IO.File.Copy(FilePathOfSelectedMP3, FilePathOfRenamedMP3);
                System.IO.File.Delete(FilePathOfSelectedMP3);

                FilePathOfSelectedMP3 = FilePathOfRenamedMP3;
                renameFileBox.Text = "";
            }
            UpdateCurrentMetaInformationLabels();
        }

        public void SetFilePathOfWorkingDirectory()
        {
            FilePathOfWorkingDirectory = System.IO.Path.GetDirectoryName(FilePathOfSelectedMP3);
        }

        public void SetFilePathOfSelectedMP3()
        {
            FilePathOfSelectedMP3 = openFileDialog1.FileName;
        }


        // State Checks
        public bool FileIsSelected()
        {
            return (FilePathOfSelectedMP3 != "");
        }

        public bool RenameFileBoxIsNotBlank()
        {
            return (renameFileBox.Text != "");
        }

        public bool SelectedFileIsAnMP3()
        {
            return (FilePathOfSelectedMP3.Substring(FilePathOfSelectedMP3.Length - 4) == ".mp3");
        }

    }
}
