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
            - Dati 4 numeri interi (non chiesti all'utente):
                - Stampi su schermo la media dei 4 numeri (decimal)
                - Stampi su schermo il maggiore tra il primo e il quarto numero
            - Chieda all'utente una stringa qualsiasi e:
                - Stampi su schermo la somma tra la lunghezza della stringa e il primo numero
         */
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 3;
            int num3 = 7;
            int num4 = 4;

            decimal media = Convert.ToDecimal(num1 + num2 + num3 + num4) / 4;
            Console.WriteLine(media);

            if (num1 > num4)
                Console.WriteLine(num1);
            else if (num4 > num1)
                Console.WriteLine(num4);

            Console.WriteLine("Inserisci una stringa qualsiasi");
            string input = Console.ReadLine();
            Console.WriteLine(input.Length + num1);

            Console.ReadKey();
        }
        /*
         Scrivere un programma che:
            - Chieda all'utente due numeri (solo interi)
            - Stampi su schermo la somma tra i due numeri
            - Stampi su schermo la data corrente (formato indifferente)
            - Stampi su schermo la data ottenuta tramite la somma 
            tra i giorni della data corrente e il primo numero
                es: - 10/05/1988 + 5 = 15/05/1988
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Somma: " + (numero1 + numero2));

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Data corrente: " + currentDate);

            Console.WriteLine("Data corrente + " + numero1 + " giorni: " + currentDate.AddDays(numero1));
        }
        */
    }
}
