using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal__Polymorphism_.BL;
namespace Animal__Polymorphism_.DL
{
    class AnimalDL
    {
        public static List<Animal> animals = new List<Animal>();
        public static void AddMammal(Animal mammal)
        {
            animals.Add(mammal);
        }

    }
}
