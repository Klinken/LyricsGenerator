using System;
using System.Collections.Generic;

namespace LyricsGenerator
{
    class Program
    {

        public class Song
        {
            public string Artist { get; set; }
            public string Title { get; set; }
            public string Lyrics { get; set; }
        }

        static void Main(string[] args)
        {
            // DATA
            List<Song> songs = new List<Song>
            {
                new Song
                {
                    Artist = "Red Hot Chili Peppers",
                    Title = "Fortune Faded",
                    Lyrics =
                           "They say in chess you've got to kill the queen and then you made it" +
                           "\nOh I, do you" +
                           "\nA funny thing, the king who gets himself assassinated" +
                           "\nHey now, every time I lose" +
                           "\nAltitude",
                },
                new Song
                {
                    Artist = "The Strokes",
                    Title = "Reptilia",
                    Lyrics =
                    "",
                }
            };

            // METHODS

            // EXECUTION



            songs.ForEach(
                x =>
                Console.WriteLine($"{songs.FindIndex(y => y.Artist == x.Artist) + 1}. {x.Title} by {x.Artist}")
                ) ;

        }
    }
}
