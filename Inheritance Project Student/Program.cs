using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inheritance_Project_Student.BL;

namespace Inheritance_Project_Student
{
    static class Program
    {
        static void Main(string[] args)
        {
            //For DayScholar
            DayScholar std = new DayScholar("Ali","2022",true,300,300,"195 Block Ali touwn",2,100);
            std.name = "Ahmad";
            std.busNo = 1;
            Console.WriteLine(std.name + " is Allocated Bus " + std.busNo);
            Console.ReadKey();
            //For Hostellite
            Hostellite std1 = new Hostellite("Fatima","2022",true,100,1050,true,255,true);
            std1.name = "Ahmad";
            std1.RoomNumber = 12;
            Console.WriteLine(std.name + " is Allocated Room " + std.RoomNumber);
            Console.ReadKey();
            
        }
    }
}
