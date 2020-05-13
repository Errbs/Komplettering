using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Collection
    {
       
       protected HashSet<string> pokemonsAdded = new HashSet<string>();
        //Hash set to keep track of what pokémons you've already have collected
        protected HashSet<string> pokemonsRemoved = new HashSet<string>();
        //Hash set to keep track of what pokémons have already been removed

        public void SetPokemonIndex(Pokemon pokemon, Trainer a) 
        {
           pokemon.index = a.pokemons.IndexOf(pokemon);
            //A method that sets the pokemon index to the pokemons index in trainer a's list pokemons                        
        }

        public void PokemonCollection(int i, Trainer a)
        {
            if (a.pokemons == null)
            {
                Console.WriteLine("Collection is empty, go catch some pokemon!");
            }
            else
            {
                Console.WriteLine("POKÉMON COLLECTION:");
                for (int n = 0; n == i || n < i; n++)
                {

                    Console.WriteLine(a.pokemons[n].name);
                }
            }

            /*
             *  A method that will check if the list pokemons is null, if it is it will inform the player.
             *  If the list however contains a pokémon it will write out the collected pokémons.
             */
        }

        public void AddPokemons(Pokemon pokemon, Trainer a)
        {
            if (pokemonsAdded.Add(pokemon.name) == true)
            {
                pokemonsRemoved.Remove(pokemon.name);
                a.pokemons.Add(pokemon);
                a.SetPokemonIndex(pokemon);
                Console.WriteLine(pokemon.name + " was added to Collection!");
                
            }
            else
            {
                Console.WriteLine("You have already collected " + pokemon.name);
            }
            /*
             * Method that checks if a pokémons name can be added to the pokemonsAdded hash set.
             * If it can it removes the name from the pokemonsRemoved hash set. 
             * Because if I threw a pikachu out before I want to be able to collect another pikachu and throw it out again.
             * Then the pokemon is added to the collection, as well as setting it's index to the same index it has in the list pokemons.
             * Finally a message is written out that informs the player of the pokemon being added.
             * However if it can't be added and your collection already contains that name, a message informs the player of that.
             */
        }

            
        public void ThrowPokemon(Trainer a, Pokemon pokemon)
        {
            
            if (pokemonsRemoved.Add(pokemon.name) == true)
            {
                pokemonsAdded.Remove(pokemon.name);
                a.pokemons.Remove(a.pokemons[pokemon.index]);
                Console.WriteLine(a.pokemons[pokemon.index].name + " thrown out!");

            }
            else
            {
                Console.WriteLine(pokemon.name + " has already been thrown out!");
            }

            /*
             * Method that checks if a pokémons name can be added to the pokemonsRemoved hash set.
             * If it can it removes the name from the pokemonsAdded hash set.
             * Because you want to be able to go out and collect it again after you've thrown it out.
             * The pokemon is removed from the collection and the player gets informed that the pokemon is thrown out.
             * Otherwise if the pokemon name can't be added to the hash set and it's already thrown it out the player is informed of it.
             */

        }

    }
}
