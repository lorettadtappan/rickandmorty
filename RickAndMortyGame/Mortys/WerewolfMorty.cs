using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Attack;

namespace RickAndMortyGame.Mortys
{
    public class WerewolfMorty : IMorty
    {
        public int Health { get; set; } = 25;
        public void Scream()
        {
            Console.WriteLine("RRAAAWWWWWOOOOOOOoooooOOOOooooowwww");
        }
        public void Hurt(Attack attack)
        {
            if (attack.Type == DamageType.Bludgeoning)
            {
                Health -= attack.Damage / 2;
            }
            else if (attack.Type == DamageType.Piercing)
            {
                Health -= attack.Damage * 2;
            }
            else
            {
                Health -= attack.Damage;
                Scream();
            }
        }
        public Attack Attack()
        {
            // If health is low, attack is higher or lower?? Which makes more sense?
            return new Attack(5, 10, DamageType.Slashing);
        }
    }
}
