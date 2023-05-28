using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Student.BL;
using DegreeProgram.BL;
using Subject.BL;
namespace UAMS
{
    class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreePorgram> programList = new List<DegreePorgram>();
        static void Main(string[] args)
        {
            int option = Menu();
            clearScreen();
            decideMenu(option);
        }

    }
}
