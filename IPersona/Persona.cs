using System;

namespace ConsoleApplicationsTDPC12.IPersona
{
    public class Persona : IPersona
    {
        public void Cammina()
        {
            Console.WriteLine("La persona cammina");
        }

        public void Saluta()
        {
            Console.WriteLine("La persona saluta");
        }
    }
}