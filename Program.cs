using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        //termine: 19:30
        /*
         Scrivere un programma che:
            - Chieda all'utente due numeri (solo interi)
            - Stampi su schermo la somma tra i due numeri
            - Stampi su schermo la data corrente (formato indifferente)
            - Stampi su schermo la data ottenuta tramite la somma 
            tra i giorni della data corrente e il primo numero
                es: - 10/05/1988 + 5 = 15/05/1988
         */
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
    }
}
