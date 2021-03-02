using System;

namespace ConsoleApplicationsTDPC12.Mobili
{
    public class Sedia : Mobile
    {
        public bool Braccioli { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Braccioli: " + this.Braccioli);
        }
    }
}
