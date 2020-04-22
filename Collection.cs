using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Collection
    {
        List<string> pokemons = new List<string>() { "Squirtle", "Pikachu" };

        public void AddPokemons(Pokemon pokemon)
        {
            pokemons.Add(pokemon)
        }
        public void ThrowPokemon(int i, Trainer a)
        {
            a.ThrowPokemon(i);

        }
    }
}
