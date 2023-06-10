using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__Polymorphism_.BL
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void greets()
        {

        }
        public virtual string toString()
        {
            return "Animal[name = '" + name + " ']";
        }
    }
}
