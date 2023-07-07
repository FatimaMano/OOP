using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;
using System.Security.Policy;

namespace Military_Selection_Management_System.UI
{
    class PersonUI
    {
        public static Person TakeInputSignIn()
        {
            Console.WriteLine("Enter Your ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();
            Person p = new Person(ID,password);
            return p;
        }
        public static Person TakeInputForSignUp(string role)
        {
            Console.Write("Enter Your ID: ");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            name = isAlpha(name);
            string password;
            Console.WriteLine("Enter your Password: ");
            password = Console.ReadLine();
            string emailaddress = ValidEmail();
            Console.WriteLine("Enter your age");
            int age = IntegerValidation();
            isValidAgeStaff(age);
            Console.WriteLine("Enter your Phone Number");
            string phoneNumber = Console.ReadLine();
            Double Number = ValidPhoneNumber(phoneNumber);
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            Person person = new Person(ID,name, password,address,age, Number, emailaddress,role);
            return person;

        }
        public static Candidate TakeInputForIDandName()
        {
            Console.Write("Enter the ID of the candidate");
            string name = Console.ReadLine();
            Console.Write("Enter the ID of the candidate");
            string ID = Console.ReadLine();
            Candidate candidate = new Candidate(ID, name, null);
            return candidate;
        }

        public static int PersonScreen()
        {
            int option = 4;
            do
            {
                PersonUI.PrintHeader();
                PersonUI.subMenuBeforeMainMenu("Identity");
                Console.WriteLine("1.Are you a Candidate");
                Console.WriteLine("2.Are you a Staff");
                Console.WriteLine("3.Are you a Admin");
                Console.WriteLine("0.Exit");
                option = IntegerValidation();
            }while(option > 3);
            return option;
        }

        public static int LogMenuScreen()
        {
            Console.Clear();
            PersonUI.PrintHeader();
            PersonUI.subMenuBeforeMainMenu("LogScreen");
            int option = 4;
            do
            {
                Console.WriteLine(" 1. Sign in");
                Console.WriteLine(" 2. Sign up");
                Console.WriteLine(" 3. Back");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your option");
                option = PersonUI.IntegerValidation();
                Console.Clear();
            } while (option>3);
            return option;
        }

        public static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("###################################################################################################################################################");
            Console.SetCursorPosition(4, 2);
            Console.WriteLine(" _______  __  __  __  __    ");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("|   |   ||__||  ||__||  |_ .---.-..----..--.--.");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("|       ||  ||  ||  ||   _||  _  ||   _||  |  |");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("|__|_|__||__||__||__||____||___._||__|  |___  |");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("                                        |_____|");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine(" ____         _              _    _");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("/ ___|   ___ | |  ___   ___ | |_ (_)  ___   _ __");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("\\__\\  / _\\| | / _\\ / __|| __|| | / _ \\ | '_ \\");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine(" ___) ||  __/| ||  __/| (__ | |_ | || (_) || | | |");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("|____/ \\___||_|\\___|\\___|\\__||_|\\___/ |_| |_|");
            Console.WriteLine("###################################################################################################################################################");
        }
        public static void subMenuBeforeMainMenu(string submenu)
        {
            string message = submenu + " Menu";
            Console.WriteLine(message);
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
        public static void subMenu(string submenu)
        {
            string message = "Main Menu >" + submenu;
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }

        public static void ViewTopCandidates()
        {
            Console.WriteLine("Total Registered Candidates: {0}", CandidateDL.candidatesList.Count);
            Console.WriteLine("Total Selected Candidates: 10");
            Console.WriteLine("Name \t\t Age \t Performance");

            foreach (Candidate candidate in CandidateDL.TopCandidatesList)
            {
                Console.WriteLine("{0,-15} {1,-5} {2,-12}", candidate.getName(), candidate.getAge(), candidate.getResult());
            }

            Console.ReadLine();
        }



        public static bool isValidAgeCandidate(int age)
        {
            if (age < 30 && age > 15 && age >= 1)
            {
                return true;
            }
            return false;
        }
        public static bool isValidAgeStaff(int age)
        {
            if (age < 60 && age > 15 && age >= 1)
            {
                return true;
            }
            return false;
        }
        public static int CheckAgeCandidate(int age)
        {
            do
            {
                Console.WriteLine("Wrong! \n Enter Again");
                age = IntegerValidation();
            } while (!isValidAgeCandidate(age));
            return age;
        }
        public static int CheckAgeStaff(int age)
        {

            do
            {
                Console.WriteLine("Wrong! \n Enter Again");
                age = IntegerValidation();
            } while (!isValidAgeStaff(age));
            return age;
        }

        public static bool isValidPhoneNumber(string phoneNumber)
        {
            // Check if phone number has the correct length
            if (phoneNumber.Length != 11)
            {
                return false;
            }

            // Check if all characters in the phone number are digits
            foreach (char c in phoneNumber)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            // If all checks passed, the phone number is valid
            return true;
        }
        public static double ValidPhoneNumber(string phoneNumber)
        {
            do {
                Console.WriteLine("Wrong! \n Enter Again");
                phoneNumber = Console.ReadLine();
            } while (!isValidPhoneNumber(phoneNumber));
            return Double.Parse(phoneNumber);
        }

        public static int FindNumberOfDigits(double number)
        {
            int digits = 1;
            while (number / Math.Pow(10, digits) >= 1)
            {
                digits++;
            }
            return digits++;
        }
        public static int IntegerValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Enter integer: ");
            }
            return number;
        }
        public static float FloatValidation()
        {
            float value;
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a valid float value.");
            }
        }

        public static double DoubleValidation()
        {
            double value;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a valid double value.");
            }
        }

        public static string isAlpha(string input)
        {
            int size = input.Length;
            bool isValid = true;

            for (int i = 0; i < size; i++)
            {
                int check = Convert.ToInt32(input[i]);
                if ((check >= 65 && check <= 90) || (check >= 97 && check <= 122) || input[i] == ' ')
                {
                    continue;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid character detected!");
                Console.WriteLine("Enter again: ");
                input = Console.ReadLine();
                return isAlpha(input);
            }
        }

        public static string ValidEmail()
        {
            string email = " ";
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter email address: ");
                email = Console.ReadLine();

                if (email.Length == 0)
                {
                    Console.WriteLine("Email address cannot be empty.");
                }
                else
                {
                    int atIndex = email.IndexOf('@');
                    int dotIndex = email.IndexOf('.');

                    if (atIndex == -1 || dotIndex == -1)
                    {
                        Console.WriteLine("Email address must contain '@' and '.'.");
                    }
                    else if (atIndex > dotIndex)
                    {
                        Console.WriteLine("Invalid email address: '@' must come before '.'.");
                    }
                    else if (dotIndex - atIndex <= 1)
                    {
                        Console.WriteLine("Invalid email address: must have at least one character between '@' and '.'.");
                    }
                    else if (dotIndex == email.Length - 1)
                    {
                        Console.WriteLine("Invalid email address: '.' cannot be the last character.");
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }

            return email;
        }


    }
}
