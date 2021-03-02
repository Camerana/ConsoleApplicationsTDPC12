using System;

namespace ConsoleApplicationsTDPC12.Animali
{
    public class Ragno : Animale
    {
        public bool IsVelenoso { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("IsVelenoso: " + this.IsVelenoso);
        }
    }
}