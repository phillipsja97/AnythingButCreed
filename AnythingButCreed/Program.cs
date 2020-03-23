using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();

            var song1 = new Song("Creed", "Arms Wide Open");
            var song2 = new Song("Blink 182", "Anthem Part 2");
            var song3 = new Song("Fiji", "Love of my Life");
            var song4 = new Song("Red Hot Chili Peppers", "Snow (Hey Oh)");
            var song5 = new Song("Semisonic", "Closing Time");
            var song6 = new Song("Fall Out Boy", "Chicago Is So Two Years Ago");
            var song7 = new Song("Tupac", "All Eyes on Me");
            var song8 = new Song("Coolio", "Gangstas Paradise");
            var song9 = new Song("N.W.A", "Straight Out of Compton");
            var song10 = new Song("Tupac", "Ghetto Gospel");
            var song11 = new Song("Biggie", "Juicy");
            var song12 = new Song("Toto", "Africa");

            List<Song> allSongs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12 };

            var checkForCreed = allSongs.Where(song => !song.Artist.Contains("Creed"));

            foreach (var artist in checkForCreed)
            {
                goodSongs.Add(artist);
            }

            foreach (var song in goodSongs)
            {
            Console.WriteLine(song.Name);
            }

            Console.ReadLine();

        }
    }
}
