using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Hill_Adam
{
    internal interface IGenre
    {

        public string Esrb { get; set; }

        public string Genre { get; set; }
        
        public string Title { get; set; }

        public string Describe();
    }
}
