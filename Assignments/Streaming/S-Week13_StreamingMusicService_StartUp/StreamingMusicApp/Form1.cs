using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamingMusicPlayer;

namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        List<string> users;
        StreamingMusicService musicPlayer;

        public Form1()
        {
            InitializeComponent();
            musicPlayer = new StreamingMusicService("Spotify");
            users = new List<string>();
            this.FillGenres();
        }

        // ---------------------------- Filling
        private void FillGenres()
        {
            //var genres = Genre.Genres;
            foreach (string genre in Enum.GetNames(typeof(Genre.Genres)))
            {
                combobxSongsGenres.Items.Add(genre);
            }
        }

        private void FillUsersSongs()
        {
            combobxFavouritesUser.Items.Clear();
            combobxFavouritesSong.Items.Clear();

            foreach (string user in users)
            {
                combobxFavouritesUser.Items.Add(user);
            }

            foreach (Song song in musicPlayer.GetSongs())
            {
                combobxFavouritesSong.Items.Add(song.GetInfo());
            }

        }

        private void FillListboxSongs()
        {
            listbxSongs.Items.Clear();

            foreach(Song song in musicPlayer.GetSongs())
            {
                listbxSongs.Items.Add(song.GetInfo());
            }
        }

        private void FillListboxUsers()
        {
            listbxUsers.Items.Clear();

            foreach(string name in musicPlayer.GetUsersNames())
            {
                listbxUsers.Items.Add(name);
            }
            
        }

        // ---------------------------------- Adding
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            if (musicPlayer.ValidateUserIsUnique(name))
            {
                string email = txtUserEmail.Text;
                string address = txtUserAddress.Text;

                musicPlayer.AddUser(name, email, address);
                //lblResult.Text = musicPlayer.GetUsers();
                users.Add(name);
                FillListboxUsers();
                // combobxFavouritesUser.Items.Add(name);
            }
            else
            {
                MessageBox.Show("User already exists", "Error");
            }
            
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtUserAddress.Text = "";
            FillUsersSongs();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string artist = txtSongArtist.Text;
            string title = txtSongTitle.Text;
            int duration = Convert.ToInt32(txtSongDuration.Text);
            string genre = combobxSongsGenres.Text;

            musicPlayer.AddSong(artist, title, duration, genre);

            txtSongArtist.Text = "";
            txtSongTitle.Text = "";
            txtSongDuration.Text = "";
            combobxSongsGenres.Text = "";

            FillUsersSongs();
            FillListboxSongs();
        }

        private void btnFavouritesAdd_Click(object sender, EventArgs e)
        {
            // User userObj = users;
        }

        // ---------------------------------- Main page
        private void btnRedirectUsers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabpgUsers;
        }

        private void btnRedirectSongs_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabpgSongs;
        }

        private void btnRedirectFavourites_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabpgFavourites;
        }

        
    }
}
