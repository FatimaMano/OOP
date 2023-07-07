using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.Extras;

namespace Military_Selection_Management_System.UI
{
    class CandidateUI
    {
        public static int UserMenu()
        {
            // We have Entered into the User Menu
            int option = 12;
            /*HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            int color = rand() % 15 + 1;
            SetConsoleTextAttribute(hConsole, color);*/
            do
            {
                PersonUI.PrintHeader();
                PersonUI.subMenu("CandidateScreen");
                // The User can select his desired option from here
                Console.WriteLine("Candidate");
                Console.WriteLine("1..Update Password" );
                Console.WriteLine("2.Enter Educational Details");
                Console.WriteLine("3.Enter Register Complain");
                Console.WriteLine("4.Registered Candidates");
                Console.WriteLine("5.To check Status");
                Console.WriteLine("6.Top Candidates");
                Console.WriteLine("7.To see Eligibility Criteria");
                Console.WriteLine("8.To view Test Schedule");
                Console.WriteLine("9.Log Screen");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your option: ");
                option = PersonUI.IntegerValidation();
            }while(option  >8);
            return option;

        }

        public static void CandidateScreen(Candidate candidate)
        {
            int option = 15;
            Console.Clear();
            while (true)
            {
                option = UserMenu();
                if (option == 1)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Change Password");
                    ChangePassword(candidate);
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Add Education Details");
                    TakeEducationalDetails(candidate);
                }
                else if (option == 3)
                {
                    // Register a Complain
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Register Complain");
                    RegisterComplain(candidate);
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Registered Candidates");
                    PrintRegisteredCandidates(candidate);
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 5)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Selection Status");
                    ViewSelectionStatus(candidate);
                    HeadBackToCandidateScreen(candidate); 
                }
                else if (option == 6)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Top Candidates");
                    ViewTopCandidates();
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 7)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Eligibility Criteria");
                    PrintingCriteria(candidate);
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 8)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Test Schedule");
                    TestUI.PrintTestSchedule();
                    HeadBackToCandidateScreen(candidate);
                }
                else if (option == 9)
                {
                    PersonUI.LogMenuScreen();
                }
            }
        }

        public static void PrintRegisteredCandidates(Candidate candidate)
        {
            Console.WriteLine("Total Candidates Are: {0}", CandidateDL.candidatesList.Count);
            Console.ReadKey();
            Console.Clear();
            CandidateUI.CandidateScreen(candidate);

        }

        public static void ChangePassword(Candidate candidate)
        {
            string temppassword;
            do
            {

                Console.WriteLine("Enter previous password!");
                temppassword = Console.ReadLine();
                Console.Clear();
                PersonUI.PrintHeader();
                PersonUI.subMenu("CandidateScreen");
            } while (!CheckPassword(candidate, temppassword));
            candidate.setPassword(temppassword);
        }
        public static bool CheckPassword(Candidate candidate, string temppassword)
        {
            if (candidate.getPassword() == temppassword)
            {
                return true;
            }
            Console.WriteLine("Wrong Password");
            return false;
        }
        public static void PrintingCriteria(Candidate candidate)
        {
            Console.WriteLine("Eligibility Criteria");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-20} {5,-20} {6,-25} {7,-15}",
                "InterMarks", "Matric Marks", "CGPA", "AcademicTest", "Intelligence Test",
                "Physical Fitness", "TotalSelectedCandidates", "ApprovalByStaff");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-20} {5,-20} {6,-25} {7,-15}",
                "above 60%", "above 50%", "above 3.0", "above 50%", "above 7");
            Console.ReadKey();
            Console.Clear();
            CandidateUI.CandidateScreen(candidate);
        }
        public static void TakeInputForAcademicScores(Candidate candidate)
        {
            Console.WriteLine("Enter the Academic scores");
            int AcademicTest = PersonUI.IntegerValidation();
            candidate.setAcademicTest(AcademicTest);
            Console.WriteLine("Enter the Intelligence Test Scores");
            int IntelligenceTest = PersonUI.IntegerValidation();
        }
        public static void RegisterComplain(Candidate candidate)
        {
            Console.WriteLine("Enter your Complain");
            string complain = Console.ReadLine();
            candidate.setComplain(complain);
        }
        public static void ViewSelectionStatus(Candidate candidate)
        {
            Console.WriteLine("{0}: {1} ", candidate.getName(), candidate.getSelectionStatus());
            Console.ReadKey();
            Console.Clear();
            CandidateUI.CandidateScreen(candidate);
        }
        public static void ViewTopCandidates()
        {
            foreach (Candidate candidate1 in CandidateDL.TopCandidatesList)
            {
                Console.WriteLine("{0}: {1}", candidate1.getName(), candidate1.getResult());
            }
            Console.ReadKey();
        }
        public static void TakeEducationalDetails(Candidate candidate)
        {
            string EducationalStatus = TakeInputForEducationalStatus(candidate);
            string lowercaseEducationalStatus = EducationalStatus.ToLower();
            if(lowercaseEducationalStatus == "matric")
            {
                TakeInputMatricMarks(candidate);
                TakeInputForAcademicScores(candidate);


            }
            else if(lowercaseEducationalStatus == "inter")
            {
                TakeInputMatricMarks(candidate);
                TakeInputInterMarks(candidate);
                TakeInputForAcademicScores(candidate);
            }
            else if(lowercaseEducationalStatus == "BS")
            {
                TakeInputMatricMarks(candidate);
                TakeInputInterMarks(candidate);
                TakeInputForCGPA(candidate);
                TakeInputForAcademicScores(candidate);
            }
        }
        public static void TakeInputInterMarks(Candidate candidate)
        {
            Console.WriteLine("Enter InterMarks: ");
            float InterMarks = PersonUI.FloatValidation();
            candidate.setInterMarksPart(InterMarks);
        }
        public static void TakeInputMatricMarks(Candidate candidate)
        {
            Console.Write("Enter InterMarks: ");
            float MatricMarks = PersonUI.FloatValidation();
            candidate.setMatricMarks(MatricMarks);
        }
        public static string TakeInputForEducationalStatus(Candidate candidate)
        {
            Console.Write("Enter Your Educational Status");
            string EducationalStatus = Console.ReadLine();
            candidate.SetEducationalStatus(EducationalStatus);
            return EducationalStatus;

        }
        public static void TakeInputForCGPA(Candidate candidate)
        {
            Console.Write("Enter Your CGPA: ");
            float CGPA = PersonUI.FloatValidation();
            CGPA = CGPAValidation(CGPA);
            candidate.setCGPA(CGPA);
        }
        public static float CGPAValidation(float CGPA)
        {
            while (true)
            {
                if (CGPA >= 0 && CGPA <= 4)
                {
                    return CGPA;
                }
                Console.WriteLine("Invalid CGPA. Please enter a value between 0 and 4.");
                Console.Write("Enter CGPA: ");
                CGPA = PersonUI.FloatValidation();
            }
        }
        
        public static string TakeInputForID()
        {
            Console.Write("Enter your ID: ");
            string ID = Console.ReadLine();
            return ID;
        }

        public static void HeadBackToCandidateScreen(Candidate candidate)
        {
            Console.Clear();
            CandidateUI.CandidateScreen(candidate);
        }



    }
}
