using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame.Mortys
{
    class MicroMorty
    {
        public int Health { get; set; }

        public MicroMorty()
        {
            Health = 50;
        }

        public Attack Attack() 
        {
            int maxDamage = 30;
            int minDamage = 5;
            Attack pileDrive = new Attack(minDamage, maxDamage, RickAndMortyGame.Attack.DamageType.Bludgeoning);
            return pileDrive;
        }

        void Scream()
        {
            Console.WriteLine("aaaaaahhhhhhh!!!!");
        }

        void Hurt(Attack attack)
        {
            Health -= attack.Damage;
        }
    }
}
