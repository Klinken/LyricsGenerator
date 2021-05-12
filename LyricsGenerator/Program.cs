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
            // Variables

            int count = 0;

            // DATA
            List<Song> songs = new List<Song>
            {
                new Song
                {
                    Artist = "Red Hot Chili Peppers",
                    Title = "Fortune Faded",
                    Lyrics =
                           "\nThey say in chess you've got to kill the queen and then you made it" +
                           "\nOh I, do you" +
                           "\nA funny thing, the king who gets himself assassinated" +
                           "\nHey now, every time I lose" +
                           "\nAltitude" +
                           "\n\nYou took a town by storm the mess you made was nominated" +
                           "\nOh I, do you" +
                           "\nNow put away your welcome soon you'll find you've overstayed it" +
                           "\nHey now, every time I lose" +
                           "\nAltitude" +
                           "\n\nSo divine" +
                           "\nHell of an Elevator" +
                           "\nAll the while my fortune fade" +
                           "\nNever mind, the consequences of the crime this time my fortune faded" +
                           "\n\nThe medicated state of mind" +
                           "\nYou'll find is overrated" +
                           "\nOh I, do you" +
                           "\nYou saw it all come down and now its time to imitate it" +
                           "\nHey now, every time I lose" +
                           "\nAltitude",
                },
                new Song
                {
                    Artist = "The Strokes",
                    Title = "Reptilia",
                    Lyrics =
                    "\nHe seemed impressed by the way you came in" +
                    "\nTell us a story, i know you're not boring" +
                    "\nI was afraid that you would not insist" +
                    "\nYou sound so sleepy, just take this, now leave me" +
                    "\n\nI said: \"Please don't slow me down if I'm going too fast\"" +
                    "\nYou\'re in a strange part of our town" +
                    "\n\nYeah, the night's not over" +
                    "\nYou're not trying hard enough," +
                    "\nOur lives are changing lanes" +
                    "\nYou ran me off the road" +
                    "\nThe wait is over" +
                    "\nNow I'm taking over" +
                    "\nYou're no longer laughing" +
                    "\nI'm not drowning fast enough" +
                    "\n\nNow everytime that I look at myself" +
                    "\nI thought I told you, this world is not for you" +
                    "\nThe room is on fire as she's fixing her hair" +
                    "\nYou sound so angry, just calm down you found me" +
                    "\n\nI said: \"Please don't slow me down if I'm going too fast\"" +
                    "\nYou're in a strange part of our town" +
                    "\n\nYeah, the night's not over" +
                    "\nYou're not trying hard enough," +
                    "\nOur lives are changin lanes" +
                    "\nYou ran me off the road" +
                    "\nThe wait is over" +
                    "\nNow I'm taking over" +
                    "\nYou're no longer laughing" +
                    "\nI'm not drowning fast enough ",
                },
                new Song
                {
                    Artist = "Steely Dan",
                    Title = "Black Friday",
                    Lyrics =
                    "\nWhen Black Friday comes" +
                    "\nI'll stand down by the door" +
                    "\nAnd catch the grey men when they" +
                    "\nDive from the fourteenth floor" +
                    "\nWhen Black Friday comes" +
                    "\nI'll collect everything I'm owed" +
                    "\nAnd before my friends find out" +
                    "\nI'll be on the road" +
                    "\nWhen Black Friday falls you know it's got to be" +
                    "\nDon't let it fall on me" +
                    "\n\nWhen Black Friday comes" +
                    "\nI'll fly down to Muswellbrook" +
                    "\nGonna strike all the big red words" +
                    "\nFrom my little black book" +
                    "\nGonna do just what I please" +
                    "\nGonna wear no socks and shoes" +
                    "\nWith nothing to do but feed" +
                    "\nAll the kangaroos" +
                    "\nWhen Black Friday comes I'll be on that hill" +
                    "\nYou know I will" +
                    "\n\nWhen Black Friday comes" +
                    "\nI'm gonna dig myself a hole" +
                    "\nGonna lay down in it 'til" +
                    "\nI satisfy my soul" +
                    "\nGonna let the world pass by me" +
                    "\nThe Archbishop's gonna sanctify me" +
                    "\nAnd if he don't come across" +
                    "\nI'm gonna let it roll" +
                    "\nWhen Black Friday comes" +
                    "\nI'm gonna stake my claim" +
                    "\nI'll guess I'll change my name ",
                },
                new Song
                {
                    Artist = "John Hiatt",
                    Title = "Across The Borderline",
                    Lyrics =
                    "\nThere's a place, so I've been told," +
                    "\nEvery street is paved with gold" +
                    "\nAnd it's just across the borderline" +
                    "\nAnd when it's time to take your turn" +
                    "\nThere's a lesson that you must learn" +
                    "\nYou may lose more than you'll ever hope to find." +
                    "\n\nAnd when you reach that broken promised land" +
                    "\nAnd all your dreams slip though your hand" +
                    "\nYou have learned it's too late to change your mind" +
                    "\nCause you pay the price to come so far" +
                    "\nJust to wind up where you are" +
                    "\nAnd you're still just across the borderline." +
                    "\n\nUp and down the rio grande" +
                    "\nA thousand foot prints in the sand" +
                    "\nReveal a secret no one can define" +
                    "\nThe river rolls on like a breath" +
                    "\nIn between our life and death" +
                    "\nTell me who is next to cross that borderline." +
                    "\n\nAnd when you reach that broken promised land" +
                    "\nAnd all your dreams slip though your hand" +
                    "\nYou'll know it's too late to change your mind" +
                    "\nCause you pay the price to come so far" +
                    "\nJust to wind up where you are" +
                    "\nAnd you're still just across the borderline.",
                },
                new Song
                {
                    Artist = "Jonny Lang",
                    Title = "Lie to me",
                    Lyrics =
                    "\nLie to me and tell me everything is all right" +
                    "\nLie to me and tell me that you'r stayin' the night" +
                    "\nTell me that you'll never leave" +
                    "\nand I'll just try to make believe" +
                    "\nthat everything you tell me is true" +
                    "\n\nCome on baby won't you just" +
                    "\nLie to me, go ahead and lie to me" +
                    "\n\nLie to me, it don't matter anymore" +
                    "\nIt could never be the way it was before" +
                    "\nIf I can't hold on to you" +
                    "\nleave me with somethin' I can hold onto" +
                    "\nfor just a little while won't you let me dream" +
                    "\n\nAnyone can see" +
                    "\nthat you love him more than me" +
                    "\nBut right now, baby, let me pretend" +
                    "\nthat our love will never end" +
                    "\n\nLie to me, go ahead and lie to me",
                },
            };

            // METHODS

            void displaySongs()
            {
                songs.ForEach(
                    x =>
                    Console.WriteLine(
                        $"{songs.FindIndex(y => y.Artist == x.Artist) + 1}. {x.Title} by {x.Artist}"
                        ));
            }

            void getSelection()
            {
                string selection = Console.ReadLine();

                try
                {
                    int song = Convert.ToInt32(selection) - 1;

                    string title = songs[song].Title;

                    string artist = songs[song].Artist;

                    Console.WriteLine($"\nYou chose {title} by {artist}. Enjoy:");

                    Console.WriteLine($"\n------ {title} by {artist} ------");

                    Console.WriteLine(songs[song].Lyrics);

                }
                catch (Exception)
                {
                    Console.Write("There's a problem with your input, try again: ");

                    getSelection();

                }

            }

            // EXECUTION

            void run()
            {

                Console.WriteLine($"" +
                    $"{(count == 0 ? "Welcome to the lyrics generator, please select a" : "\nPlease select another")} " +
                    $"song from this top {songs.Count}:\n");

                displaySongs();

                Console.Write("\nwhich song do you wish to sing: ");

                getSelection();

                count++;

                Console.Write("\nWant to sing another song? write y/yes: ");

                string runAgain = Console.ReadLine();

                if (runAgain == "y" ||
                    runAgain == "yes")
                {
                    run();
                }
                else
                {
                    Console.WriteLine("\nThank you, for singing along!");
                }

            }

            run();

        }
    }
}
