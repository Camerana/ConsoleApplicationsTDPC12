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
         Foreach:
            - cicla su tutti gli elementi di una collection
            - grammaticalmente più semplice del ciclo for
         */
        static void Main(string[] args)
        {
            List<string> stringhe = new List<string>();
            stringhe.Add("Stringa 1");
            stringhe.Add("Stringa 2");
            stringhe.Add("Stringa 3");
            stringhe.Add("Stringa 4");
            stringhe.Add("Stringa 5");

            for (int i = 0; i < stringhe.Count; i++)
                Console.WriteLine(stringhe[i]);

            foreach (string stringa in stringhe)
                Console.WriteLine(stringa);

            Console.ReadKey();
        }
    }
}