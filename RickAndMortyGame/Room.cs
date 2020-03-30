using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.ProgramUI;

namespace RickAndMortyGame
{
    public class Room
    {
        public string Splash { get; }//AT THIS POINT, I DON'T KNOW HOW THE HELL I'D KNOW TO PUT THIS HERE 25MARCH
        public List<string> Exits { get; }//I DO THINK I UNDERSTAND WHY THIS WOULD BE HERE AS A GETTER AS ROOM COULD HAVE MULITPLE EXITS
        public List<Item> Items { get; }//SAME IN UNDERSTANDING AS MULTIPLE ITEMS LIKE WEAPON I GUESS COULD BE USED FROM HERE. BUT WHAT IS ITEM VS STRING?

        // I planned to add an Events list, that contains Event class objects
        // An Event can have items or actions that it depends on, possibly
        // Other Events. Events can also make new Exits or Items available.

        // TODO:
        // public List<Event> Events { get; }

        public Room(string splash, List<string> exits, List<Item> items)
        {
            Splash = splash;
            Items = items;
            Exits = exits;
        }
        // These methods are similar to the "repo pattern", which could also be called
        //    "list control":
        public void AddExit(string newExit)
        {
            Exits.Add(newExit);
        }

        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
    }
}
