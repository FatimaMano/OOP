using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Polymorphism_.BL;

namespace Person_Polymorphism_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali","Mughalpura","ComputerScience",2002,70000);
            Student s2 = new Student("Fatima", "Tajpura", "ComputerEngineering", 2000, 70000);
            Staff staff1 = new Staff("Ahamd", "Ali Town", "Kips", 50000);
            Staff staff2 = new Staff("AliAhmaf", "Ali town", "Educators", 50000);

        }
    }
}
