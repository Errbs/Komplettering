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
            ash.AddPokemonToCollection(pikachu);
            ash.PokemonCollection(0); 
            ash.ThrowPokemon(0);
            Console.ReadLine();
        }
    }
}
