using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System.UI
{
    class TestUI
    {
         public static void PrintTestSchedule()
        {
            foreach(Test test in TestDL.testList)
            {
                Console.WriteLine("{0}: {1}",test.getTestName(),test.getTestDateTime());
            }
        }

    }
}
