using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private int id;
        private string artist;
        private string title;        
        private int durationInSeconds;
        private string genre;

        public Song(int id, string artist, string title, int durationInSeconds, string genre)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            this.genre = genre;
        }

        public int GetId()
        { return this.id; }

        public string GetArtist()
        { return this.artist; }

        public string GetInfo()
        {
            return $"ID {this.id:00}: {this.artist} - {this.title} ({this.durationInSeconds} seconds)";
        }
    }
}
