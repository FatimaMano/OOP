using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Polymorphism_.BL
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public void getAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return "Person[name = " + name + ",address = " + address;
        }
    }
}
