using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class ProgramUI
    {
        public void Run()
        {
            bool alive = true;
            Console.Clear();
            Console.WriteLine("You accidentally killed Morty.\n" +
                    "In order to construct a passable facsimile, you must collect " +
                    "enough Mortys from other dimensions to assemble from them " +
                    "Morty's genetic structure and connectome.");
            while (alive)
            {
                Console.WriteLine("\n\n\n\n\nYou're in the garage with all your junk and crap.\n\n" +
                    "Obvious exits are DRIVEWAY and HOUSE\n");
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                if (command.StartsWith("go "))
                {
                    if (command.Contains("driveway"))
                    {
                        Driveway();
                    } else if (command.Contains("house"))
                    {
                        House();
                    }
                } else
                {
                    Console.WriteLine("What?");
                }
            }
        }
        public void Driveway()
        {
            Console.WriteLine("You are in the driveway");
        }
        public void House()
        {
            Console.WriteLine("You are in the house");
        }
    }
}
