using System;

namespace ConsoleApplicationsTDPC12.Animali
{
    public class Cane : Animale
    {
        public string TipoPelo { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("TipoPelo: " + this.TipoPelo);
        }
    }
}