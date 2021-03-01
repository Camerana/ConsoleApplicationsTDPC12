using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Moto : Veicolo
    {
        public int LunghezzaCavalletto { get; set; }
        public override void Stampa()
        {
            Console.WriteLine("Cilindrata: " + this.Cilindrata + ", Cavalletto: " + this.LunghezzaCavalletto);
        }
    }
}
