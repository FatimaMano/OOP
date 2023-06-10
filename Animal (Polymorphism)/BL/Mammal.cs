using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Polymorphism_.BL
{
    class Mammal : Animal
    {
        public Mammal(string name): base(name)
        {
            
        }
        public override void greets()
        {

        }
        public override string toString()
        {
            return "Mammal[Animal[name = '" + name + "']]";
        }
        
    }
}
