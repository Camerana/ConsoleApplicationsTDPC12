using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         Foreach:
            - cicla su tutti gli elementi di una collection
            - grammaticalmente più semplice del ciclo for
         */
        /*
         Scrivere un programma che:
            - Chieda all'utente 2 stringhe
            - Crei un array per contenere le 2 stringhe dell'utente
            - Chieda all'utente 2 numeri interi
            - Crei una lista per contenere i due numeri dell'utente
            - Tramite un ciclo for stampi su schermo le due stringhe
            - Tramite un ciclo foreach stampi su schermo i due numeri
         */
        static void Main(string[] args)
        {
            string[] stringhe = new string[2];
            Console.WriteLine("Inserisci la prima stringa");
            stringhe[0] = Console.ReadLine();

            Console.WriteLine("Inserisci la seconda stringa");
            stringhe[1] = Console.ReadLine();

            List<int> numeri = new List<int>();
            Console.WriteLine("Inserisci il primo numero");
            numeri.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Inserisci il secondo numero");
            numeri.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < stringhe.Length; i++)
                Console.WriteLine(stringhe[i]);

            foreach (int numero in numeri)
                Console.WriteLine(numero);

            Console.ReadKey();
        }
    }
}