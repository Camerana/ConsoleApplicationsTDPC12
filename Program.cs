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
         * Utilità di una funzione:
         *  - non ripetere il codice
         *  - riutilizzare il codice
         *  - fare in modo che le funzionalità siano separate tra di loro         
         */
        static void Main(string[] args)
        {
            string input = GetInput();
            WriteOutput(input);

            input = GetInput();
            WriteOutput(input);
        }

        static string GetInput()
        {
            Console.WriteLine("Inserisci una stringa");
            string input = Console.ReadLine();
            return input;
        }

        static void WriteOutput(string input)
        {
            Console.WriteLine("Hai scritto: " + input);
            string filteredInput = input.Replace("casa", "domicilio");
            Console.WriteLine(filteredInput);
        }


        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa");
            string input = Console.ReadLine();
            Console.WriteLine("Hai scritto: " + input);
            string filteredInput = input.Replace("casa", "domicilio");
            Console.WriteLine(filteredInput);


            Console.WriteLine("Inserisci una stringa");
            input = Console.ReadLine();
            Console.WriteLine("Hai scritto: " + input);
            filteredInput = input.Replace("casa", "domicilio");
            Console.WriteLine(filteredInput);
        }
        */
    }
}