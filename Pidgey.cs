using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Pidgey: Pokemon
    {
        public Pidgey()
        {
            name = "Pidgey";
            
        }
        public override void PokemonIndex(int i)
        {
            index = i;
        }
    }
}
