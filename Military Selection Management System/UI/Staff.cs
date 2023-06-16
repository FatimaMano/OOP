using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.UI
{
    class Staff
    {
        public static void UpdatingTestSchedule(int numTests)
        {
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("Enter the name of test {0} : ", i + 1);
                testNames[i] = Console.ReadLine();
                Console.WriteLine("Enter the date of test {0}  (dd/mm/yyyy): ", i + 1);
                testDates[i] = Console.ReadLine();
                Console.WriteLine("Enter the time of test {0} (hh:mm): ", i + 1);
                testTimes[i] = Console.ReadLine();
            }
        }
    }
}
