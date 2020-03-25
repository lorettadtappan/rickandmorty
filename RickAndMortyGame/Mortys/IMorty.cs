using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame.Mortys
{
    public interface IMorty
    {
        // Keeping this really simple for now.
        // These are just the things I know I'll want. I'm not using
        //    any of them yet.

        // By using an interface, I can create an abstract template for what
        //    my Morty classes will be like, but they can all have their own
        //    logic, and some can have special abilities.
        // This interface just ensures that they all have the same standard
        //    features, in some form
        int Health { get; }
        void Scream();
        void Hurt(Attack damage);
        Attack Attack();
    }
}
