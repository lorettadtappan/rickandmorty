using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class ProgramUI
    {
        public enum Item { plumbus, meeseeks, portalgun, beer };
        public List<Item> inventory = new List<Item>();
        string room = "garage";
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
                // Show the splash text for the current room
                Console.WriteLine(Texts.Splashes[room]);
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
                    } else
                    {
                        Console.WriteLine("Go where??");
                    }
                }
                else if (command.StartsWith("get "))
                {
                    if (command.Contains("plumbus"))
                    {
                        if (inventory.Contains(Item.plumbus))
                        {
                            Console.WriteLine("You already got the plumbus");
                        } else
                        {
                            Console.WriteLine("You find a slightly used plumbus");
                            inventory.Add(Item.plumbus);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("What?");
                }
            }
        }
        public void Driveway()
        {
            // Console.WriteLine("You are in the driveway");
            room = "driveway";

        }
        public void House()
        {
            // Console.WriteLine("You are in the house");
            room = "house";
        }
    }
}
