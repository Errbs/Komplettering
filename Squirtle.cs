using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Squirtle:Pokemon
    {
        //Child class of Pokemon
        public Squirtle()
        {
            name = "Squirtle";
            //Defines the string name
        }
        public override void PokemonIndex(int i)
        {
            index = i;
            //Defines the int index
        }
    }
}
