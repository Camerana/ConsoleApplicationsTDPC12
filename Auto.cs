using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Auto : Veicolo
    {
        public int DiametroVolante { get; set; }
        public override void Stampa()
        {
            Console.WriteLine("Cilindrata: " + this.Cilindrata + ", Volante: " + this.DiametroVolante);
        }
    }
}
