using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Attack;

namespace RickAndMortyGame.Mortys
{
    public class VolcanoMorty : IMorty
    {
        public int Health { get; set; } = 30;
        public void Scream()
        {
            Console.WriteLine("SZZZZZZZZZ!");
        }
        // I haven't used either of these methods in the game yet. I have no idea
        //    how combat is going to work yet, but I know this makes sense to me
        //    so I should be able to use it when I get to that point:
        public void Hurt(Attack attack)
        {
            // water puts out fire and maybe bludgeoning smashes rocks??
            if (attack.Type == DamageType.Water || attack.Type == DamageType.Bludgeoning)
            {
                attack.Damage = (int)Math.Floor(attack.Damage * 1.5);
            }
            // slashing wont hurt rocks and fire melts ice
            else if (attack.Type == DamageType.Slashing || attack.Type == DamageType.Ice)
            {
                attack.Damage = (int)Math.Ceiling(attack.Damage * 0.5);
            }
            Health -= attack.Damage;
        }
        // This makes sense for now, but it might change a lot in the future,
        //    once it's actually used somewhere:
        public Attack Attack()
        {
            return new Attack(5, 10, DamageType.Fire);
        }
    }
}