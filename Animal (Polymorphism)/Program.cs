using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal__Polymorphism_.BL;
using Animal__Polymorphism_.DL;
namespace Animal__Polymorphism_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Candy");
            Cat cat2 = new Cat("Tom");
            Dog dog1 = new Dog("Thyme");
            Dog dog2 = new Dog("Tommy");
            cat1.greets();
            cat1.toString();
            AnimalDL.AddMammal(cat1);
            cat2.greets();
            cat2.toString();
            AnimalDL.AddMammal(cat2);
            dog1.greets();
            dog1.toString();
            AnimalDL.AddMammal(dog1);
            dog2.greets();
            dog2.toString();
            AnimalDL.AddMammal(dog2);

        }
    }
}
