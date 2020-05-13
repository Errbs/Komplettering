using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Outside: Location
    {
        //This is a child class to the Location parent class
        public List<Pokemon> existingPokemon = new List<Pokemon>();
        //A list called existingPokemon, which is used to store the pokémons that can be found and collected outside.
        protected string answer;
        //A string called answer, used to store input from the player.
        protected int random;
        //An int called random, used to store a randomized number.
        protected static Random randomPokemon = new Random();
        //A static random called randomPokemon, used to randomize a number to find a random pokemon from the list existingPokemon
        Pokemon p = new Pokemon();
        //An instance of the class Pokemon
        Pikachu pikachu = new Pikachu();
        //An instance of the class Pikachu
        Pidgey pidgey = new Pidgey();
        //An instance of the class Pidgey
        Squirtle squirtle = new Squirtle();
        //An instance of the class Squirtle
        Trainer a = new Trainer();
        //An instance of the class trainer
        Collection pokemonCollection = new Collection();
        //An instance of the class Collection
                      
       
        public Outside()
        {
            action1 = "Catch pokémons";
            action2 = "Go home";
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
            existingPokemon = p.PokemonsExisting(this, pikachu, pidgey, squirtle);
            random = randomPokemon.Next(existingPokemon.Count-1);
            Console.WriteLine("You found " + existingPokemon[random].name + " write c to catch.");
            answer = Console.ReadLine();
            
            if(answer == "c")
            {
                Console.Clear();
                pokemonCollection.AddPokemons(existingPokemon[random], a);
            }
            else
            {
                Console.WriteLine("Pokémon ran away!");
            }
            /*
             * This method puts in the returned values from the Pokemon instance p's PokemonExisting into the list existingPokemon.
             * It then sets the int random equal to a randomly generated number based on the lenght of the existingPokemon list.
             * The player is then informed what randomized pokemon they found and is instructed to write c if they want to catch it.
             * Then the string answer is set equal to what the player writes in the console.
             * If answer is equal to c the console first clears.
             * Then the Collection instance pokemonCollection's AddPokemons method is run.
             * Otherwise the player is informed that the pokemon ran away.
             */
            


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
            return newLocation = new Home();
            //This method changes the value of the Location parameter newLocation and returns it.
        }



    }
}
