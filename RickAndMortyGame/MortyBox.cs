using RickAndMortyGame.Mortys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    class MortyBox
    {
        private List<IMorty> mortys = new List<IMorty>();

        public List<IMorty> GetAllMortys()
        {
            return mortys;
        }

        public void CollectMorty(IMorty morty)
        {
            mortys.Add(morty);
        }

        public void DumpMorty(IMorty morty)
        {
            bool isInList = mortys.Contains(morty);

            if (isInList)
            {
                mortys.Remove(morty);
            }
        }
    }
}
