using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Home: Location
    {
        new Pikachu pikachu = new Pikachu();
        new Pidgey pidgey = new Pidgey();
        new Squirtle squirtle = new Squirtle();
        new Collection collection = new Collection();
        public Home()
        {
            action1 = "Sleep";
            action2 = "Go to Outside";
            action3 = "Check Pokémon Collection";
            action4 = "Throw out a Pokémon";
        }
        public override void LocationActions(Trainer a, string act1, string act2, string act3, string act4)
        {
            a.actions.Add(act1);
            a.actions.Add(act2);
            a.actions.Add(act3);
            a.actions.Add(act4);




        }
        public override void ClearLocationActions(Trainer a)
        {
            a.actions.Clear();
        }

        public override void PrimaryAction()
        {
            
            Console.WriteLine("S");
            Console.WriteLine("L");
            Console.WriteLine("E");
            Console.WriteLine("E");
            Console.WriteLine("P");
            Console.WriteLine("I");
            Console.WriteLine("N");
            Console.WriteLine("G");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("~~ M O R N I N G ~~");
        }

        public override void CheckCollection(Trainer a, int i)
        {
            
        }
        /*public override void RemoveFromCollection(Trainer a, Pokemon pokemon)
        {
            
        }
        */
        public override Location ChangeLocation(Location newLocation)
        {
           return newLocation = new Outside();
        }


    }
}
