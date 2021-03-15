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
         creazione di un array di 9 numeri da 1 a 9 disposti in modo casuale
         e senza ripetizioni
         */
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
    }
}
