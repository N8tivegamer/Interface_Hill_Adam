using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Hill_Adam
{
    class Game : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam; 
            Title = titleParam;
        }

        public void PLaygame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
