using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Polymorphism_.BL
{
    class Cat :Mammal
    {
        public Cat(string name): base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return "Cat[Mammal[Animal[name = '" + name + "']]]";
        }
    }
}
