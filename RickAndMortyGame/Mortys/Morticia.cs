using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Attack;

namespace RickAndMortyGame.Mortys
{
    public class Morticia : IMorty
    {
        public int Health { get; set; } = 50;
        public void Scream()
        {
            Console.WriteLine("PFFHHT");
        }
        public void Hurt(Attack attack)
        {
            if (attack.Type == DamageType.Mortify || attack.Type == DamageType.Belch)
            {
                attack.Damage = (int)Math.Floor((double)attack.Damage * 2);
            }
            else if (attack.Type == DamageType.Psych || attack.Type == DamageType.Piercing)
            {
                attack.Damage = (int)Math.Ceiling(attack.Damage * 0.5);
            }
            Health -= attack.Damage;
        }
        public Attack Attack()
        {
            Random rand = new Random();
            int type = rand.Next(5);
            if (type == 0)
            {
                return new Attack(5, 15, DamageType.Radiant, "DeathGlare");
            }
            else
            {
                return new Attack(10, 20, DamageType.Magic, "Hex");
            }
        }
    }
}
