using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationsTDPC12.Libreria;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         * Aggiornamento: 19.30
         Scrivere un programma che:
            - simuli il catalogo di una libreria
            - abbia un numero N di libri in memoria
            - all'avvio del programma stampi i libri su schermo
         */
        static void Main(string[] args)
        {
            Libreria.Libreria libreria = new Libreria.Libreria();
            libreria.PrintLibri();

            Console.ReadKey();
        }
    }
}
