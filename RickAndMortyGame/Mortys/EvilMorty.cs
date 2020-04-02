using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Attack;

namespace RickAndMortyGame.Mortys
{
    public class EvilMorty : IMorty
    {
        public int Health { get; set; } = 35;
        public void Scream()
        {
            Console.WriteLine("Hsssssssssss");
        }
        // I haven't used either of these methods in the game yet. I have no idea
        //    how combat is going to work yet, but I know this makes sense to me
        //    so I should be able to use it when I get to that point:
        public void Hurt(Attack attack)
        {
            if (attack.Type == DamageType.Radiant || attack.Type == DamageType.Magic)
            {
                attack.Damage = (int)Math.Floor(attack.Damage * 1.5);
            }
            else if (attack.Type == DamageType.Fire || attack.Type == DamageType.Psych)
            {
                attack.Damage = (int)Math.Ceiling(attack.Damage * 0.5);
            }
            Health -= attack.Damage;
        }
        // This makes sense for now, but it might change a lot in the future,
        //    once it's actually used somewhere:
        public Attack Attack()
        {
            string name = "Death Touch";
            return new Attack(10, 20, DamageType.Necrotic, name);
        }
    }
}
