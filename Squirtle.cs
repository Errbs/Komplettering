﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Squirtle:Pokemon
    {
        public Squirtle()
        {
            name = "Squirtle";
            index = 1;
        }
        public override void PokemonIndex(int i)
        {
            index = i;
        }
    }
}
