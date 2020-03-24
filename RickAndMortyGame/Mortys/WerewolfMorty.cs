using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame.Mortys
{
    public class WerewolfMorty : IMorty
    {
        Random rand = new Random();
        public int Health { get; set; } = 25;
        public void Scream()
        {
            Console.WriteLine("RRAAAWWWWWOOOOOOOoooooOOOOooooowwww");
        }
        public void Hurt(int damage)
        {
            Health -= damage;
            Scream();
        }
        public int Attack()
        {
            return rand.Next(5, 11);
        }
    }
}
