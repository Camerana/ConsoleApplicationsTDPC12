using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            a1.Modello = "Fiat 500";
            a1.Targa = "FK278AC";
            a1.NumeroPosti = 4;
            a1.Accendi();

            Auto a2 = new Auto();
            a2.Modello = "Fiat Punto";
            a2.Targa = "FK278AC";
            a2.NumeroPosti = 4;
            a2.Accendi();

            Console.WriteLine(a1.Modello);
            Console.WriteLine(a2.Modello);

            a1 = a2;

            a1.Modello = "Fiat Punto";
            Console.WriteLine(a1.Modello);
            Console.WriteLine(a2.Modello);
            a2.Modello = "Fiat 500";
            Console.WriteLine(a1.Modello);
            Console.WriteLine(a2.Modello);


            Auto a3 = new Auto();
            a3.Modello = "Fiat Punto";
            a3.Targa = "AB225TG";
            a3.NumeroPosti = 4;
            a3.Accendi();


            string stringa1 = "ciao";
            string stringa2 = "ciao";


            Console.ReadKey();
        }
    }
}
