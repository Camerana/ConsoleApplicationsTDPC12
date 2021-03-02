using System;

namespace ConsoleApplicationsTDPC12.Mobili
{
    public class Mobile
    {
        public string Materiale { get; set; }
        public virtual void Stampa()
        {
            Console.WriteLine("Materiale: " + this.Materiale);
        }
    }
}
