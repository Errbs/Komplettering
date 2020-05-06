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

            ash.AddPokemonToCollection(pikachu);
            ash.AddPokemonToCollection(squirtle);
            ash.PokemonCollection(squirtle.index);

            ash.ThrowPokemon(pikachu.index, pikachu);
            ash.ThrowPokemon(squirtle.index, squirtle);
            ash.ThrowPokemon(squirtle.index, squirtle);
            ash.AddPokemonToCollection(pidgey);
            ash.PokemonCollection(pidgey.index);
            ash.AddPokemonToCollection(pikachu);
            
            Console.ReadLine();
        }
    }
}
