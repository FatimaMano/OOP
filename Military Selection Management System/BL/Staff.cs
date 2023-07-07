using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.UI;

namespace Military_Selection_Management_System.BL
{
    public class Staff : Person
    {
        private double budget;
        public Staff()
        {

        }
        public Staff(string ID, string name, string password, string address, int age, double phoneNumber, string emailAddress, string role) : base(ID, name, password, address, age, phoneNumber, emailAddress, role)
        {

        }
        public Staff(string ID, string name,string password) : base(ID,name,password)
        {

        }
        public Staff(string ID,string name, string password,string role) : base(ID,name,password,role)
        {

        }
        public Staff(string ID, string password) : base(ID, password)
        {

        }
        public double getBudget()
        {
            return budget;
        }
        public void setBudget(double budget)
        {
            this.budget = budget;
        }
        public static void AllocateBudget(Staff staff, string password)
        {
            if (!IsAuthorizedStaff(staff) && VerifyPassword(password))
            {
                AddToAuthorizedStaff(staff);
                Console.WriteLine("Staff added to authorized list.");
            }

            if (IsAuthorizedStaff(staff))
            {
                if (staff.getBudget() == 0)
                {
                    double budget = GetBudgetFromUser();
                    if (budget != 0)
                    {
                        staff.setBudget(budget);
                        Console.WriteLine("Budget allocated successfully!");
                    }
                }
                else
                {
                    Console.WriteLine("Budget is already allocated and cannot be changed.");
                }
            }
            else
            {
                Console.WriteLine("Unauthorized access. Budget allocation failed.");
            }
        }

        private static bool IsAuthorizedStaff(Staff staff)
        {
            // Check if the staff object is in the list of authorized staff
            List<Staff> authorizedStaff = StaffDL.GetAuthorizedStaffList(); // Retrieve the list of authorized staff
            return authorizedStaff.Contains(staff);
        }

        private static void AddToAuthorizedStaff(Staff staff)
        {
            // Add the staff object to the list of authorized staff
            List<Staff> authorizedStaff = StaffDL.GetAuthorizedStaffList(); // Retrieve the list of authorized staff
            authorizedStaff.Add(staff);
        }

        

        private static double GetBudgetFromUser()
        {
            Console.WriteLine("Enter the budget allocated:");
            return PersonUI.DoubleValidation();
        }

        private static bool VerifyPassword(string password)
        {
            // Compare the provided password with the predefined password
            string predefinedPassword = "YourPassword"; // Replace "YourPassword" with the actual password

            return password == predefinedPassword;
        }



    }
}
