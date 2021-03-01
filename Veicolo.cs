using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Veicolo
    {
        public int Cilindrata { get; set; }
        public virtual void Stampa()
        {
            Console.WriteLine("Cilindrata: " + this.Cilindrata);
        }
    }
}
