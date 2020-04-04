using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class Attack
    {
        // I'm using an enum because I want a specific set of options that are basically
        //    just names. That's one thing an enum is good for
        public enum DamageType { Bludgeoning, Slashing, Piercing, Poison, Acid, Sonic, Psych, Fire, Water, Ice, Shocking, Magic, Necrotic, Radiant, Mortify, Belch };
        public int Damage;
        public DamageType Type;
        public string Name  { get; set; }
        private static readonly Random rand = new Random();//WHY IS THE RANDOM CHOICE OF DAMAGE READ ONLY?
        
        public Attack(int minDamage, int maxDamage, DamageType type, string name)
        {
            Damage = rand.Next(minDamage, maxDamage + 1);
            Type = type;
            Name = name;
        }

    }
}
