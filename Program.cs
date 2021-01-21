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
         * Termine: 20.00
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
         * Termine: 20.30
         Scrivere un programma che:
            - Chieda all'utente un numero intero (anche negativo)
            - Data la data corrente, ci aggiunga tanti giorni quanto il numero dell'utente
            - Stampi su schermo la data ottenuta
         */
        static void Main(string[] args)
        {

        }

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
