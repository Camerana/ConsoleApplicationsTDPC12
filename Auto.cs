using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Auto
    {
        public string Modello { get; set; }
        public string Targa { get; set; }
        public int NumeroPosti { get; set; }

        public void Accendi()
        {
            Console.WriteLine("Il motore è acceso");
        }
    }
}
