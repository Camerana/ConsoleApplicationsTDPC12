using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public class Prodotto
    {
        public string Tipo { get; set; }
        public decimal Costo { get; set; }
        public virtual void PrintProdotto()
        {
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("Costo: " + this.Costo);
        }
    }
}
