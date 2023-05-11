using System;
using System.Collections.Generic;

namespace Lab_Theatre
{
    public class Theatre
    {
        private List<Show> shows;

        public string Name { get; }

        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            int Lineno = 1;
            foreach (Show show in shows)
            {
                Console.WriteLine($"{Lineno++}: {show.ToString()}");
            }
        }

        public void PrintShows(Genre genre)
        {
            int Lineno = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{Lineno++}: {show.ToString()}");
                }
            }
        }

        public void PrintShows(Day day)
        {
            int Lineno = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.WriteLine($"{Lineno++}: {show.ToString()}");
                }
            }
        }

        public void PrintShows(Time time)
        {
            int Lineno = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.WriteLine($"{Lineno++}: {show.ToString()}");
                }
            }
        }



        public void PrintShows(string actor)
        {
            int Linenumber = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{Linenumber++}: {show.ToString()}");
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            int Linenumber = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.WriteLine($"{Linenumber++}: {show.ToString()}");
                }
            }
        }
        

	}
}

