using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class Attack
    {
        public enum DamageType { Bludgeoning, Slashing, Piercing, Poison, Acid, Sonic, Psych, Fire, Water, Ice, Shocking, Magic, Necrotic, Radiant };
        public int Damage;
        public DamageType Type;
        private static readonly Random rand = new Random();

        public Attack(int minDamage, int maxDamage, DamageType type)
        {
            Damage = rand.Next(minDamage, maxDamage + 1);
            Type = type;
        }
    }
}
