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
            Trainer ash = new Trainer();
            Pikachu pikachu = new Pikachu();
            Squirtle squirtle = new Squirtle();
            Pidgey pidgey = new Pidgey();
            Location location = new Home();
            bool continueRunning = true;
                      

            ash.Actions(location);
            string input;
            int answer;
            input = Console.ReadLine();
            bool validAnswer = int.TryParse(input, out answer);
            if (validAnswer == true&&answer == 1||answer == 2||answer == 3)
            {
                while (continueRunning == true)
                {
                    if (answer == 1)
                    {
                        ash.Action1(location);
                        ash.Actions(location);



                    }
                    else if (answer == 2)
                    {
                        location = ash.Action2(location);
                        ash.Actions(location);

                    }
                    else if (answer == 3)
                    {
                        ash.PokemonCollection(location, ash.pokemons[ash.pokemons.Count-1]);
                    }
                   
                    else
                    {
                        Console.WriteLine("Answer with 1, 2 or 3");

                    }

                    input = Console.ReadLine();
                    validAnswer = int.TryParse(input, out answer);


                }

            }
         
            //Coming back to this later





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
