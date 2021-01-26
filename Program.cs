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
         Collection:
            - un gruppo di più elementi
            - tipi tipici:
                - array (vettori)
                - liste
                - dictionary (map)
         */
        /*
         * Termine: 21.15
         Scrivere un programma che:
            - dato un array di 10 numeri interi
            - tramite una prima funzione calcoli e stampi su schermo il numero maggiore
            - tramite una seconda funzione calcoli stampi su schermo il numero minore
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 5, 61, 7, 8, 0, 40, 5, 47 };
            PrintMaxNumber(numbers);
            PrintMinNumber(numbers);
            Console.ReadKey();
        }
        static void PrintMaxNumber(int[] array)
        {
            Console.WriteLine(array.Max());
        }
        static void PrintMinNumber(int[] array)
        {
            Console.WriteLine(array.Min());
        }

        /*
         Scrivere un programma che:
            - Chieda all'utente 3 stringhe e le salvi 
            nelle prime tre posizioni di un array di dimensione 5
            - Nella posizione 3 inserisca il valore array[0] + array[1]
            - Nella posizione 4 inserisca il valore array[1] + array[2]
            - Stampi su schermo le 5 stringhe tramite un ciclo
         */
        /*
        static void Main(string[] args)
        {
            string[] strings = new string[5];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Inserisci una stringa");
                strings[i] = Console.ReadLine();
            }
            strings[3] = strings[0] + strings[1];
            strings[4] = strings[1] + strings[2];
            for (int i = 0; i < strings.Length; i++)
                Console.WriteLine(strings[i]);

            Console.ReadKey();
        }
        */
        /*
         Scrivere un programma che:
            - chieda all'utente 5 numeri interi
            - popoli coi 5 numeri un array di interi
            - stampi su schermo i 5 numeri tramite un ciclo
         */
        /*
        static void Main(string[] args)
        {
            int[] numeri = new int[5];
            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numeri[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine(numeri[i]);
            }
        }
        */
    }
}