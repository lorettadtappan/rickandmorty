using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class Texts
    {
        // This class only exists to keep things a little more organized.
        // It keeps my Run() method from having a whole bunch of text in it, which
        //    makes it hard to read.

        // If we eventually add character dialogue or anything like that, those
        //    strings can be stored here, as well.
        public static Dictionary<string, string> Splashes = new Dictionary<string, string>()
        {
            {
                "garage", "\n\n\n\n\nYou're in the garage with all your junk and crap.\n\n" +
                    "Obvious exits are DRIVEWAY and HOUSE\n"
            },
            {
                "driveway", "\n\n\n\n\nYou're in the driveway. The car is gone but " +
                    "the oil stain is still there.\n\n" +
                    "Obvious exits are GARAGE and YARD\n"
            },
            {
                "house", "\n\n\n\n\nYou're in the house now. It's drab and smells like " +
                    "lemon pine-sol with a hint of stale fart.\n\n" +
                    "Obvious exits are GARAGE and KITCHEN\n"
            },
            {
                "upstairs", "\n\n\n\n\nYou're upstairs in the house now. It's dark and " +
                    "smells like mold and sweaty socks.\n\n" +
                    "Obvious exits are MORTY'S ROO, HOUSE and ATTIC\n"
            },
            {
                "attic", "\n\n\n\n\nYou're in the attic. Now you're lost in the dark" +
                    "there seem to be dead mice and bats everywhere. Run for your life!\n\n" +
                    "Obvious exits are UPSTAIRS\n"
            },
            {
                "mortysRoom", "\n\n\n\n\nYou're in Morty's room. It's filthy.\n\n" +
                    "Obvious exits are UPSTAIRS\n"
            }
        };
    }
}
