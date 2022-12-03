using StreamingMusicApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicPlayer
{
    internal class User
    {
        private List<Song> favourites;
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
            this.favourites = new List<Song>();
        }

        public User(string name, string email, string address)
        {
            MAX_SONGS_IN_FAVOURITE = 50;
            this.name = name;
            this.email = email;
            this.address = address;
            this.favourites = new List<Song>();
        }

        public void AddSongToFavourite(Song song)
        {
            favourites.Add(song);
        }

        public void RemoveSongFromFavourite(Song song)
        {
            favourites.Remove(song);
            // potential error
        }

        public string GetFavouriteSongs()
        {
            string favouriteSongs = "";
            
            foreach(Song song in favourites)
            {
                favouriteSongs += $"{song.GetInfo()}\n";
            }

            return favouriteSongs;
        }
        
        public string GetName()
        {
            return name;
        }

        public string GetInfo()
        {
            return $"{name} - {email} - {address}";
        }
    }
}