using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationsTDPC12.Libreria
{
    public class Libreria
    {
        private List<Libro> Catalogo = new List<Libro>() {
            new Libro("Pirandello, L.","Il fu Mattia Pascal"),
            new Libro("Eco, U.","Il nome della rosa"),
            new Libro("Alighieri, D.","Divina Commedia"),
            new Libro("Manzoni, A.","I Promessi sposi"),
            new Libro("Nietzsche, F.", "Così parlò Zarathustra"),
        };
        private void PrintLibri(List<Libro> listToPrint)
        {
            for (int i = 0; i < listToPrint.Count; i++)
            {
                Libro current = listToPrint[i];
                Console.WriteLine(current.Autore + ": " + current.Titolo);
            }
        }
        public void PrintLibriByAutore()
        {
            List<Libro> orderedList = this.Catalogo.OrderBy(l => l.Autore).ToList();
            PrintLibri(orderedList);
        }
        public void PrintLibriByTitolo()
        {
            List<Libro> orderedList = this.Catalogo.OrderBy(l => l.Titolo).ToList();
            PrintLibri(orderedList);
        }
        public void SearchLibri(string input)
        {
            List<Libro> orderedList = this.Catalogo
                .Where(l => l.Autore.ToUpperInvariant().Contains(input.ToUpperInvariant())
                || l.Titolo.ToUpperInvariant().Contains(input.ToUpperInvariant())).ToList();
            PrintLibri(orderedList);
        }
    }
}