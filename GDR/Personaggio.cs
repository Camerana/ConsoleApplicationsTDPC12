using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.GDR
{
    public abstract class Personaggio
    {
        public int HP { get; set; }
        public int MaxDamage { get; set; }

        public Personaggio(Random random)
        {
            this.HP = random.Next(10, 100);
            this.MaxDamage = random.Next(10, 20);
        }
        public virtual void Attack(Personaggio attacked)
        {
            Random random = new Random();
            int damage = random.Next(0, this.MaxDamage);
            Console.WriteLine("Damage: " + damage);
            attacked.HP = attacked.HP - damage;
            Console.WriteLine("HP Remaining: " + attacked.HP);
        }
    }
}
