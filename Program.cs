using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         
         
         */
        static void Main(string[] args)
        {
            Moto m = new Moto();
            m.LunghezzaCavalletto = 10;
            m.Cilindrata = 1500;



            Auto a = new Auto();
            a.DiametroVolante = 30;
            a.Cilindrata = 2000;

        }
    }
}
