using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Collection
    {
       //protected List<Pokemon> pokemons = new List<Pokemon>();
       protected HashSet<string> pokemonsAdded = new HashSet<string>();
       //protected HashSet<string> pokemonsRemoved = new HashSet<string>();

        public void SetPokemonIndex(Pokemon pokemon, Trainer a)
        {
           pokemon.index = a.pokemons.IndexOf(pokemon);
                                  
        }

        public void PokemonCollection(int i, Trainer a)
        {
            Console.WriteLine("POKÉMON COLLECTION:");
            for(int n = 0; n == i||n<i; n++) 
            {
                Console.WriteLine(a.pokemons[n].name);  
            }
        }

        public void AddPokemons(Pokemon pokemon, Trainer a)
        {
            if (pokemonsAdded.Add(pokemon.name) == true)
            {
                //pokemonsRemoved.Remove(pokemon.name);
                a.pokemons.Add(pokemon);
                a.SetPokemonIndex(pokemon);
                Console.WriteLine(pokemon.name + " was added to Collection!");
                
            }
            else
            {
                Console.WriteLine("You have already collected " + pokemon.name);
            }
            
        }

            
        /*public void ThrowPokemon(Trainer a, Pokemon pokemon)
        {

            if (pokemonsRemoved.Add(pokemon.name) == true)
            {
                pokemonsAdded.Remove(pokemon.name);
                Console.WriteLine(a.pokemons[a.pokemons.IndexOf(pokemon)].name + " thrown out!");
                a.pokemons.Remove(a.pokemons[a.pokemons.IndexOf(pokemon)]);

            }
            else
            {
                Console.WriteLine(pokemon.name + " has already been thrown out!");
            }


        }
        */
    }
}
