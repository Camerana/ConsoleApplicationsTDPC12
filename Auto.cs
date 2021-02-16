using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Auto
    {
        private string modello;
        public string Modello
        {
            get
            {
                if (modello == "Fiat 500")
                    return this.modello;
                else
                    return "Non disponibile";
            }
            set
            {
                if (value != "Fiat 500")
                    this.modello = value;
            }
        }
        public string Targa { get; set; }
        public int NumeroPosti { get; set; }

        public void Accendi()
        {
            Console.WriteLine("Il motore è acceso");
        }
    }
}