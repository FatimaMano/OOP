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
        public static int StaffMenu()
        {
            int option = 0;
            do
            {
                PersonUI.PrintHeader();
                PersonUI.subMenu("StaffScreen");
                Console.WriteLine(" 0. SignIn/SignUp Screen");
                Console.WriteLine(" 1. To add Candidate");
                Console.WriteLine(" 2. to View the top candidates");
                Console.WriteLine(" 3. to Show a report");
                Console.WriteLine(" 4. to Modify the information of the candidates");
                Console.WriteLine(" 5. to Delete a candidate");
                Console.WriteLine(" 6. to Search a student");
                Console.WriteLine(" 7. to See the complaints by the Students");
                Console.WriteLine(" 8. Set the test schedule");
                Console.WriteLine(" 9. View the test schedule");
                Console.WriteLine(" 10. Update the Test Dates");
                Console.WriteLine(" 11. Allocate a budget");
                option = PersonUI.IntegerValidation();
            }while(option > 11);

            return option; // This line will only be reached if the option is 12
        }
        public static Test UpdatingTestSchedule(int numTests)
        {
            string TestName;
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("Enter the name of test {0} : ", i + 1);
                TestName = Console.ReadLine();
                Test.isTrueTestName(TestName);
                DateTime TimeDate = TakeDateTime();
                Test test = new Test(TimeDate);
                return test;
            }
            return null;
        }
        public static DateTime TakeDateTime()
        {
            int day = GetValidDay();
            int month = GetValidMonth();
            int year = GetValidYear();
            int hour = GetValidHour();
            int minute = GetValidMinute();

            DateTime testDateTime = new DateTime(year, month, day, hour, minute, 0);
            return testDateTime;
        }

        private static int GetValidDay()
        {
            Console.WriteLine("Enter the day of the test:");
            int day;
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Invalid input. Please enter a valid day (1-31):");
            }
            return day;
        }

        private static int GetValidMonth()
        {
            Console.WriteLine("Enter the month of the test:");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid input. Please enter a valid month (1-12):");
            }
            return month;
        }

        private static int GetValidYear()
        {
            Console.WriteLine("Enter the year of the test:");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < DateTime.Now.Year)
            {
                Console.WriteLine("Invalid input. Please enter a valid year:");
            }
            return year;
        }

        private static int GetValidHour()
        {
            Console.WriteLine("Enter the hour of the test:");
            int hour;
            while (!int.TryParse(Console.ReadLine(), out hour) || hour < 0 || hour > 23)
            {
                Console.WriteLine("Invalid input. Please enter a valid hour (0-23):");
            }
            return hour;
        }

        private static int GetValidMinute()
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
