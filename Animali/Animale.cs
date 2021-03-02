using System;

namespace ConsoleApplicationsTDPC12.Animali
{
    public class Animale
    {
        public string Colore { get; set; }
        public virtual void Stampa()
        {
            Console.WriteLine("Colore: " + this.Colore);
        }
    }
}