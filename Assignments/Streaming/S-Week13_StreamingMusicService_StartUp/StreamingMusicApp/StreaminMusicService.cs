using StreamingMusicPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> users;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
            this.users = new List<User>();
        }

        // -------------------------- Adding
        public void AddUser(string name, string email, string address)
        {
            this.users.Add(new User(name, email, address));
            this.songIdSeeder++;
        }

        public void AddSong(string artist, string title, int durationInSeconds, string genre)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, genre));
            this.songIdSeeder++;
        }


        // --------------------------- Getters
        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }
         
        public Song[] GetSongs()
        {
            return this.songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if(artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }

        //public User[] GetUsersList()
        //{
        //    return this.users.ToArray();
        //}

        //public User[] UsersArray => this.users.ToArray();

        public string GetUsers()
        {
            return $"{users.Count()}";
        }

        public string[] GetUsersNames()
        {
            string[] names = new string[users.Count()];

            for (int i = 0; i < users.Count(); i++)
            {
                names[i] = users[i].GetInfo();
            }

            return names;

        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs)";
        }


        // ---------------------------- Others
        public bool ValidateUserIsUnique(string name)
        {
            foreach(User user in users)
            {
                if (user.GetName() == name)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
