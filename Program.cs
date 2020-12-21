using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
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
    }
}