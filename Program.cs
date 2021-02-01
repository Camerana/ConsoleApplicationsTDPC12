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
            - Dato un numero generato a caso tra 1 e 10, creare un array di tale dimensione
            e riempirlo di altrettanti numeri casuali
            - Tramite un ciclo, copiare tutti i numeri dell'array in una lista di numeri
            - Chiede all'utente un indice
            - Stampare su schermo il numero, nella lista, corrispondente all'indice dell'utente
        */
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero = r.Next(1, 11);

            int[] numsArray = new int[numero];
            for (int i = 0; i < numero; i++)
                numsArray[i] = r.Next();

            List<int> numsList = new List<int>();

            for (int i = 0; i < numsArray.Length; i++)
                numsList.Add(numsArray[i]);

            Console.WriteLine("Inserisci un indice");
            int index = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(numsList[index]);
            }
            catch
            {
                Console.WriteLine("L'indice eccede la dimensione della collection");
            }
            Console.ReadKey();
        }
        /*
         Scrivere un programma che:
            - Chieda all'utente 2 stringhe
            - Crei un array per contenere le 2 stringhe dell'utente
            - Chieda all'utente 2 numeri interi
            - Crei una lista per contenere i due numeri dell'utente
            - Tramite un ciclo for stampi su schermo le due stringhe
            - Tramite un ciclo foreach stampi su schermo i due numeri
         */
        /*
        static void Main(string[] args)
        {
            string[] stringhe = new string[2];
            stringhe[0] = ReadStrings(1);
            stringhe[1] = ReadStrings(2);

            List<int> numeri = new List<int>();
            numeri.Add(ReadNumbers(1));
            numeri.Add(ReadNumbers(2));

            for (int i = 0; i < stringhe.Length; i++)
                Console.WriteLine(stringhe[i]);

            foreach (int numero in numeri)
                Console.WriteLine(numero);

            Console.ReadKey();
        }
        static string ReadStrings(int ordinale)
        {
            Console.WriteLine("Inserisci la stringa " + ordinale);
            return Console.ReadLine();
        }
        static int ReadNumbers(int ordinale)
        {
            Console.WriteLine("Inserisci il numero " + ordinale);
            return int.Parse(Console.ReadLine());
        }
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
        /*
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
         */
    }
}