using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public class Snack : Prodotto
    {
        public decimal Peso { get; set; }
        public override void PrintProdotto()
        {
            base.PrintProdotto();
            Console.WriteLine("Peso: " + this.Peso);
        }
    }
}
