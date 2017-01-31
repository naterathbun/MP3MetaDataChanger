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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateArtistButton
            // 
            this.updateArtistButton.Location = new System.Drawing.Point(701, 55);
            this.updateArtistButton.Name = "updateArtistButton";
            this.updateArtistButton.Size = new System.Drawing.Size(122, 29);
            this.updateArtistButton.TabIndex = 0;
            this.updateArtistButton.Text = "Update Artist";
            this.updateArtistButton.UseVisualStyleBackColor = true;
            this.updateArtistButton.Click += new System.EventHandler(this.updateArtistButton_Click);
            // 
            // updateTrackButton
            // 
            this.updateTrackButton.Location = new System.Drawing.Point(701, 101);
            this.updateTrackButton.Name = "updateTrackButton";
            this.updateTrackButton.Size = new System.Drawing.Size(122, 29);
            this.updateTrackButton.TabIndex = 1;
            this.updateTrackButton.Text = "Update Track";
            this.updateTrackButton.UseVisualStyleBackColor = true;
            this.updateTrackButton.Click += new System.EventHandler(this.updateTrackButton_Click);
            // 
            // updateAlbumButton
            // 
            this.updateAlbumButton.Location = new System.Drawing.Point(701, 145);
            this.updateAlbumButton.Name = "updateAlbumButton";
            this.updateAlbumButton.Size = new System.Drawing.Size(122, 29);
            this.updateAlbumButton.TabIndex = 2;
            this.updateAlbumButton.Text = "Update Album";
            this.updateAlbumButton.UseVisualStyleBackColor = true;
            this.updateAlbumButton.Click += new System.EventHandler(this.updateAlbumButton_Click);
            // 
            // updateGenreButton
            // 
            this.updateGenreButton.Location = new System.Drawing.Point(701, 186);
            this.updateGenreButton.Name = "updateGenreButton";
            this.updateGenreButton.Size = new System.Drawing.Size(122, 29);
            this.updateGenreButton.TabIndex = 3;
            this.updateGenreButton.Text = "Update Genre";
            this.updateGenreButton.UseVisualStyleBackColor = true;
            this.updateGenreButton.Click += new System.EventHandler(this.updateGenreButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.updateArtistButton);
            this.groupBox1.Controls.Add(this.updateTrackButton);
            this.groupBox1.Controls.Add(this.updateGenreButton);
            this.groupBox1.Controls.Add(this.updateAlbumButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Meta Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(363, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 26);
            this.textBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 389);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Meta Data Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

