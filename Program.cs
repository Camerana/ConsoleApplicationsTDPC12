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
            - Chieda all'utente due numeri
            - Calcoli tramite 2 funzioni somma e differenza fra i due numeri
            - Stampi su schermo la somma e la differenza
            - Chieda all'utente un terzo numero
            - Calcoli tramite una terza funzione la somma totale fra i tre numeri
            - Stampi su schermo la somma totale
         */

        static void Main(string[] args)
        {
        }


        /*
         Utilità di una funzione:
          - non ripetere il codice
          - riutilizzare il codice
          - fare in modo che le funzionalità siano separate tra di loro   
         */
        /*
         Proprietà di una funzione:
            - void o return
            - con o senza parametri in ingresso         
         */
        /*
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
        */

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