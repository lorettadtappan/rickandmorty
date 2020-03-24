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

        public static Room garage = new Room(
            Texts.Splashes["garage"],
            new List<string> { "driveway", "house" },
            new List<Item> { Item.meeseeks, Item.plumbus }
        );
        public static Room driveway = new Room(
            Texts.Splashes["driveway"],
            new List<string> { "garage" },
            new List<Item> { }
        );
        public static Room house = new Room(
            Texts.Splashes["house"],
            new List<string> { "garage" },
            new List<Item> { Item.portalgun, Item.beer }
        );

        public void Run()
        {
            Room room = garage;
            bool alive = true;
            Console.Clear();
            Console.WriteLine("You accidentally killed Morty.\n" +
                    "In order to construct a passable facsimile, you must collect " +
                    "enough Mortys from other dimensions to assemble from them " +
                    "Morty's genetic structure and connectome.");
            while (alive)
            {
                // Show the splash text for the current room
                Console.WriteLine(room.Splash);
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                if (command.StartsWith("go "))
                {
                    if (command.Contains("driveway"))
                    {
                        room = driveway;
                    } else if (command.Contains("house"))
                    {
                        room = house;
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
                    } else
                    {
                        Console.WriteLine("I don't know what you're talking about");
                    }
                }
                else
                {
                    Console.WriteLine("What?");
                }
            }
        }
    }
}
