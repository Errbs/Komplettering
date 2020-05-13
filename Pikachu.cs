using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Pikachu:Pokemon
    {
        //Child class of Pokemon
        public Pikachu()
        {
            name = "Pikachu";
            //Defines the string name
        }

        public override void PokemonIndex(int i)
        {
            index = i;
            //Defines the int index
        }
       
    }
}
