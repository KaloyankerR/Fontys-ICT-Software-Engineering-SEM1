
namespace StreamingMusicApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpgMain = new System.Windows.Forms.TabPage();
            this.btnRedirectFavourites = new System.Windows.Forms.Button();
            this.btnRedirectSongs = new System.Windows.Forms.Button();
            this.btnRedirectUsers = new System.Windows.Forms.Button();
            this.tabpgUsers = new System.Windows.Forms.TabPage();
            this.listbxUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpgSongs = new System.Windows.Forms.TabPage();
            this.listbxSongs = new System.Windows.Forms.ListBox();
            this.combobxSongsGenres = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.txtSongDuration = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSongArtist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabpgFavourites = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFavouritesAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.combobxFavouritesSong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combobxFavouritesUser = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabpgMain.SuspendLayout();
            this.tabpgUsers.SuspendLayout();
            this.tabpgSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSongDuration)).BeginInit();
            this.tabpgFavourites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpgMain);
            this.tabControl1.Controls.Add(this.tabpgUsers);
            this.tabControl1.Controls.Add(this.tabpgSongs);
            this.tabControl1.Controls.Add(this.tabpgFavourites);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpgMain
            // 
            this.tabpgMain.Controls.Add(this.btnRedirectFavourites);
            this.tabpgMain.Controls.Add(this.btnRedirectSongs);
            this.tabpgMain.Controls.Add(this.btnRedirectUsers);
            this.tabpgMain.Location = new System.Drawing.Point(4, 34);
            this.tabpgMain.Name = "tabpgMain";
            this.tabpgMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgMain.Size = new System.Drawing.Size(783, 397);
            this.tabpgMain.TabIndex = 0;
            this.tabpgMain.Text = "Main";
            this.tabpgMain.UseVisualStyleBackColor = true;
            // 
            // btnRedirectFavourites
            // 
            this.btnRedirectFavourites.Location = new System.Drawing.Point(329, 179);
            this.btnRedirectFavourites.Name = "btnRedirectFavourites";
            this.btnRedirectFavourites.Size = new System.Drawing.Size(112, 34);
            this.btnRedirectFavourites.TabIndex = 2;
            this.btnRedirectFavourites.Text = "Favourites";
            this.btnRedirectFavourites.UseVisualStyleBackColor = true;
            this.btnRedirectFavourites.Click += new System.EventHandler(this.btnRedirectFavourites_Click);
            // 
            // btnRedirectSongs
            // 
            this.btnRedirectSongs.Location = new System.Drawing.Point(389, 139);
            this.btnRedirectSongs.Name = "btnRedirectSongs";
            this.btnRedirectSongs.Size = new System.Drawing.Size(112, 34);
            this.btnRedirectSongs.TabIndex = 1;
            this.btnRedirectSongs.Text = "Songs";
            this.btnRedirectSongs.UseVisualStyleBackColor = true;
            this.btnRedirectSongs.Click += new System.EventHandler(this.btnRedirectSongs_Click);
            // 
            // btnRedirectUsers
            // 
            this.btnRedirectUsers.Location = new System.Drawing.Point(271, 139);
            this.btnRedirectUsers.Name = "btnRedirectUsers";
            this.btnRedirectUsers.Size = new System.Drawing.Size(112, 34);
            this.btnRedirectUsers.TabIndex = 0;
            this.btnRedirectUsers.Text = "Users";
            this.btnRedirectUsers.UseVisualStyleBackColor = true;
            this.btnRedirectUsers.Click += new System.EventHandler(this.btnRedirectUsers_Click);
            // 
            // tabpgUsers
            // 
            this.tabpgUsers.Controls.Add(this.listbxUsers);
            this.tabpgUsers.Controls.Add(this.btnAddUser);
            this.tabpgUsers.Controls.Add(this.txtUserAddress);
            this.tabpgUsers.Controls.Add(this.txtUserEmail);
            this.tabpgUsers.Controls.Add(this.txtUserName);
            this.tabpgUsers.Controls.Add(this.label3);
            this.tabpgUsers.Controls.Add(this.label2);
            this.tabpgUsers.Controls.Add(this.label1);
            this.tabpgUsers.Location = new System.Drawing.Point(4, 34);
            this.tabpgUsers.Name = "tabpgUsers";
            this.tabpgUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgUsers.Size = new System.Drawing.Size(783, 397);
            this.tabpgUsers.TabIndex = 1;
            this.tabpgUsers.Text = "Users";
            this.tabpgUsers.UseVisualStyleBackColor = true;
            // 
            // listbxUsers
            // 
            this.listbxUsers.FormattingEnabled = true;
            this.listbxUsers.ItemHeight = 25;
            this.listbxUsers.Location = new System.Drawing.Point(343, 43);
            this.listbxUsers.Name = "listbxUsers";
            this.listbxUsers.Size = new System.Drawing.Size(410, 204);
            this.listbxUsers.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(292, 322);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(112, 34);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Location = new System.Drawing.Point(50, 215);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(209, 31);
            this.txtUserAddress.TabIndex = 5;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(50, 123);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(209, 31);
            this.txtUserEmail.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(50, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 31);
            this.txtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address (Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabpgSongs
            // 
            this.tabpgSongs.Controls.Add(this.listbxSongs);
            this.tabpgSongs.Controls.Add(this.combobxSongsGenres);
            this.tabpgSongs.Controls.Add(this.label11);
            this.tabpgSongs.Controls.Add(this.btnAddSong);
            this.tabpgSongs.Controls.Add(this.txtSongDuration);
            this.tabpgSongs.Controls.Add(this.label7);
            this.tabpgSongs.Controls.Add(this.txtSongTitle);
            this.tabpgSongs.Controls.Add(this.label6);
            this.tabpgSongs.Controls.Add(this.txtSongArtist);
            this.tabpgSongs.Controls.Add(this.label5);
            this.tabpgSongs.Location = new System.Drawing.Point(4, 34);
            this.tabpgSongs.Name = "tabpgSongs";
            this.tabpgSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSongs.Size = new System.Drawing.Size(783, 397);
            this.tabpgSongs.TabIndex = 2;
            this.tabpgSongs.Text = "Songs";
            this.tabpgSongs.UseVisualStyleBackColor = true;
            // 
            // listbxSongs
            // 
            this.listbxSongs.FormattingEnabled = true;
            this.listbxSongs.ItemHeight = 25;
            this.listbxSongs.Location = new System.Drawing.Point(324, 37);
            this.listbxSongs.Name = "listbxSongs";
            this.listbxSongs.Size = new System.Drawing.Size(435, 254);
            this.listbxSongs.TabIndex = 12;
            // 
            // combobxSongsGenres
            // 
            this.combobxSongsGenres.FormattingEnabled = true;
            this.combobxSongsGenres.Location = new System.Drawing.Point(50, 50);
            this.combobxSongsGenres.Name = "combobxSongsGenres";
            this.combobxSongsGenres.Size = new System.Drawing.Size(182, 33);
            this.combobxSongsGenres.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Genre";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(278, 334);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(112, 34);
            this.btnAddSong.TabIndex = 8;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // txtSongDuration
            // 
            this.txtSongDuration.Location = new System.Drawing.Point(55, 281);
            this.txtSongDuration.Name = "txtSongDuration";
            this.txtSongDuration.Size = new System.Drawing.Size(180, 31);
            this.txtSongDuration.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Duration in seconds";
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(55, 196);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(177, 31);
            this.txtSongTitle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Title";
            // 
            // txtSongArtist
            // 
            this.txtSongArtist.Location = new System.Drawing.Point(55, 125);
            this.txtSongArtist.Name = "txtSongArtist";
            this.txtSongArtist.Size = new System.Drawing.Size(177, 31);
            this.txtSongArtist.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Artist";
            // 
            // tabpgFavourites
            // 
            this.tabpgFavourites.Controls.Add(this.listBox1);
            this.tabpgFavourites.Controls.Add(this.btnFavouritesAdd);
            this.tabpgFavourites.Controls.Add(this.label10);
            this.tabpgFavourites.Controls.Add(this.combobxFavouritesSong);
            this.tabpgFavourites.Controls.Add(this.label9);
            this.tabpgFavourites.Controls.Add(this.combobxFavouritesUser);
            this.tabpgFavourites.Location = new System.Drawing.Point(4, 34);
            this.tabpgFavourites.Name = "tabpgFavourites";
            this.tabpgFavourites.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgFavourites.Size = new System.Drawing.Size(783, 397);
            this.tabpgFavourites.TabIndex = 3;
            this.tabpgFavourites.Text = "Favourites";
            this.tabpgFavourites.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(383, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 229);
            this.listBox1.TabIndex = 7;
            // 
            // btnFavouritesAdd
            // 
            this.btnFavouritesAdd.Location = new System.Drawing.Point(58, 244);
            this.btnFavouritesAdd.Name = "btnFavouritesAdd";
            this.btnFavouritesAdd.Size = new System.Drawing.Size(182, 34);
            this.btnFavouritesAdd.TabIndex = 6;
            this.btnFavouritesAdd.Text = "Add to Favourites";
            this.btnFavouritesAdd.UseVisualStyleBackColor = true;
            this.btnFavouritesAdd.Click += new System.EventHandler(this.btnFavouritesAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Song";
            // 
            // combobxFavouritesSong
            // 
            this.combobxFavouritesSong.FormattingEnabled = true;
            this.combobxFavouritesSong.Location = new System.Drawing.Point(39, 167);
            this.combobxFavouritesSong.Name = "combobxFavouritesSong";
            this.combobxFavouritesSong.Size = new System.Drawing.Size(219, 33);
            this.combobxFavouritesSong.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "User";
            // 
            // combobxFavouritesUser
            // 
            this.combobxFavouritesUser.FormattingEnabled = true;
            this.combobxFavouritesUser.Location = new System.Drawing.Point(58, 83);
            this.combobxFavouritesUser.Name = "combobxFavouritesUser";
            this.combobxFavouritesUser.Size = new System.Drawing.Size(182, 33);
            this.combobxFavouritesUser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabpgMain.ResumeLayout(false);
            this.tabpgUsers.ResumeLayout(false);
            this.tabpgUsers.PerformLayout();
            this.tabpgSongs.ResumeLayout(false);
            this.tabpgSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSongDuration)).EndInit();
            this.tabpgFavourites.ResumeLayout(false);
            this.tabpgFavourites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpgMain;
        private System.Windows.Forms.TabPage tabpgUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabpgSongs;
        private System.Windows.Forms.TextBox txtSongArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtSongDuration;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TabPage tabpgFavourites;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combobxFavouritesSong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combobxFavouritesUser;
        private System.Windows.Forms.Button btnRedirectFavourites;
        private System.Windows.Forms.Button btnRedirectSongs;
        private System.Windows.Forms.Button btnRedirectUsers;
        private System.Windows.Forms.ComboBox combobxSongsGenres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listbxSongs;
        private System.Windows.Forms.ListBox listbxUsers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFavouritesAdd;
    }
}

