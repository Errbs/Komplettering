using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Trainer
    {
        Collection pokemonCollection = new Collection();
        public void ThrowPokemon(int i)
        {
            pokemonCollection.ThrowPokemon(i, this);
        }
    }
}
