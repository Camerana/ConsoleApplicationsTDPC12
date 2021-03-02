using System;

namespace ConsoleApplicationsTDPC12.Visibilita
{
    public class ClasseMadre
    {
        protected string Nome { get; set; }
        public void Funzione()
        {
            Console.WriteLine(this.Nome);
        }
    }
}
