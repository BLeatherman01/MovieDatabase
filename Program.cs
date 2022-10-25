using MovieDatabase.Models;

namespace MovieDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieContext db = new MovieContext();
            List<Movie> m = db.Movies.ToList();
            MovieList ml  = new MovieList();

           
           
            bool askAgain = true;
            while(askAgain)
            {
                ml.PrintMoviesByTitle(m);
                Console.WriteLine("Would you like to search by Title or Genre?");
                string input = Console.ReadLine().ToLower();  
                if(input == "title")
                {
                    ml.SearchByTitle();
                }
                else if(input == "genre")
                {
                    ml.SearchByGenre();
                }

                askAgain = GoAgain();
            }
        }
        public static bool GoAgain()
        {
            Console.WriteLine("\nDo you want to find another movie? Please enter Yes or No");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "yes" || userInput == "y")
            {

                return true;
            }
            else if (userInput == "no" || userInput == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Yes or No");
                return GoAgain();
            }
        }
    }
}