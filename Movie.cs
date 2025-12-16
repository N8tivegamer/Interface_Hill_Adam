using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Hill_Adam
{
    /// <summary>
    /// Represents a Movie and implements the IGenre interface.
    /// </summary>
    class Movie : IGenre
    {
        /// <summary>
        /// Gets or sets the ESRB rating of the movie.
        /// </summary
        public string Esrb { get ; set ; }

        /// <summary>
        /// Gets or sets the genre of the movie.
        /// </summary>
        public string Genre { get ; set ; }

        /// <summary>
        /// Gets or sets the title of the movie.
        /// </summary>
        public string Title { get ; set ; }

        /// <summary>
        /// Constructor for Movie. Initializes the title, genre, and ESRB rating.
        /// </summary>
        /// <param name="esrbParam">The ESRB rating of the movie.</param>
        /// <param name="genreParam">The genre of the movie.</param>
        /// <param name="titleParam">The title of the movie.</param>
        public Movie(string esrbParam, string genreParam, string titleParam) 
        {
            Esrb = esrbParam;
            Genre = genreParam; 
            Title = titleParam;
        }

        /// <summary>
        /// Prints a message indicating the movie is starting.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting SSsssshhhhhhh!");
        }

        /// <summary>
        /// Provides a description of the movie including its title, genre, and rating.
        /// </summary>
        /// <returns>A formatted string describing the movie.</returns>
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
    }
}
