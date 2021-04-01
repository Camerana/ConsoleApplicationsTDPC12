using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationsTDPC12
{
    public static class Utilities
    {
        public static void Print(List<string> stringhe)
        {
            List<string> stringheOrdinate = stringhe.OrderBy(s => s).ToList();
            foreach (string stringa in stringheOrdinate)
                Console.WriteLine(stringa);
        }
    }
}