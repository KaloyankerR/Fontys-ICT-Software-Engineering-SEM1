using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicPlayer
{
    internal class User
    {
        private List<Song> favourites = new List<Song>();
        private int MAX_SONGS_IN_FAVOURITE;
        private string name;
        private string email;
        private string address;

        public User(string name, string email)
        {
            MAX_SONGS_IN_FAVOURITE = 50;
            this.name = name;
            this.email = email;
            this.address = "";
        }

        public User(string name, string email, string address)
        {
            MAX_SONGS_IN_FAVOURITE = 50;
            this.name = name;
            this.email = email;
            this.address = address;
        }

        public void AddSongToFavourite(Song song)
        {
            // pass
        }

        public void RemoveSongFromFavourite(Song song)
        {
            // pass
        }

        public string GetFavouriteSongs()
        {
            // pass
        }
    }
}
