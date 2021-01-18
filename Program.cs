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
            - Chieda all'utente due numeri interi
            - Calcoli tramite 2 funzioni somma e differenza fra i due numeri
            - Stampi su schermo la somma e la differenza
            - Chieda all'utente un terzo numero intero
            - Calcoli tramite una terza funzione la somma totale fra i tre numeri
            - Stampi su schermo la somma totale
         */
        static void Main(string[] args)
        {
            int numero1 = GetNumber("primo");
            int numero2 = GetNumber("secondo");
            int somma = Somma(numero1, numero2);
            Console.WriteLine("Somma = " + somma);
            int differenza = Differenza(numero1, numero2);
            Console.WriteLine("Differenza = " + differenza);
            int numero3 = GetNumber("terzo");
            int totale = Totale(numero1, numero2, numero3);
            Console.WriteLine("Totale = " + totale);
            Console.ReadKey();
        }
        static int GetNumber(string ordinale)
        {
            Console.WriteLine("Inserisci il " + ordinale + " numero");
            return int.Parse(Console.ReadLine());
        }
        static int Somma(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Differenza(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Totale(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            int numero2 = int.Parse(Console.ReadLine());

            int somma = Somma(numero1, numero2);
            Console.WriteLine(somma);

            int differenza = Differenza(numero1, numero2);
            Console.WriteLine(differenza);

            Console.WriteLine("Inserisci il terzo numero");
            int numero3 = int.Parse(Console.ReadLine());

            int totale = Totale(numero1, numero2, numero3);
            Console.WriteLine(totale);
        }
        
        static int Somma(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Differenza(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Totale(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        */
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