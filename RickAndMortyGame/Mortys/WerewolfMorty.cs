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
            Health -= attack.Damage;
            Scream();
        }
        public Attack Attack()
        {
            return new Attack(5, 10, DamageType.Slashing);
        }
    }
}
