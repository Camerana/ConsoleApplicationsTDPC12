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
            Proprietà e metodi più frequenti: 
                Length        
                IndexOf()
                LastIndexOf()
                Substring()
                Contains()
                Equals()
                First() (Linq)
                Last() (Linq)
                ToLowerInvariant()
                ToUpperInvariant()
                Trim()
                Replace()
                Remove()
                Format()
         */
        /*
         * 
            Scrivere un programma che:
                - Generi un numero casuale tra 0 e 4
                - Chieda all'utente un secondo numero
                - Sommi i due numeri
                - Chieda all'utente una stringa
                - Stampi sullo schermo i caratteri della stringa a partire dall'indice 0
                fino a un totale di caratteri pari alla somma
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            Console.WriteLine("Inserisci un numero");
            int numberFromUser = int.Parse(Console.ReadLine());

            int total = randomNumber + numberFromUser;

            Console.WriteLine("Inserisci una stringa");
            string stringFromUser = Console.ReadLine();

            string result = stringFromUser.Substring(0, total);

            Console.WriteLine(result);
        }
        /*
            Scrivere un programma che:
                - Chieda all'utente due stringhe
                - Verifichi se le due stringhe hanno la stessa lunghezza
                - Comunichi l'esito all'utente
                - Componga una frase qualsiasi con le due stringhe
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la prima stringa");
            string stringa1 = Console.ReadLine();

            Console.WriteLine("Inserisci la seconda stringa");
            string stringa2 = Console.ReadLine();

            if (stringa1.Length == stringa2.Length)
                Console.WriteLine("Le stringhe hanno la stessa lunghezza");
            else
                Console.WriteLine("Le stringhe non hanno la stessa lunghezza");

            Console.WriteLine(stringa1 + stringa2);

            if (stringa1.Contains(stringa2))
                Console.WriteLine("La stringa " + stringa1 + " contiene la stringa " + stringa2);
            else if (stringa2.Contains(stringa1))
                Console.WriteLine("La stringa " + stringa2 + " contiene la stringa " + stringa1);

            Console.ReadKey();
        }
        */
    }
}
