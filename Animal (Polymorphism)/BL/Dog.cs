using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Polymorphism_.BL
{
    class Dog : Mammal
    {
        public Dog(string name):base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Woof");
        }
        public override string toString()
        {
            return "Dog[Mammal[Animal[name = '" + name + "']]]";
        }
    }
}
