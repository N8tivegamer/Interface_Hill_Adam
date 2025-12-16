using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Hill_Adam
{
    /// <summary>
    /// Interface representing a game genre. 
    /// Any class implementing this interface must define these properties and methods.
    /// </summary>
    internal interface IGenre
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
        /// Provides a description of the game.
        /// Must be implemented by any class that implements this interface.
        /// </summary>
        /// <returns>A string describing the game.</returns>
        public string Describe();
    }
}
