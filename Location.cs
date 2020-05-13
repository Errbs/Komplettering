using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Location
    {
        /*
         * This parent class is basically abstract, however I couldn't make it an "abstract class". 
         * Because I wanted to create a Location instance that later get defined 
         * Having it be abstract stopped me from being able to do that.
         */
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
        public virtual void PrimaryAction(Trainer a)
        {

        }

        public virtual void CheckCollection(Trainer a, int i)
        {

        }

       public virtual void RemoveFromCollection(Trainer a, Pokemon pokemon)
        {

        }
        


        public virtual Location ChangeLocation(Location newLocation)
        {
            return newLocation;
        }


    }
}
