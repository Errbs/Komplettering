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
             

       HashSet<string> pokemonsAdded = new HashSet<string>();
       HashSet<string> pokemonsRemoved = new HashSet<string>();

        public void SetPokemonIndex(Pokemon pokemon)
        {
           pokemon.index = pokemons.IndexOf(pokemon);
                                  
        }

        public void PokemonCollection(int i)
        {
            Console.WriteLine("POKÉMON COLLECTION:");
            for(int n = 0; n == i||n<i; n++) 
            {
                Console.WriteLine(pokemons[n].name);  
            }
        }

        public void AddPokemons(Pokemon pokemon)
        {
            if (pokemonsAdded.Add(pokemon.name) == true)
            {
                pokemonsRemoved.Remove(pokemon.name);
                pokemons.Add(pokemon);
                SetPokemonIndex(pokemon);
                Console.WriteLine(pokemon.name + " was added to Collection!");
                
            }
            else
            {
                Console.WriteLine("You have already collected " + pokemon.name);
            }
            
        }

        public void PokemonThrownOut(int i, Pokemon pokemon)
        {
            if (pokemonsRemoved.Add(pokemon.name)==true)
            {
                pokemonsAdded.Remove(pokemon.name);
                Console.WriteLine(pokemons[pokemons.IndexOf(pokemon)].name + " thrown out!");
                pokemons.Remove(pokemons[pokemons.IndexOf(pokemon)]);

            }
            else
            {
                Console.WriteLine(pokemon.name + " has already been thrown out!");
            }
                                    
                      
        }
      
        public void ThrowPokemon(int i, Trainer a, Pokemon pokemon)
        {
           
                PokemonThrownOut(i, pokemon);
        
                
                    

            

        }
    }
}
