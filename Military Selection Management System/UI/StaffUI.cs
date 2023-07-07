using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;

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
                Console.WriteLine(" 4. to Delete a candidate");
                Console.WriteLine(" 5. to Search a student");
                Console.WriteLine(" 6. to See the complaints by the Students");
                Console.WriteLine(" 7. View the test schedule");
                Console.WriteLine(" 8. Set the test schedule");
                Console.WriteLine(" 9. Allocate a budget");
                option = PersonUI.IntegerValidation();
            }while(option > 9);

            return option; // This line will only be reached if the option is 12
        }
        public static void StaffScreen(Staff staff)
        {
            int option = StaffMenu();
            if (option == 1)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Add Candidate");
                Person person1 = PersonUI.TakeInputForSignUp("candidate");
                Candidate candidate = new Candidate(person1.getID(),person1.getName(),person1.getPassword(),person1.getaddress(),person1.getAge(),person1.getphoneNumber(),person1.getemailAddress(),"Candidate");
                CandidateDL.AddCandidate(candidate);
            }
            else if (option == 2)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Top Candidates");
                PersonUI.ViewTopCandidates();
                HadbacktoStaffScreen(staff);
            }
            else if (option == 3)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Reports");
                StaffUI.ShowReport();
                HadbacktoStaffScreen(staff);
            }
            else if (option == 4)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Delete Candidate");
                Candidate candidate = PersonUI.TakeInputForIDandName();
                CandidateDL.DeleteCandidate(candidate.getID(),candidate.getName());
                HadbacktoStaffScreen(staff);
            }
            else if (option == 5)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Search Student");
                Candidate candidate = PersonUI.TakeInputForIDandName();
                Candidate candidate1 = CandidateDL.SearchCandidate(candidate.getID(),candidate.getName());
                HadbacktoStaffScreen(staff);
            }
            else if (option == 6)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("View Complains");
                PrintComplain();
                HadbacktoStaffScreen(staff);
            }
            else if (option == 7)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("View Test Schedule");
                TestUI.PrintTestSchedule();
                HadbacktoStaffScreen(staff);
            }
            else if (option == 8)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Setting Test Schedule");
                Console.Write("How many number of test you want to set the schedule for:");
                int numTests = PersonUI.IntegerValidation();
                UpdatingTestSchedule(numTests);
                HadbacktoStaffScreen(staff);
            }
            else if (option == 9)
            {
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("Allocating Budget");
                Staff.AllocateBudget(staff, TakeInputForPassword());
                HadbacktoStaffScreen(staff);
            }
        }
        public static string TakeInputForPassword()
        {
            Console.Write("Enter Your Password for Level 1 access");
            string password = Console.ReadLine();
            return password;
        }
        
        public static void HadbacktoStaffScreen(Person person)
        {
            Console.Clear();
            Staff staff = new Staff(person.getID(), person.getName(), person.getPassword(), person.getaddress(), person.getAge(), person.getphoneNumber(), person.getemailAddress(), "Staff");
            StaffUI.StaffScreen(staff);

        }

        public static void ShowReport()
        {
            Console.WriteLine("Total Registered Candidates: {0}", CandidateDL.candidatesList.Count);
            Console.WriteLine("Name \t\t Age \t Performance");

            foreach (Candidate candidate in CandidateDL.candidatesList)
            {
                Console.WriteLine("{0,-15} {1,-5} {2,-12}", candidate.getName(), candidate.getAge(), candidate.getSelectionStatus());
            }
        }

        public static void UpdatingTestSchedule(int numTests)
        {
            string TestName;
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("Enter the name of test {0} : ", i + 1);
                TestName = Console.ReadLine();
                Test.isTrueTestName(TestName);
                DateTime TimeDate = TakeDateTime();
                Test test = new Test(TestName,TimeDate);
                TestDL.addIntoTestList(test);
            }
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
        public static void ChooseScreen(Person person)
        {
            string role = person.getRole();
            if(role == "Admin" || role == "admin")
            {
                AdminUI.AdminScreen(person);
            }
            else if (role == "Staff" || role == "staff")
            {
                Staff staff = new Staff(person.getID(), person.getName(), person.getPassword());
                StaffUI.StaffScreen(staff);
            }
        }
        public static void PrintComplain()
        {
            foreach(Candidate candidate in CandidateDL.candidatesList)
            {
                if(candidate.getcomplain() != null)
                {
                    Console.WriteLine("{0}: {1}", candidate.getName(),candidate.getcomplain());
                }
            }
        }

    }
}
