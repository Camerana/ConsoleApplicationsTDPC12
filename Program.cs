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
         Scrivere un programma che:
            - Chieda all'utente 2 stringhe
            - Nel caso le due stringhe siano uguali tra di loro come contenuto:
                - Stampi su schermo "Le stringhe sono uguali"
            - Nel caso la prima stringa sia più lunga della seconda:
                - Stampi su schermo "La prima stringa è più lunga della seconda"
            - Nel caso la seconda stringa sia più lunga della prima:
                - Chieda all'utente una terza stringa
                - Nel caso la terza stringa sia uguale alla prima come contenuto:
                    - Stampi su schermo "Easter egg"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la prima stringa");
            string firstString = Console.ReadLine();

            Console.WriteLine("Inserisci la seconda stringa");
            string secondString = Console.ReadLine();

            if (firstString == secondString)
                Console.WriteLine("Le stringhe sono uguali");
            if (firstString.Length > secondString.Length)
                Console.WriteLine("La prima stringa è più lunga della seconda");
            else if (secondString.Length > firstString.Length)
            {
                Console.WriteLine("Inserisci la terza stringa");
                string thirdString = Console.ReadLine();

                if (thirdString == firstString)
                    Console.WriteLine("Easter egg");
            }
        }

        /*
        static void Main(string[] args)
        {
            string validUsername = "Admin";
            string validPassword = "123";

            Console.WriteLine("Inserisci lo username");
            string username = Console.ReadLine();

            Console.WriteLine("Inserisci la password");
            string password = Console.ReadLine();

            if (username == validUsername && password == validPassword)
            {
                Console.WriteLine("Benvenuto Admin");
            }
            else
            {
                Console.WriteLine("Errore");
            }
            Console.ReadKey();
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa qualsiasi");
            string input = Console.ReadLine();

            if (input.StartsWith("A"))
            {
                Console.WriteLine("Inserisci un'altra stringa qualsiasi");
                input = Console.ReadLine();
                if (input.Length == 10)
                {
                    Console.WriteLine(10);
                }
            }
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola");
            string input = Console.ReadLine();
            //if - else if - else / condizioni che si escludono a vicenda
            if (input.StartsWith("A")) //se..
            {
                Console.WriteLine("La parola inizia con la A maiuscola");
            }
            else if (input.StartsWith("B")) //altrimenti se..
            {
                Console.WriteLine("La parola inizia con la B maiuscola");
            }
            else if (input.StartsWith("C")) //altrimenti se..
            {
                Console.WriteLine("La parola inizia con la C maiuscola");
            }
            else //altrimenti..
            {
                Console.WriteLine("La parola non inizia né con la A maiuscola, né con la B maiuscola");
            }

            //if - if / condizioni che non si escludono a vicenda
            if (input.StartsWith("A"))
            {
                Console.WriteLine("La parola inizia con la A maiuscola");
            }

            if (input.EndsWith("o"))
            {
                Console.WriteLine("La parola finisce con la o minuscola");
            }

            //if concatenati - AND
            if (input.StartsWith("C") && input.EndsWith("o"))
            {
                Console.WriteLine("La parola comincia con C maiucola e termina con o minuscola");
            }

            //in concatenati - OR
            if (input.StartsWith("D") || input.EndsWith("i"))
            {
                Console.WriteLine("La parola comincia con D maiuscola o termina con i minuscola");
            }

            Console.ReadKey();
        }
        */
    }
}