namespace MP3MetaDataChanger
{
    partial class Form1
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
            this.updateArtistButton = new System.Windows.Forms.Button();
            this.updateTrackButton = new System.Windows.Forms.Button();
            this.updateAlbumButton = new System.Windows.Forms.Button();
            this.updateGenreButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.renameFileBox = new System.Windows.Forms.TextBox();
            this.mp3FileFormatLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.currentFileNameLabel = new System.Windows.Forms.Label();
            this.renameFileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newGenreBox = new System.Windows.Forms.TextBox();
            this.newAlbumBox = new System.Windows.Forms.TextBox();
            this.newTrackBox = new System.Windows.Forms.TextBox();
            this.newArtistBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentGenreLabel = new System.Windows.Forms.Label();
            this.currentAlbumLabel = new System.Windows.Forms.Label();
            this.currentTrackLabel = new System.Windows.Forms.Label();
            this.currentArtistLabel = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.activeFilePathLabel = new System.Windows.Forms.Label();
            this.FileLocationBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.FileLocationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateArtistButton
            // 
            this.updateArtistButton.Location = new System.Drawing.Point(832, 59);
            this.updateArtistButton.Name = "updateArtistButton";
            this.updateArtistButton.Size = new System.Drawing.Size(135, 45);
            this.updateArtistButton.TabIndex = 0;
            this.updateArtistButton.Text = "Update Artist";
            this.updateArtistButton.UseVisualStyleBackColor = true;
            this.updateArtistButton.Click += new System.EventHandler(this.updateArtistButton_Click);
            // 
            // updateTrackButton
            // 
            this.updateTrackButton.Location = new System.Drawing.Point(832, 130);
            this.updateTrackButton.Name = "updateTrackButton";
            this.updateTrackButton.Size = new System.Drawing.Size(135, 45);
            this.updateTrackButton.TabIndex = 1;
            this.updateTrackButton.Text = "Update Track";
            this.updateTrackButton.UseVisualStyleBackColor = true;
            this.updateTrackButton.Click += new System.EventHandler(this.updateTrackButton_Click);
            // 
            // updateAlbumButton
            // 
            this.updateAlbumButton.Location = new System.Drawing.Point(832, 198);
            this.updateAlbumButton.Name = "updateAlbumButton";
            this.updateAlbumButton.Size = new System.Drawing.Size(135, 45);
            this.updateAlbumButton.TabIndex = 2;
            this.updateAlbumButton.Text = "Update Album";
            this.updateAlbumButton.UseVisualStyleBackColor = true;
            this.updateAlbumButton.Click += new System.EventHandler(this.updateAlbumButton_Click);
            // 
            // updateGenreButton
            // 
            this.updateGenreButton.Location = new System.Drawing.Point(832, 270);
            this.updateGenreButton.Name = "updateGenreButton";
            this.updateGenreButton.Size = new System.Drawing.Size(135, 43);
            this.updateGenreButton.TabIndex = 3;
            this.updateGenreButton.Text = "Update Genre";
            this.updateGenreButton.UseVisualStyleBackColor = true;
            this.updateGenreButton.Click += new System.EventHandler(this.updateGenreButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.renameFileButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.updateArtistButton);
            this.groupBox1.Controls.Add(this.updateTrackButton);
            this.groupBox1.Controls.Add(this.updateGenreButton);
            this.groupBox1.Controls.Add(this.updateAlbumButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 444);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.renameFileBox);
            this.groupBox5.Controls.Add(this.mp3FileFormatLabel);
            this.groupBox5.Location = new System.Drawing.Point(423, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 89);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update File Name";
            // 
            // renameFileBox
            // 
            this.renameFileBox.Location = new System.Drawing.Point(25, 35);
            this.renameFileBox.Name = "renameFileBox";
            this.renameFileBox.Size = new System.Drawing.Size(311, 26);
            this.renameFileBox.TabIndex = 4;
            // 
            // mp3FileFormatLabel
            // 
            this.mp3FileFormatLabel.AutoSize = true;
            this.mp3FileFormatLabel.Location = new System.Drawing.Point(342, 38);
            this.mp3FileFormatLabel.Name = "mp3FileFormatLabel";
            this.mp3FileFormatLabel.Size = new System.Drawing.Size(44, 20);
            this.mp3FileFormatLabel.TabIndex = 8;
            this.mp3FileFormatLabel.Text = ".mp3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.currentFileNameLabel);
            this.groupBox4.Location = new System.Drawing.Point(14, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 89);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current File Name";
            // 
            // currentFileNameLabel
            // 
            this.currentFileNameLabel.AutoSize = true;
            this.currentFileNameLabel.Location = new System.Drawing.Point(6, 38);
            this.currentFileNameLabel.Name = "currentFileNameLabel";
            this.currentFileNameLabel.Size = new System.Drawing.Size(96, 20);
            this.currentFileNameLabel.TabIndex = 4;
            this.currentFileNameLabel.Text = "[ File Name ]";
            // 
            // renameFileButton
            // 
            this.renameFileButton.Location = new System.Drawing.Point(832, 357);
            this.renameFileButton.Name = "renameFileButton";
            this.renameFileButton.Size = new System.Drawing.Size(135, 56);
            this.renameFileButton.TabIndex = 7;
            this.renameFileButton.Text = "Rename File";
            this.renameFileButton.UseVisualStyleBackColor = true;
            this.renameFileButton.Click += new System.EventHandler(this.renameFileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newGenreBox);
            this.groupBox3.Controls.Add(this.newAlbumBox);
            this.groupBox3.Controls.Add(this.newTrackBox);
            this.groupBox3.Controls.Add(this.newArtistBox);
            this.groupBox3.Location = new System.Drawing.Point(423, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 306);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Meta Data";
            // 
            // newGenreBox
            // 
            this.newGenreBox.Location = new System.Drawing.Point(25, 254);
            this.newGenreBox.Name = "newGenreBox";
            this.newGenreBox.Size = new System.Drawing.Size(338, 26);
            this.newGenreBox.TabIndex = 3;
            // 
            // newAlbumBox
            // 
            this.newAlbumBox.Location = new System.Drawing.Point(25, 183);
            this.newAlbumBox.Name = "newAlbumBox";
            this.newAlbumBox.Size = new System.Drawing.Size(338, 26);
            this.newAlbumBox.TabIndex = 2;
            // 
            // newTrackBox
            // 
            this.newTrackBox.Location = new System.Drawing.Point(25, 115);
            this.newTrackBox.Name = "newTrackBox";
            this.newTrackBox.Size = new System.Drawing.Size(338, 26);
            this.newTrackBox.TabIndex = 1;
            // 
            // newArtistBox
            // 
            this.newArtistBox.Location = new System.Drawing.Point(25, 44);
            this.newArtistBox.Name = "newArtistBox";
            this.newArtistBox.Size = new System.Drawing.Size(338, 26);
            this.newArtistBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentGenreLabel);
            this.groupBox2.Controls.Add(this.currentAlbumLabel);
            this.groupBox2.Controls.Add(this.currentTrackLabel);
            this.groupBox2.Controls.Add(this.currentArtistLabel);
            this.groupBox2.Location = new System.Drawing.Point(14, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Meta Data";
            // 
            // currentGenreLabel
            // 
            this.currentGenreLabel.AutoSize = true;
            this.currentGenreLabel.Location = new System.Drawing.Point(6, 257);
            this.currentGenreLabel.Name = "currentGenreLabel";
            this.currentGenreLabel.Size = new System.Drawing.Size(116, 20);
            this.currentGenreLabel.TabIndex = 3;
            this.currentGenreLabel.Text = "[ Genre Name ]";
            // 
            // currentAlbumLabel
            // 
            this.currentAlbumLabel.AutoSize = true;
            this.currentAlbumLabel.Location = new System.Drawing.Point(6, 186);
            this.currentAlbumLabel.Name = "currentAlbumLabel";
            this.currentAlbumLabel.Size = new System.Drawing.Size(116, 20);
            this.currentAlbumLabel.TabIndex = 2;
            this.currentAlbumLabel.Text = "[ Album Name ]";
            // 
            // currentTrackLabel
            // 
            this.currentTrackLabel.AutoSize = true;
            this.currentTrackLabel.Location = new System.Drawing.Point(6, 118);
            this.currentTrackLabel.Name = "currentTrackLabel";
            this.currentTrackLabel.Size = new System.Drawing.Size(110, 20);
            this.currentTrackLabel.TabIndex = 1;
            this.currentTrackLabel.Text = "[ Track Name ]";
            // 
            // currentArtistLabel
            // 
            this.currentArtistLabel.AutoSize = true;
            this.currentArtistLabel.Location = new System.Drawing.Point(6, 47);
            this.currentArtistLabel.Name = "currentArtistLabel";
            this.currentArtistLabel.Size = new System.Drawing.Size(108, 20);
            this.currentArtistLabel.TabIndex = 0;
            this.currentArtistLabel.Text = "[ Artist Name ]";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(596, 16);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(394, 56);
            this.SelectFileButton.TabIndex = 5;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // activeFilePathLabel
            // 
            this.activeFilePathLabel.AutoSize = true;
            this.activeFilePathLabel.Location = new System.Drawing.Point(10, 29);
            this.activeFilePathLabel.Name = "activeFilePathLabel";
            this.activeFilePathLabel.Size = new System.Drawing.Size(0, 20);
            this.activeFilePathLabel.TabIndex = 6;
            // 
            // FileLocationBox
            // 
            this.FileLocationBox.Controls.Add(this.activeFilePathLabel);
            this.FileLocationBox.Location = new System.Drawing.Point(12, 78);
            this.FileLocationBox.Name = "FileLocationBox";
            this.FileLocationBox.Size = new System.Drawing.Size(978, 65);
            this.FileLocationBox.TabIndex = 9;
            this.FileLocationBox.TabStop = false;
            this.FileLocationBox.Text = "File Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1002, 607);
            this.Controls.Add(this.FileLocationBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Meta Data Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FileLocationBox.ResumeLayout(false);
            this.FileLocationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateArtistButton;
        private System.Windows.Forms.Button updateTrackButton;
        private System.Windows.Forms.Button updateAlbumButton;
        private System.Windows.Forms.Button updateGenreButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newGenreBox;
        private System.Windows.Forms.TextBox newAlbumBox;
        private System.Windows.Forms.TextBox newTrackBox;
        private System.Windows.Forms.TextBox newArtistBox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label currentGenreLabel;
        private System.Windows.Forms.Label currentAlbumLabel;
        private System.Windows.Forms.Label currentTrackLabel;
        private System.Windows.Forms.Label currentArtistLabel;
        private System.Windows.Forms.Label activeFilePathLabel;
        private System.Windows.Forms.Button renameFileButton;
        private System.Windows.Forms.TextBox renameFileBox;
        private System.Windows.Forms.Label mp3FileFormatLabel;
        private System.Windows.Forms.GroupBox FileLocationBox;
        private System.Windows.Forms.Label currentFileNameLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

