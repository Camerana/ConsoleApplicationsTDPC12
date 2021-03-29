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
         * Aggiornamento: 20.40
         Scrivere un programma che:
            - simuli il catalogo di una libreria -> OK
            - abbia un numero N di libri in memoria -> OK
            - all'avvio del programma stampi i libri su schermo -> OK
            - permettere all'utente di stampare i libri 
            in ordine alfabetico di autore o titolo <- DA FARE ADESSO
            - permettere all'utente la ricerca tramite testo libero
            sia su autore che titolo <- PER DOPO
         */
        static void Main(string[] args)
        {
            Libreria.Libreria libreria = new Libreria.Libreria();
            libreria.PrintLibri();

            Console.ReadKey();
        }
    }
}
