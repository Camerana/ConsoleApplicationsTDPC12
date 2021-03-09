using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.GDR
{
    public class Nemico : Personaggio
    {
        public int GoldReward { get; set; }

        public Nemico(Random random) : base(random)
        {
            this.GoldReward = random.Next(0, 101);
        }
    }
}