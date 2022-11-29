﻿using System;
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

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
        }

        public void AddSong(string artist, string title, int durationInSeconds)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds));
            this.songIdSeeder++;
        }

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

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs)";
        }
    }
}
