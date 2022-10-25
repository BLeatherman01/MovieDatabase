using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace MovieDatabase
{
    public class MovieList
    {
    
      public MovieContext db { get; set; } = new MovieContext();

        public void SearchByTitle()
        {
            List<Movie> movieListByTitle = new List<Movie>();
            Console.WriteLine("What movie title would you like to select?");
            string movieSelection = Console.ReadLine();
            movieListByTitle = db.Movies.Where(m => m.Title.Contains(movieSelection)).ToList();
            foreach(Movie movie in movieListByTitle)
            {
                Console.WriteLine(movie.Title + " - " + movie.Genre + " - Runtime in minutes: " + movie.Runtime );
            }
          
        }

        public void SearchByGenre()
        {
            List<Movie> movieListByGenre = new List<Movie>();
            Console.WriteLine("What movie genre would you like to select?");
            string movieSelection = Console.ReadLine();
            movieListByGenre = db.Movies.Where(m => m.Genre.Contains(movieSelection)).ToList();
            foreach (Movie movie in movieListByGenre)
            {
                Console.WriteLine(movie.Title + " - " + movie.Genre + " - Runtime in minutes: " + movie.Runtime);
            }
        }

        public void PrintMoviesByTitle(List<Movie> movies)
        {
            Console.WriteLine("Print Movie titles:");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Id + " " + movie.Title + " - " + movie.Genre);
            }
        }


    }
}
