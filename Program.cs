using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         Scrivere un programma che:
            - emuli una calcolatrice con le quattro operazioni fondamentali
            - continui a funzionare finché l'utente non sceglierà l'opzione
            apposita per chiudere il programma
         */
        static void Main(string[] args)
        {
            string scelta = "";
            while (scelta.ToUpperInvariant() != "Q")
            {
                Console.WriteLine("Inserisci il primo numero");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                int numero2 = int.Parse(Console.ReadLine());

                string operazione = "";
                while (operazione != "1"
                    && operazione != "2"
                    && operazione != "3"
                    && operazione != "4"
                    )
                {
                    Console.WriteLine("Scegli un'operazione");
                    Console.WriteLine("1 = Addizione");
                    Console.WriteLine("2 = Sottrazione");
                    Console.WriteLine("3 = Moltiplicazione");
                    Console.WriteLine("4 = Divisione");
                    operazione = Console.ReadLine();
                }

                double risultato = 0;
                if (operazione == "1")
                {
                    risultato = numero1 + numero2;
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + risultato);
                }
                else if (operazione == "2")
                {
                    risultato = numero1 - numero2;
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + risultato);
                }
                else if (operazione == "3")
                {
                    risultato = numero1 * numero2;
                    Console.WriteLine(numero1 + " x " + numero2 + " = " + risultato);
                }
                else if (operazione == "4")
                {
                    risultato = (double)numero1 / (double)numero2;
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + risultato);
                }
                Console.WriteLine("Per uscire scrivi Q, altrimenti premi un altro tasto");
                scelta = Console.ReadLine();
            }
        }
        /*
         Scrivere un programma che:
            - Chieda all'utente un numero tra 1 e 10
            - Generare un numero casuale tra 1 e 10
            - Verifichi se il numero scelto dall'utente è maggiore del numero casuale
                - In caso positivo:
                    - Stampi su schermo "Hai vinto"
                - In caso negativo:
                    - Stampi su schermo "Hai perso"
         */
        /*
        static void Main(string[] args)
        {
            int numberFromUser = 0;
            while (numberFromUser < 1 || numberFromUser > 10)
            {
                Console.WriteLine("Inserisci un numero tra 1 e 10");
                numberFromUser = int.Parse(Console.ReadLine());
            }

            Random r = new Random();
            int randomNumber = r.Next(1, 11);

            if (numberFromUser > randomNumber)
                Console.WriteLine("Hai vinto");
            else
                Console.WriteLine("Hai perso");
        }
        */
        /*
         Scrivere un programma che:
            - Chieda all'utente un numero intero (anche negativo)
            - Data la data corrente, ci aggiunga tanti giorni quanto il numero dell'utente
            - Stampi su schermo la data ottenuta
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero");
            int numberFromUser = int.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.AddDays(numberFromUser);
            Console.WriteLine(dateTime);
            Console.ReadKey();
        }
        */
        /*
         Scrivere un programma che:
            - Chieda un numero all'utente compreso tra 3 e 10
            - Disegni un albero di natale alto tante righe quanto il numero dell'utente
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int treeHeight = int.Parse(Console.ReadLine());

            int emptySpaces = treeHeight - 1;
            int asterisks = 1;
            for (int i = 0; i < treeHeight; i++)
            {
                string treeChunk = "";
                for (int j = 0; j < emptySpaces; j++)
                {
                    treeChunk += " ";
                }
                for (int k = 0; k < asterisks; k++)
                {
                    treeChunk += "*";
                }
                emptySpaces--;
                asterisks = asterisks + 2;
                Console.WriteLine(treeChunk);
            }
            Console.ReadKey();
        }
        */
    }
}
