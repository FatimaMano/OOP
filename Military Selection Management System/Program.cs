using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.UI;

namespace Military_Selection_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            int color = rand() % 15 + 1;
            SetConsoleTextAttribute(hConsole, color);
            */
            // Loading Data In Files
            PersonDL.LoadFromEmployeesFile(@"C:\Users\HP\source\repos\Military Selection Management System\File Storage\EmployeesData.txt");
            CandidateDL.LoadFromCandidateFile(@"C:\Users\HP\source\repos\Military Selection Management System\File Storage\CandidateData.txt");
            int option = 4;
            while (option != 0)
            {
                option = PersonUI.PersonScreen();
                if (option == 1)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Candidate");
                    PersonUI.subMenu("SignUp/SignIn Screen");
                    int choice = PersonUI.LogMenuScreen();
                    if (choice == 1)
                    {
                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputSignIn();

                        Candidate candidate = new Candidate(person.getID(), person.getPassword());



                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputForSignUp("Candidate");


                    }
                }
                if (option == 2)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Staff");
                    PersonUI.subMenu("SignUp/SignIn Screen");
                    int choice = PersonUI.LogMenuScreen();
                    if (choice == 1)
                    {

                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputSignIn();
                        if(Person.SignIn(person))
                        {
                            Candidate candidate2 = CandidateDL.CreateCandidateObject(person, Extras.Options.SignIn);
                            CandidateUI.CandidateScreen(candidate2);

                        }

                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputForSignUp("Staff");
                        string check = Person.Signup(person.getID(), person.getName(), person.getPassword(), person.getphoneNumber(), person.getAge(), person.getRole(), person.getaddress(), person.getemailAddress());
                        if (check == "SignIn")
                        {
                            Console.Clear();
                            PersonUI.PrintHeader();
                            Person person1 = PersonUI.TakeInputSignIn();
                        }
                        else if (check == "Success")
                        {
                            Console.Clear();
                            PersonUI.PrintHeader();
                            PersonUI.subMenu("Staff Screen");
                            Staff staff = new Staff(person.getID(), person.getName(), person.getPassword());
                            StaffUI.StaffScreen(staff);

                        }
                    }

                }
                if (option == 3)
                {
                    Console.Clear();
                    PersonUI.PrintHeader();
                    PersonUI.subMenu("Admin");
                    PersonUI.subMenu("SignUp/SignIn Screen");
                    int choice = PersonUI.LogMenuScreen();
                    if (choice == 1)
                    {

                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputSignIn();

                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        PersonUI.PrintHeader();
                        Person person = PersonUI.TakeInputForSignUp("Admin");
                        string check = Person.Signup(person.getID(), person.getName(), person.getPassword(), person.getphoneNumber(), person.getAge(), person.getRole(), person.getaddress(), person.getemailAddress());
                        if (check == "SignIn")
                        {
                            Console.Clear();
                            PersonUI.PrintHeader();
                            Person person2 = PersonUI.TakeInputSignIn();
                            AdminUI.AdminScreen(person2);
                        }
                        else if (check == "Success")
                        {
                            Console.Clear();
                            PersonUI.PrintHeader();
                            PersonUI.subMenu("Admin Screen");
                            AdminUI.AdminScreen(person);

                        }
                    }

                }
            }

        }

    }
}

