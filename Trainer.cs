using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Komplettering
{
    class Trainer
    {
        public List<string> actions = new List<string>();
        public List<Pokemon> pokemons = new List<Pokemon>();
        Collection pokemonCollection = new Collection();
        //Location locationTrainer = new Location();
        

        public void Actions(Location trainerLocation)
        {
            trainerLocation.ClearLocationActions(this);
            trainerLocation.LocationActions(this, trainerLocation.action1, trainerLocation.action2, trainerLocation.action3, trainerLocation.action4);
            Console.WriteLine("What would you like to do?(answer with a 1, 2 or 3):");
            
            for (int i = 0; i < actions.IndexOf(trainerLocation.action3) || i == actions.IndexOf(trainerLocation.action3); i++)
            {
                Console.WriteLine(actions[i]);
                
            }
                       
            
        }

        public void Action1(Location trainerLocation) 
        {
            trainerLocation.PrimaryAction();

        }
        public Location Action2(Location trainerLocation)
        {
            return trainerLocation.ChangeLocation(trainerLocation);
                       

        }

    
       
        public void PokemonCollection(int i, Location trainerLocation)
        {
            trainerLocation.CheckCollection(this, i);
            //pokemonCollection.PokemonCollection(i, this);
        }
        /*public void ThrowPokemon(Pokemon pokemon, Location trainerLocation)
        {
            trainerLocation.RemoveFromCollection(this, pokemon);
            //pokemonCollection.ThrowPokemon(this, pokemon);
                                    
        }
        */
        public void SetPokemonIndex(Pokemon pokemon)
        {
            pokemonCollection.SetPokemonIndex(pokemon, this);
        }
        public void AddPokemonToCollection(Pokemon pokemon)
        {
            pokemonCollection.AddPokemons(pokemon, this);
        }
    }
}
