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
         Scrivere una programma che:
            - Dato il numero 5000, chiedere all'utente un numero
            - Iterare tramite un ciclo for da 5000 fino al numero scelto dall'utente e per ciascuna
            iterazione stampare su schermo il numero dell'iterazione corrente
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int num = int.Parse(Console.ReadLine());

            if (num > 5000)
                for (int i = 5000; i < num; i++)
                    Console.WriteLine(i);
            else
                for (int i = 5000; i > num; i--)
                    Console.WriteLine(i);
            Console.ReadKey();
        }

        /*
         Scrivere una programma che:
            - chieda all'utente 3 stringhe
            - tramite un ciclo stampi su schermo le lettere della prima stringa andando a capo ad ogni lettera
            - stampi su schermo la seconda stringa
            - chieda all'utente un numero
            - stampi su schermo la terza stringa dall'indice 0 fino al numero scelto dall'utente         
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa");
            string stringa1 = Console.ReadLine();

            Console.WriteLine("Inserisci una stringa");
            string stringa2 = Console.ReadLine();

            Console.WriteLine("Inserisci una stringa");
            string stringa3 = Console.ReadLine();

            for (int i = 0; i < stringa1.Length; i++)
                Console.WriteLine(stringa1[i]);

            Console.WriteLine(stringa2);

            Console.WriteLine("Inserisci un numero");
            int numero = int.Parse(Console.ReadLine());

            string substring = stringa3.Substring(0, numero);
            Console.WriteLine(substring);
        }
        */
        /*
         Scrivere un programma che:
            - Data una funzione per stampare una stringa passata come parametro in ingresso,
            chiami la suddetta funzione un numero n di volte scelto dall'utente
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < max; i++)
            {
                Print("Ciao");
            }
            Console.ReadKey();
        }
        static void Print(string stringa)
        {
            Console.WriteLine(stringa);
        }
        */
    }
}