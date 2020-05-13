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
        //A list called actions which is used to store actions the player can do.
        public List<Pokemon> pokemons = new List<Pokemon>();
        //A list called pokemons which is used to store pokémons you've collected
        Collection pokemonCollection = new Collection();
        //A Collection instance called pokemonCollection
               

        public void Actions(Location trainerLocation)
        {
            trainerLocation.ClearLocationActions(this);
            trainerLocation.LocationActions(this, trainerLocation.action1, trainerLocation.action2, trainerLocation.action3, trainerLocation.action4);
            Console.WriteLine("What would you like to do?(answer with a 1, 2 or 3):");
            
            for (int i = 0; i < actions.IndexOf(trainerLocation.action4) || i == actions.IndexOf(trainerLocation.action4); i++)
            {
                Console.WriteLine(actions[i]);
            }
            /*
             * This method runs the Location instace parameter's ClearLocationActions method.
             * Then the Location instace parameter's LocationActions is run.
             * The player is then asked the question of what action they'd like to do and the list actions is written out.
             */
        }

        public void Action1(Location trainerLocation) 
        {
            
            trainerLocation.PrimaryAction(this);
            //Runs the Location instace parameter's PrimaryAction method.

        }
        public Location Action2(Location trainerLocation)
        {
            
            return trainerLocation.ChangeLocation(trainerLocation);
            //Returns a location from the Location instace parameter's ChangeLocation method.


        }

        public void PokemonCollection(Location trainerLocation, Pokemon pokemon)
        {
            if (pokemons.Count > 0)
            {
                trainerLocation.CheckCollection(this, pokemon.index);
                //Runs the Location instace parameter's CheckCollection method.
            }

        }
        public void ThrowPokemon(Location trainerLocation, Pokemon pokemon)
        {
            trainerLocation.RemoveFromCollection(this, pokemon);
            //Runs the Location instace parameter's RemoveFromCollection method.                                  
        }
        
        public void SetPokemonIndex(Pokemon pokemon)
        {
            pokemonCollection.SetPokemonIndex(pokemon, this);
            //Runs the Collection instance's SetPokemonIndex method.
        }
      
        public void AddPokemonToCollection(Pokemon pokemon)
        {
            pokemonCollection.AddPokemons(pokemon, this);
            //Runs the Collection instance's AddPokemons method
        }

    }
}
