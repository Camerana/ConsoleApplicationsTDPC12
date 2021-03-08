using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public class Bevanda : Prodotto
    {
        public decimal Volume { get; set; }
        public override void PrintProdotto()
        {
            base.PrintProdotto();
            Console.WriteLine("Volume: " + this.Volume);
        }
    }
}
