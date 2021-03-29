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
         * Aggiornamento: 21.15
         Scrivere un programma che:
            - simuli il catalogo di una libreria -> OK
            - abbia un numero N di libri in memoria -> OK
            - all'avvio del programma stampi i libri su schermo -> OK
            - permettere all'utente di stampare i libri 
            in ordine alfabetico di autore o titolo <- OK
            - permettere all'utente la ricerca tramite testo libero
            sia su autore che titolo <- DA FARE ADESSO (this.Catalogo.Where(l => l.Titolo....).ToList();)
         */
        static void Main(string[] args)
        {
            Libreria.Libreria libreria = new Libreria.Libreria();

            Console.WriteLine("Premi 1 per ordinare i libri per autore");
            Console.WriteLine("Premi 2 per ordinare i libri per titolo");
            string scelta = Console.ReadLine();
            if (scelta == "1")
            {
                libreria.PrintLibriByAutore();
            }
            else if (scelta == "2")
            {
                libreria.PrintLibriByTitolo();
            }


            Console.ReadKey();
        }
    }
}
