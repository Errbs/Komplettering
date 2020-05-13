using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Home: Location
    {
        //This is a child class to the Location parent class
        Collection pokemonCollection = new Collection();
        //A collection instance called pokemonCollection
        public Home()
        {
            action1 = "Sleep";
            action2 = "Go to Outside";
            action3 = "Check Pokémon Collection";
            action4 = "Throw out a Pokémon";
            //The constructor defines the different actions
        }
        public override void LocationActions(Trainer a, string act1, string act2, string act3, string act4)
        {
            a.actions.Add(act1);
            a.actions.Add(act2);
            a.actions.Add(act3);
            a.actions.Add(act4);
            //This method adds the string parameters act-1,2,3 and 4 to the Trainer parameter instance  a's actions list
        }
        public override void ClearLocationActions(Trainer a)
        {
            a.actions.Clear();
            //This method empties the Trainer parameter instance  a's actions list, so that it won't add act act-1,2,3 and 4 multiple times.
        }

        public override void PrimaryAction(Trainer a)
        {
            Console.Clear();
            Console.WriteLine("S\nL\nE\nE\nP\nI\nN\nG\n.\n.\n.");
            Console.WriteLine("~~ M O R N I N G ~~");
            //This method clears the console and then writes out a "loading sleeping screen" and then it writes out morning.
        }

        public override void CheckCollection(Trainer a, int i)
        {
            pokemonCollection.PokemonCollection(i, a);
            //This method runs the Collection instance's PokemonCollection method.
        }
        public override void RemoveFromCollection(Trainer a, Pokemon pokemon)
        {
            pokemonCollection.ThrowPokemon(a, pokemon);
            //This method runs the Collection instance's RemoveFromCollection method.
        }

        public override Location ChangeLocation(Location newLocation)
        {
           return newLocation = new Outside();
           //This method changes the value of the Location parameter newLocation and returns it.
        }


    }
}
