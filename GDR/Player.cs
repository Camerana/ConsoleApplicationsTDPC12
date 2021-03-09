using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.GDR
{
    public class Player : Personaggio
    {
        public int Gold { get; set; }

        public Player(Random random) : base(random)
        {

        }
        public bool Run()
        {
            bool result = false;
            Random random = new Random();
            int number = random.Next(0, 100);
            if (number > 30)
            {
                result = true;
                Console.WriteLine("You escaped your enemy !");
            }
            else
            {
                Console.WriteLine("You failed to escape your enemy !");
            }
            return result;
        }
    }
}
