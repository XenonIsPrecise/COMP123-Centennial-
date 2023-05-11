using System;
namespace Lab_Theatre
{
	public class Show
	{
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Day} {Time} {Movie.Title} ({Movie.Year}) {Movie.Length}min  ({Movie.Genre}) {string.Join(", ", Movie.Cast)} ${Price}";
        }

        
	}
}

