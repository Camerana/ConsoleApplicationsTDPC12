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
         Esercitazione:
            - Realizzare un clone del Tris in console:
            |___|_O_|_X_|        
            |___|_X_|_O_|
            |_X_|___|_O_|
            - Spunti in ordine di difficoltà:
                - possibilità di tenere conto del punteggio di più partite        
                - possibilità di multigiocatore sullo stesso terminale        
                - possibilità di sfidare il computer                
                - possibilità di multigiocatore su terminali diversi in rete
         */
        /*
         TODO:
            - implementare la condizione di vittoria quando un giocatore fa tris
            - risolvere il bug per cui il computer va in loop se non ci sono caselle libere
         */
        static void Main(string[] args)
        {
            string[,] coordinate = new string[3, 3];
            Render(coordinate);
            Random r = new Random();
            while (true)
            {
                bool sceltaValida = false;
                while (!sceltaValida)
                {
                    Console.WriteLine("Inserisci le coordinate");
                    string scelta = Console.ReadLine();
                    int x = int.Parse(scelta[0].ToString());
                    int y = int.Parse(scelta[1].ToString());
                    if (coordinate[y, x] == null)
                    {
                        coordinate[y, x] = "X";
                        sceltaValida = true;
                    }
                    Render(coordinate);
                }
                sceltaValida = false;
                while (!sceltaValida)
                {
                    int x = r.Next(0, 3);
                    int y = r.Next(0, 3);
                    if (coordinate[x, y] == null)
                    {
                        coordinate[x, y] = "O";
                        sceltaValida = true;
                    }
                    Render(coordinate);
                }
            }
        }
        private static void Render(string[,] coordinate)
        {
            Console.Clear();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    string format = "|_P_|";
                    if (coordinate[x, y] == null)
                        format = format.Replace("P", "_");
                    else
                        format = format.Replace("P", coordinate[x, y]);
                    Console.Write(format);
                }
                Console.WriteLine();
            }
        }

        /*
         creazione di un array di 9 numeri da 1 a 9 disposti in modo casuale
         e senza ripetizioni
         */
        /*
        static void Main(string[] args)
        {
            int[] numeri = new int[9];
            Random r = new Random();

            for (int i = 0; i < numeri.Length; i++)
            {
                int numero = r.Next(1, 10);
                while (numeri.Contains(numero))
                {
                    numero = r.Next(1, 10);
                }
                numeri[i] = numero;
            }
            Console.ReadKey();
        }
        */
    }
}
