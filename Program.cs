using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        static void Main(string[] args)
        {
            ISaNuotare papera = ClassFactory.GetPapera();
            ISaNuotare pesce = ClassFactory.GetPesce();

            papera.Nuota();
            pesce.Nuota();
        }
    }
}