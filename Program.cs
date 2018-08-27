using System;
using System.Collections.Generic;
namespace NickelBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> songs = new HashSet<(string, string)>();
            songs.Add(("Nickelback", "Goodbye"));
            songs.Add(("Slipknot", "Psychosocial"));
            songs.Add(("Alice in Chains", "Rooster"));
            songs.Add(("Nickelback", "Rockstar"));
            songs.Add(("Soundgarden", "Outshined"));
            songs.Add(("Audioslave", "Like a Stone"));
            songs.Add(("Nickelback", "Animals"));
            foreach ((string, string) item in songs)
            {
                if(item.Item1 != "Nickelback")
                {
                    goodSongs.Add((item.Item1, item.Item2));
                }
            }
            foreach ((string, string) item in goodSongs)
            {
                Console.WriteLine($"{item.Item2} by {item.Item1}");
            }
        }
    }
}
