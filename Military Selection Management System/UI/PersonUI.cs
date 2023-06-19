using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;
namespace Military_Selection_Management_System.UI
{
    class PersonUI
    {
        public Person TakeInputSignIn()
        {
            string name;
            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string password;
            password = Console.ReadLine();
            Person p = new Person(name, password);
            return p;
        }
        public Person TakeInputForSignUp(string role)
        {
            string name;
            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();
            name = isAlpha(name);
            string password;
            Console.WriteLine("Enter your Password: ");
            password = Console.ReadLine();
            string emailaddress = ValidEmail();
            Console.WriteLine("Enter your age");
            int age;
            age = IntegerValidation();
            Console.WriteLine("Enter your Phone Number");
            string phoneNumber = Console.ReadLine();
            Double Number = ValidPhoneNumber(phoneNumber);
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            Person p = new Person(name, password,address,age,Number,emailaddress,role);
            return p;
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
        public static string Signup(string name, string phoneNumber, string password, int age, string role, string address)
        {
            string lowerCaseRole = role.ToLower();
            if (lowerCaseRole != "candidate" && lowerCaseRole != "staff" && lowerCaseRole != "admin")
            {
                return "Invalid role";
            }

            if (lowerCaseRole == "admin" && NameAdmin == name && passwordAdmin == password)
            {
                return "Sign in";
            }

            if (lowerCaseRole == "staff" && UserExist(name, password, role))
            {
                return "Sign in";
            }

            if (lowerCaseRole == "candidate" && UserExist(name, password, role))
            {
                return "Sign in";
            }

            if (!isValidPhoneNumber(phoneNumber))
            {
                return "Invalid phone number";
            }

            if (!isValidAge(age))
            {
                return "Invalid age";
            }

            StoreDataBasedOnRole(name, phoneNumber, password, age, role, address, lowerCaseRole);

            return "Success";
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

        public static void ShowReport()
        {
            Console.WriteLine("Total Registered Candidates: {0}", CandidateDL.candidatesList.Count);
            Console.WriteLine("Name \t\t Age \t Performance");

            foreach (Candidate candidate in CandidateDL.candidatesList)
            {
                Console.WriteLine("{0,-15} {1,-5} {2,-12}", candidate.getName(), candidate.getAge(), candidate.getSelectionStatus());
            }
        }


        public static bool isValidAge(int age)
        {
            if (age < 30 && age > 15 && age >= 1)
            {
                return true;
            }
            return false;
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
