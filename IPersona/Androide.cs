using System;

namespace ConsoleApplicationsTDPC12.IPersona
{
    public class Androide : IPersona
    {
        public void Cammina()
        {
            Console.WriteLine("L'androide cammina");
        }

        public void Saluta()
        {
            Console.WriteLine("L'androide saluta");
        }
    }
}