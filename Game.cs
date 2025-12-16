using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Hill_Adam
{
    /// <summary>
    /// Represents a general game and implements the IGenre interface.
    /// </summary>
    class Game : IGenre
    {
        /// <summary>
        /// Gets or sets the ESRB rating of the game.
        /// </summary>
        public string Esrb { get; set; }
        /// <summary>
        /// Gets or sets the genre of the game (e.g., FPS, RPG).
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Gets or sets the title of the game.
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// Constructor for Game. Initializes the title, genre, and ESRB rating.
        /// </summary>
        /// <param name="esrbParam">The ESRB rating of the game.</param>
        /// <param name="genreParam">The genre of the game.</param>
        /// <param name="titleParam">The title of the game.</param>
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam; 
            Title = titleParam;
        }

        /// <summary>
        /// Provides a description of the game including its title, genre, and rating.
        /// </summary>
        /// <returns>A formatted string describing the game.</returns>
        public void PLaygame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        /// <summary>
        /// Provides a description of the game including its title, genre, and rating.
        /// </summary>
        /// <returns>A formatted string describing the game.</returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
