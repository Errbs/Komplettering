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
            for(int n=0; n<i||n==i; n++) // It writes out the same pokemons name twice
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
           
            if (pokemonsThrown.Add(i) == true)
            {
                Console.WriteLine(pokemons[0].name + " thrown out!"); //Works if I set it to 0 however if I set it to i, it is out of range when it is 1 because we already threw a pokemon oout makin 1 as an index for the list unvalid.
                pokemons.Remove(pokemons[0]);
               
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
