using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public interface ISaNuotare
    {
        void Nuota();
    }

    public class Animale : ISaNuotare
    {
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
    public class Papera : Animale
    {
        public Animale GetObject()
        {
            return new Papera();
        }
    }
    public class Pesce : Animale
    {
        public Animale GetObject()
        {
            return new Pesce();
        }
    }
    public static class ClassFactory
    {
        public static Animale GetPapera()
        {
            return new Papera();
        }
        public static Animale GetPesce()
        {
            return new Pesce();
        }
    }
}
