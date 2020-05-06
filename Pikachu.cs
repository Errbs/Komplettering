using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Pikachu:Pokemon
    {
        public Pikachu()
        {
            name = "Pikachu";

        }

        public override void PokemonIndex(int i)
        {
            index = i;
        }
        //make an index method that communicates what index in the list the pokemon has
    }
}
