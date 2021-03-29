using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Libreria
{
    public class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public Libro(string autore, string titolo)
        {
            this.Autore = autore;
            this.Titolo = titolo;
        }
    }
}
