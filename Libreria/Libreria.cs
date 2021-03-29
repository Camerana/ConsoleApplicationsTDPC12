using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Libreria
{
    public class Libreria
    {
        private List<Libro> Catalogo = new List<Libro>() {
            new Libro("Alighieri, D.","Divina Commedia"),
            new Libro("Eco, U.","Il nome della rosa"),
            new Libro("Manzoni, A.","I Promessi sposi"),
            new Libro("Nietzsche, F.", "Così parlò Zarathustra"),
            new Libro("Pirandello, L.","Il fu Mattia Pascal")
        };

        public void PrintLibri()
        {
            for (int i = 0; i < this.Catalogo.Count; i++)
            {
                Libro current = this.Catalogo[i];
                Console.WriteLine(current.Autore + ": " + current.Titolo);
            }
        }
    }
}
