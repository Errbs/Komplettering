using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Pokemon
    {
        //This class is a parent class
        public string name;
        public int index;
        
        
        public Pokemon()
        {
           
            
            
                      
        }
        public List<Pokemon> PokemonsExisting(Outside outside, Pikachu pika, Pidgey pidge, Squirtle squi)
        {
            outside.existingPokemon.Add(pika);
            outside.existingPokemon.Add(pidge);
            outside.existingPokemon.Add(squi);
            return outside.existingPokemon;
            //This method adds Pokemon instances to the Outside class instance outside's existingPokemon list and returns it.
        }
        
        public virtual void PokemonIndex(int i)
        {
            
        }

       

    }
}
