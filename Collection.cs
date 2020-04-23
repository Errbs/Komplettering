using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Collection
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        public void PokemonCollection(int i)
        {
            for(int n=0; n<i||n==i; n++)
            {
                Console.WriteLine(pokemons[n].name); 
            }
        }

        public void AddPokemons(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public void PokemonThrownOut(int i)
        {
            pokemons.Remove(pokemons[i]);
        }
      
        public void ThrowPokemon(int i, Trainer a)
        {
            PokemonThrownOut(i);
                    

            

        }
    }
}
