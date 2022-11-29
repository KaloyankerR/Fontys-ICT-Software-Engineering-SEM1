using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicPlayer
{
    internal class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
        }

        public void AddSong(string artist, string title, int durationInSeconds)
        {
            // pass
        }

        public Song GetSong(int id)
        {
            // pass
        }

        public Song[] GetSongs()
        {
            // pass
        }

        public Song[] GetSongs(string artist)
        {
            // pass
        }

        public string GetInfo()
        {
            // pass
        }

    }
}
