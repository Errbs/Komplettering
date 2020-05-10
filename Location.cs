using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Location
    {
        public string action1;
        public string action2;
        public string action3;
        public string action4;
                
        public virtual void LocationActions(Trainer a, string act1, string act2, string act3, string act4)
        {

        }
        public virtual void ClearLocationActions(Trainer a)
        {
            
        }
        public virtual void PrimaryAction()
        {

        }

        public virtual void CheckCollection(Trainer a, int i)
        {

        }

       /* public virtual void RemoveFromCollection(Trainer a, Pokemon pokemon)
        {

        }
        */


        public virtual Location ChangeLocation(Location newLocation)
        {
            return newLocation;
        }


    }
}
