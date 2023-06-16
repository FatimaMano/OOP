using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System.UI
{
    class StaffUI
    {
        public static Test UpdatingTestSchedule(int numTests)
        {
            string TestName;
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("Enter the name of test {0} : ", i + 1);
                TestName = Console.ReadLine();
                isTrueTestName(TestName);
                DateTime TimeDate = TakeDateTime();
                Test test = new Test(TimeDate);
                return test;
            }
        }
        public DateTime TakeDateTime()
        {
            int day = GetValidDay();
            int month = GetValidMonth();
            int year = GetValidYear();
            int hour = GetValidHour();
            int minute = GetValidMinute();

            DateTime testDateTime = new DateTime(year, month, day, hour, minute, 0);
            return testDateTime;
        }

        private int GetValidDay()
        {
            Console.WriteLine("Enter the day of the test:");
            int day;
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Invalid input. Please enter a valid day (1-31):");
            }
            return day;
        }

        private int GetValidMonth()
        {
            Console.WriteLine("Enter the month of the test:");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid input. Please enter a valid month (1-12):");
            }
            return month;
        }

        private int GetValidYear()
        {
            Console.WriteLine("Enter the year of the test:");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < DateTime.Now.Year)
            {
                Console.WriteLine("Invalid input. Please enter a valid year:");
            }
            return year;
        }

        private int GetValidHour()
        {
            Console.WriteLine("Enter the hour of the test:");
            int hour;
            while (!int.TryParse(Console.ReadLine(), out hour) || hour < 0 || hour > 23)
            {
                Console.WriteLine("Invalid input. Please enter a valid hour (0-23):");
            }
            return hour;
        }

        private int GetValidMinute()
        {
            Console.WriteLine("Enter the minute of the test:");
            int minute;
            while (!int.TryParse(Console.ReadLine(), out minute) || minute < 0 || minute > 59)
            {
                Console.WriteLine("Invalid input. Please enter a valid minute (0-59):");
            }
            return minute;
        }

    }
}
