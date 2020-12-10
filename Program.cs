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
            - Dia il benvenuto all'utente
            - Chieda all'utente un numero
            - Stampi sullo schermo il risultato di "numero + 1"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto utente");
            string stringa = Console.ReadLine();
            int numero = int.Parse(stringa);
            Console.WriteLine(numero + 1);
        }
    }
}
