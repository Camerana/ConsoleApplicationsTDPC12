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
            Animale a1 = new Animale();
            a1.Nome = "Ciccio";
            a1.Razza = "Pesce rosso";

            Animale a2 = new Animale();
            a2.Nome = "Micio";
            a2.Razza = "Cane";

            Console.WriteLine(a1.Nome);
            Console.WriteLine(a1.Razza);

            Console.WriteLine(a2.Nome);
            Console.WriteLine(a2.Razza);

            a1.Muoviti();
            a2.Muoviti();

            Console.ReadKey();
        }
    }
}