using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.Extras;

namespace Military_Selection_Management_System.UI
{
	public class AdminUI
	{
        // Admin Screen
        public static int AdminMenu()
        {
            int option = 10;
            do
            {
                UI.PersonUI.subMenu("AdminScreen");
                Console.WriteLine("0: SignIn/SignUp Screen");
                Console.WriteLine("1: To add Candidate");
                Console.WriteLine("2: to View the top candidates");
                Console.WriteLine("3: to Show a report");
                Console.WriteLine("4: to Delete a candidate");
                Console.WriteLine("5: to Search a student");
                Console.WriteLine("6: to See the complaints by the Students");
                option = UI.PersonUI.IntegerValidation();
            } while (option > 9);
            return option;
        }
        public static void AdminScreen(Person person)
        {
            int adminOption = 12;
            while (true)
            {
                PersonUI.PrintHeader();
                PersonUI.subMenu("Admin");
                adminOption = AdminMenu();
                Console.Clear();
                if (adminOption == 1)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Add Candidate");
                    Person person1 = PersonUI.TakeInputForSignUp("candidate");
                    Candidate candidate = new Candidate(person1.getID(),person1.getName(), person1.getPassword(), person1.getaddress(), person1.getAge(), person1.getphoneNumber(), person1.getemailAddress(), "Candidate");
                    CandidateDL.AddCandidate(candidate);
                    hadBackToAdminScreen(person);


                }
                else if (adminOption == 2)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Top Candidates");
                    PersonUI.ViewTopCandidates();
                    hadBackToAdminScreen(person);
                }
                else if (adminOption == 3)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Report");
                    StaffUI.ShowReport();
                    hadBackToAdminScreen(person);
                }
                else if (adminOption == 4)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Delete Candidate");
                    Candidate candidate = PersonUI.TakeInputForIDandName();
                    CandidateDL.DeleteCandidate(candidate.getID(), candidate.getName());
                    hadBackToAdminScreen(person);
                }
                else if (adminOption == 5)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Search Student");
                    Candidate candidate = PersonUI.TakeInputForIDandName();
                    Candidate candidate1 = CandidateDL.SearchCandidate(candidate.getID(), candidate.getName());
                    hadBackToAdminScreen(person);
                }
                else if (adminOption == 6)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("View Complains");
                    StaffUI.PrintComplain();
                    hadBackToAdminScreen(person);
                }
            }
        }
        public static void hadBackToAdminScreen(Person person)
        {
            Console.Clear();
            AdminUI.AdminScreen(person);
        }

    }
}

