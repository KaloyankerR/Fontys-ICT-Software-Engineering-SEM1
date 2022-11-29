using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicPlayer
{
    internal class Song
    {
        private int id;
        private string artist;
        private string title;
        private int durationInSeconds;

        public Song(int id, string artist, string title, int durationInSeconds)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetArtist()
        {
            return this.artist;
        }

        public string GetInfo()
        {
            return $"- ID {this.id}: {this.artist} - {this.title} ({this.durationInSeconds})";
        }
    }
}
