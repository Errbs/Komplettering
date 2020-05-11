using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Outside: Location
    {
        public List<Pokemon> existingPokemon = new List<Pokemon>();
        new Pokemon p = new Pokemon();
        new Pikachu pikachu = new Pikachu();
        new Pidgey pidgey = new Pidgey();
        new Squirtle squirtle = new Squirtle();
        new Trainer a = new Trainer();
        Collection pokemonCollection = new Collection();

        static Random randomPokemon = new Random();
        protected int random;
        public Outside()
        {
            action1 = "Catch pokémons";
            action2 = "Go home";
            action3 = "Check Pokémon Collection";
            //action4 = "Throw out a Pokémon";

        }
        public override void LocationActions(Trainer a, string act1, string act2, string act3, string act4)
        {
            a.actions.Add(act1);
            a.actions.Add(act2);
            a.actions.Add(act3);
            //a.actions.Add(act4);
        }
        public override void ClearLocationActions(Trainer a)
        {
            a.actions.Clear();
        }

        public override void PrimaryAction(Trainer a)
        {
            existingPokemon = p.PokemonsExisting(this, pikachu, pidgey, squirtle);
            random = randomPokemon.Next(existingPokemon.Count-1);
            Console.WriteLine("You found " + existingPokemon[random].name + " write c to catch.");
            string answer = Console.ReadLine();
            
            if(answer == "c")
            {
                pokemonCollection.AddPokemons(existingPokemon[random], a);
            }


        }

        public override void CheckCollection(Trainer a, int i)
        {
            pokemonCollection.PokemonCollection(i, a);

        }
        /*public override void RemoveFromCollection(Trainer a, Pokemon pokemon)
        {
            //a.ThrowPokemon(pokemon);
            pokemonCollection.ThrowPokemon(a, pokemon);
        }
        */

        public override Location ChangeLocation(Location newLocation)
        {
            return newLocation = new Home();
        }



    }
}
