using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public class Cliente
    {
        public decimal Soldi { get; set; }
        public Cliente()
        {
            Random r = new Random();
            this.Soldi = r.Next(10, 16);
        }
    }
}
