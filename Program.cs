using System;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         Scrivere un programma che:
            - simuli il catalogo di una libreria
            - abbia un numero N di libri in memoria
            - all'avvio del programma stampi i libri su schermo
            - permettere all'utente di stampare i libri 
            in ordine alfabetico di autore o titolo
            - permettere all'utente la ricerca tramite testo libero
            sia su autore che titolo
         */
        static void Main(string[] args)
        {
            Libreria.Libreria libreria = new Libreria.Libreria();

            Console.WriteLine("Premi 1 per ordinare i libri per autore");
            Console.WriteLine("Premi 2 per ordinare i libri per titolo");
            Console.WriteLine("Premi 3 per la ricerca libera");
            string scelta = Console.ReadLine();
            if (scelta == "1")
            {
                libreria.PrintLibriByAutore();
            }
            else if (scelta == "2")
            {
                libreria.PrintLibriByTitolo();
            }
            else if (scelta == "3")
            {
                Console.WriteLine("Cosa vuoi cercare ?");
                scelta = Console.ReadLine();
                libreria.SearchLibri(scelta);
            }
            Console.ReadKey();
        }
    }
}