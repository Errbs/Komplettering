using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Program
    {
        static void Main(string[] args)
        {
            //I have tested the code a lot and I have fixed all bugs I have encountered, however there might be more bugs I have not yet noticed.

            Trainer ash = new Trainer();
            //An instance of the class Trainer, called ash.
            Pikachu pikachu = new Pikachu();
            //An instance of the class Pikachu, called pikachu.
            Squirtle squirtle = new Squirtle();
            //An instance of the class Squirtle, called squirtle.
            Pidgey pidgey = new Pidgey();
            ////An instance of the class Pidgey, called pidgey.
            Location location = new Home();
            //An instance of the class Location, called location set to be a Home instance.
            bool continueRunning = true;
            //A bool to continue the while loop of the game.
            string input;
            //A string that is used to store input from the player.
            int answer;
            //An int used to store the tryparsed player input.
            string inputPokemon;
            //A string used for player input, created because it got cunfused when I used the string input.

            ash.Actions(location);
            //Runs Trainer instance ash's Action method using the instance location.
            
            input = Console.ReadLine();
            //Sets string input to be whatever the player writes in console.
            bool validAnswer = int.TryParse(input, out answer);
            //A bool used to check if the input can be converted to an int.
            
            while (continueRunning == true)
            {
                if (validAnswer == true && answer == 1 || answer == 2 || answer == 3 || answer == 4)
                {
                    if (answer == 1)
                    {
                        Console.Clear();
                        ash.Action1(location);
                        ash.Actions(location);
                        /*
                         * Console is first cleared, so it will be easier to read what is going on
                         * Then Trainer instance ash's Action1 method using the instance location is run.
                         * Finally the Trainer instance ash's Action method using the instance location is run.
                         */
                    }
                    else if (answer == 2)
                    {
                        Console.Clear();
                        location = ash.Action2(location);
                        ash.Actions(location);
                        /*
                        * Console is first cleared, so it will be easier to read what is going on
                        * Then Trainer instance ash's Action2 method using the instance location is run.
                        * Finally the Trainer instance ash's Action method using the instance location is run.
                        */

                    }
                    else if (answer == 3)
                    {
                        Console.Clear();
                        ash.PokemonCollection(location, ash.pokemons[ash.pokemons.Count - 1]);
                        ash.Actions(location);
                      /*
                      * Console is first cleared, so it will be easier to read what is going on
                      * Then Trainer instance ash's PokemonCollection method using the instance location is run.
                      * Finally the Trainer instance ash's Action method using the instance location is run.
                      */
                    }
                    else if (answer == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Pick a pokemon to remove from your collection by writing it's name");
                        inputPokemon = Console.ReadLine();
                        if (inputPokemon == "pikachu")
                        {
                            ash.ThrowPokemon(location, pikachu);
                        }
                        else if (inputPokemon == "pidgey")
                        {
                            ash.ThrowPokemon(location, pidgey);
                        }
                        else if (inputPokemon == "squirtle")
                        {
                            ash.ThrowPokemon(location, squirtle);
                        }
                        else
                        {
                            Console.WriteLine(inputPokemon + " is not a pokémon or it is not in your collection");
                        }
                        ash.Actions(location);
                        /*
                         * Console is first cleared, so it will be easier to read what is going on.
                         * Then the player is asked which pokémon they would like to remove from the collection and instructed to write the name.
                         * The string inputPokemon is set to be the input from what the player writes in the console.
                         * If the input is equal to any of the three pokémons names ash's ThrowPokemon method is run with the corresponding instance as a parameter
                         * If the input is not a pokemon the player is informed that the pokemon either isn't in the collection or it doesn't exist.
                         * Finally the Trainer instance ash's Action method using the instance location is run.
                         */

                    }

                    /*
                     * If the input was able to convert to an int and validAnswer wa true. 
                     * As well as the answer being either 1, 2, 3 or 4.
                     * It then checks what number was written and depending on that an action is run.
                     */


                }

                else
                {
                    Console.WriteLine("Answer with 1, 2 or 3");
                    //This is what runs if the input could not  be converted into an int and the bool validAnswer is false
                }

                input = Console.ReadLine();
                validAnswer = int.TryParse(input, out answer);

                //This while loop will continue running, because it contains the entire game.
            }







                /*ash.AddPokemonToCollection(pikachu);
                ash.AddPokemonToCollection(squirtle);
                ash.PokemonCollection(squirtle.index);

                ash.ThrowPokemon(pikachu.index, pikachu);
                ash.ThrowPokemon(squirtle.index, squirtle);
                ash.ThrowPokemon(squirtle.index, squirtle);
                ash.AddPokemonToCollection(pidgey);
                ash.PokemonCollection(pidgey.index);
                ash.AddPokemonToCollection(pikachu);
                */

                Console.ReadLine();
        }
    }
}
