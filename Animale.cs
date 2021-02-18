using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Animale
    {
        public string Nome { get; set; }
        public string Razza { get; set; }

        public Animale(string nome, string razza)
        {
            this.Nome = nome;
            this.Razza = razza;
        }

        public void Muoviti()
        {
            Console.WriteLine(this.Nome + " si sta muovendo");
        }
    }
}