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
            Auto a = new Auto();
            a.Modello = "Fiat 500";

            Console.WriteLine(a.Modello);

            

            Console.ReadKey();
        }
    }
}