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
         * Termine: 21.05
         Scrivere un programma che:
            - Crei una lista di stringhe con dentro i valori:
                - Ciccio
                - Caio
                - Tizio
                - Franco
            - Chieda all'utente un indice
            - Stampi su schermo, se esiste, l'elemento corrispondente all'indice indicato
         */
        static void Main(string[] args)
        {
            //così..
            List<string> nomi = new List<string>()
            {
                "Ciccio", "Caio", "Tizio", "Franco"
            };
            //oppure..
            /*
            List<string> nomi = new List<string>();
            nomi.Add("Ciccio");
            nomi.Add("Caio");
            nomi.Add("Tizio");
            nomi.Add("Franco");
            */

            int index = -1;
            while (index < 0 || index > nomi.Count - 1)
            {
                try
                {
                    Console.WriteLine("Inserisci l'indice");
                    index = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sono ammessi solo numeri");
                }
            }
            Console.WriteLine(nomi[index]);
        }
        /*
         Scrivere un programma che:
            - Chieda all'utente la capacità di un array di interi
            - Crei un array della dimensione scelta dall'utente
            - Popoli completamente l'array di numeri casuali
            - Crei una lista di interi
            - Copii il contenuto dell'array nella lista
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la dimensione dell'array");
            int dimensioneArray = int.Parse(Console.ReadLine());

            int[] array = new int[dimensioneArray];

            Random r = new Random();
            for (int i = 0; i < dimensioneArray; i++)
                array[i] = r.Next(0, 10);

            List<int> lista = new List<int>();
            for (int i = 0; i < array.Length; i++)
                lista.Add(array[i]);

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            Console.ReadKey();
        }
        */
        /*
        static void SommaArray()
        {
            Console.WriteLine("Dimmi la dimensione dell'array:");
            int array_dim = Int32.Parse(Console.ReadLine());

            int[] array = new int[array_dim];

            Random r = new Random();
            for (int i = 0; i < array_dim; i++)
            {
                array[i] = r.Next(0, 10);
            }
            // aggiungo a mano altri elementi
            int more_items = 10;
            int[] array2 = new int[array_dim + more_items];

            for (int i = 0; i < array.Length; i++)
                array2[i] = array[i];

            for (int i = array.Length; i < array2.Length; i++)
            {
                int start_more = r.Next(30, 60);
                array2[i] = start_more;
            }

            List<int> lista = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                lista.Add(array2[i]);
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        */
        /*
         vantaggi delle liste:
            - dimensione variabile a runtime
            - ha funzionalità out of the box aggiuntive
         */
        /*
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();
            numeri.Add(10);
            List<int> numeri2 = GenerateNumbers();
            Console.ReadKey();
        }
        static List<int> GenerateNumbers()
        {
            List<int> toSender = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
                toSender.Add(r.Next(0, 10));
            return toSender;
        }
        */
        //lasciate ogni speranza o voi che entrate
        /*
        static void PrintList<T, I, K>(List<T> lista, List<I> lista2, List<K> lista3)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        */
    }
}
