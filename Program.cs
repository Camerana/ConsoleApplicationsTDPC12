using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Program
    {
        /*
                Creare una classe Animale con:
                    - una property Nome
                    - una property Razza
                    - una funzione Muoviti
                Creare 2 oggetti di tipo Animale
                Attribuire tutti i valori ai due oggetti
                Stampare su schermo le properties dei due oggetti
                Chiamare la funzione Muoviti di entrambi gli oggetti

         */


        static void Main(string[] args)
        {
            Auto a = new Auto();
            a.Modello = "Fiat 500";

            Console.WriteLine(a.Modello);


            Console.ReadKey();
        }
    }
}