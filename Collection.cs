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
        HashSet<int> pokemonsThrown = new HashSet<int>();

        public void PokemonCollection(int i)
        {
            for(int n=0; n<i||n==i; n++) // it won't write out the second pokemons name so I should probably use the list in the forloop
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
            pokemonsThrown.Add(i);

            if (pokemonsThrown.Contains(i) == true)
            {
                
                Console.WriteLine(pokemons[i] + " thrown out!"); //Index was out of range, I don't understand why this error pops up.
                pokemons.Remove(pokemons[i]);
            }
            else
            {
                Console.WriteLine("You can't throw the same pokemon twice!");
            }
            
        }
      
        public void ThrowPokemon(int i, Trainer a)
        {
           
                PokemonThrownOut(i);
        
                
                    

            

        }
    }
}
