using System;

namespace ConsoleApplicationsTDPC12.Mobili
{
    public class Armadio : Mobile
    {
        public double Capienza { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Capienza: " + this.Capienza);
        }
    }
}
