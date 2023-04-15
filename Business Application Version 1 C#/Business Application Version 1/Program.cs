using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace BootingCSharp
{
    class Program
    {
        static string name;
        static string password;
        static string Education;
        static int budget;
        // Test Schedule
        static string[] testNames = new string[15];
        static string[] testDates = new string[15];
        static string[] testTimes = new string[15];
        // Admin
        static string NameAdmin;
        static string passwordAdmin;
        static string addressAdmin;
        static int ageAdmin;
        static string phoneNumberAdmin;
        static string emailAddressAdmin;
        static string roleAdmin;
        // User
        static string[] namesCandidates = new string[200];
        static string[] passwordsCandidates = new string[200];
        static string[] AddressesCandidates = new string[200];
        static int[] agesCandidates = new int[200];
        static string[] phoneNumbersCandidates = new string[200];
        static string[] emailAddressCandidates = new string[200];
        static string[] rolesCandidates = new string[200];
        static string[] Allergies = new string[200];
        static string[] Treatments = new string[200];
        static string[] complain = new string[200] { " " };
        static string[] ages = new string[200];
        static int countUsers = 0;
        static int countStaff = 0;
        static string[] roles = new string[200];
        static int[] number = new int[200];
        static float[] MatricMarks = new float[200];
        static float[] InterMarksPart = new float[200];
        static float[] CGPA = new float[200];
        static int[] IntelligenceTest = new int[200];
        static int[] AcademicTest = new int[200];
        static int Max_Candidates = 200;
        static int Max_details = 5;
        static string[] SelectionStatus = new string[200];
        static string[] TopCandidatesName = new string[10];
        static string[] TopCandidatesAge = new string[10];
        static string[] TopCandidatesResult = new string[10];
        static int [,] PhysicalTest = new int[6][200];
        static string[] TestNames = { "Running", "Sit ups", "Push Ups", "logmenuChin ups", "Ditch Crossing" };
        static int[] Height[200];
        static int[] Weight[200];
        static void Main(string[] args)
        {
            /*
            HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            int color = rand() % 15 + 1;
            SetConsoleTextAttribute(hConsole, color);
            */
            // Loading Data In Files
            LoadDataFromAdminFile();
            int option = 4;
            Console.Clear();
            while (option != 0)
            {
                option = LogMenuScreen();
                if (option == 1)
                {
                    PrintHeader();
                    string role;
                    subMenuBeforeMainMenu("SignIn");
                    Console.WriteLine("Enter username");
                    name = isAlpha(name);
                    Console.WriteLine("Enter password");
                    password = Console.Readline();
                    Console.WriteLine("Enter your Role(Admin / Staff / Candidate");
                    role = isAlpha(role);
                    string check = Signin(name, password, role);

                    if (check == role)
                    {
                        Console.WriteLine("Sign in successfully");
                        Console.WriteLine("Press any key to continue");
                        Console.Read();
                        int idx = SearchString(name, role);
                        DecideMenu(role, idx);
                    }
                    else
                    {
                        Console.WriteLine( "User Not exist");
                        Console.WriteLine( "Sign up");
                        Console.Readkey();
                    }
                }
                if (option == 2)
                {
                    PrintHeader();
                    // Variables Decleration
                    string role, address, email;
                    int age;
                    string phoneNumber;

                    // Input Number
                    subMenuBeforeMainMenu("Signup");
                    Console.WriteLine("Enter username");
                    name = isAlpha(name);
                    Console.WriteLine("Enter your Role(Admin / Staff / Candidate");
                    role = isAlpha(role);
                    ValidEmail();
                    Console.WriteLine("Create a new password");
                    password = Console.ReadLine();
                    Console.WriteLine("Enter your age");
                    age = integerValidation();
                    Console.WriteLine("Enter your Phone Number");
                    phoneNumber = Console.ReadLine();
                    string check;
                    check = Signup(name, phoneNumber, password, age, role, address);

                    if (check == "Success")
                    {
                        int idx;
                        Console.WriteLine( "Sign up successfully");
                        Console.ReadKey();
                        idx = SearchString(name, role);
                        DecideMenu(role, idx);
                    }
                    else
                    {
                        Console.WriteLine(check);
                        Console.ReadKey();
                    }
                }
            }

        }
        // Log Screen
        static int LogMenuScreen()
        {
            system("cls");
            PrintHeader();
            subMenuBeforeMainMenu("LogScreen");
            int option = 0;
            string check = " ";
            bool checkInput = false;
            while (checkInput == false)
            {
                Console.WriteLine("1.Sign in");
                Console.WriteLine("2.Sign up");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter your option");
                check = Console.ReadLine();
                checkInput = validateInput(check);
                if (checkInput == true)
                {
                    option = int.Parse(check);
                }
                Console.Clear();
            }
            return option;
        }
        static string Signin(string username, string password, string role)
        {
            if (UserExist(name, password, role))
            {
                return role;
            }
            return "User Not Found";
        }
        static string Signup(string name, string phoneNumber, string password, int age, string role, string address)
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

        static bool UserExist(string name, string password, string role)
        {
            bool flag = false;
            if (role == "Candidate")
            {
                for (int idx = 0; idx < countUsers; idx++)
                {
                    if (namesCandidates[idx] == name && passwordsCandidates[idx] == password)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else if (role == "Admin")
            {
                if (NameAdmin == name && passwordAdmin == password)
                {
                    flag = true;
                }
            }
            else if (role == "Staff")
            {
                if (NameStaff == name && passwordStaff == password)
                {
                    flag = true;
                }
            }
            return flag;
        }





        static bool isValidAge(int age)
        {
            if (age < 30 && age > 15 && age >= 1)
            {
                return true;
            }
            return false;
        }
        static bool isValidPhoneNumber(string phoneNumber)
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


        int FindNumberOfDigits(double number)
        {
            int digits = 1;
            while (number / Math.Pow(10, digits) >= 1)
            {
                digits++;
            }
            return digits++;
        }

        static int adminMenu()
        {

            int option;
            string check = " ";
            bool condition = false;
            while (!condition)
            {
                subMenu("AdminScreen");
                Console.WriteLine("1: To add Candidate");
                Console.WriteLine("2: to View the top candidates");
                Console.WriteLine("3: to Show a report");
                Console.WriteLine("4: to Modify the information of the candidates");
                Console.WriteLine("5: to Delete a candidate");
                Console.WriteLine("6: to Search a student");
                Console.WriteLine("7: to Update the test results of a student");
                Console.WriteLine("8: to See the complaints by the Students");
                Console.WriteLine("9: Set the test schedule");
                check = Console.ReadLine();
                bool checkInput = validateInput(check);
                if (checkInput == true)
                {
                    option = int.Parse(check);
                    condition = true;
                }
                return option;
            }
        }

        static void subMenuBeforeMainMenu(string submenu)
        {
            string message = submenu + " Menu";
            Console.WriteLine(message);
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
        static void subMenu(string submenu)
        {
            string message = "Main Menu >" + submenu;
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
        // Candidate Functions
        static void addCandidate(int idx)
        {
            Console.WriteLine("Enter name");
            namesCandidates[idx] = isAlpha(namesCandidates[idx]);
            Console.WriteLine("Create password");
            passwordsCandidates[idx] = Console.ReadLine();
            Console.WriteLine("Add his Academic score");
            AcademicTest[idx] = integerValidation();
            Console.WriteLine("Add his Intelligence Test");
            IntelligenceTest[idx] = integerValidation();
            StoreDataInOutputMode("Candidate");
        }
        static void ViewTopCandidates()
        {
            Console.WriteLine("Total Registered Candidates \t {0}", countUsers);
            Console.WriteLine("Total Selected Candidates are 10" );
            Console.WriteLine("Name \t  Age\t  Performance\t  ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t", TopCandidatesName[i], TopCandidatesAge[i],TopCandidatesResult[i]);
            }
            getch();
        }
        static void ShowReport()
        {
            Console.WriteLine("Total Registered Candidates \t {0}", countUsers);
            Console.WriteLine("Name \t Age\t Performance\\t");
            for (int idx = 0; idx < countUsers; idx++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t", namesCandidates[idx],agesCandidates[idx], SelectionStatus[idx]);
            }
        }
        static void UpdateTheInfomationOfCandidateByAdmin()
        {
            Console.WriteLine("Enter the  name of the student that you want to modify");
            name = isAlpha(name);
            int idx = SearchString(name, "Candidate");
            addCandidate(idx);
        }
        static void SearchStudent(string name)
        {

            int idx = SearchString(name, "Candidate");
            Console.WriteLine("{0} \t {1} \t {2}",namesCandidates[idx],agesCandidates[idx],SelectionStatus[idx]);
        }
        static void deleteCandidate(string name)
        {
            int index = -1;
            for (int i = 0; i < countUsers; i++)
            {
                if (namesCandidates[i] == name)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Candidate not found.");
                return;
            }

            for (int i = index; i < countUsers - 1; i++)
            {
                namesCandidates[i] = namesCandidates[i + 1];
                roles[i] = roles[i + 1];
                passwordsCandidates[i] = passwordsCandidates[i + 1];
                agesCandidates[i] = agesCandidates[i + 1];
                phoneNumbersCandidates[i] = phoneNumbersCandidates[i + 1];
                AddressesCandidates[i] = AddressesCandidates[i + 1];
                emailAddressCandidates[i] = emailAddressCandidates[i + 1];
                MatricMarks[i] = MatricMarks[i + 1];
                InterMarksPart[i] = InterMarksPart[i + 1];
                Treatments[i] = Treatments[i + 1];
                AcademicTest[i] = AcademicTest[i + 1];
                complain[i] = complain[i + 1];

                StoreDataInOutputMode("Candidate");
            }

            countUsers--;
            Console.WriteLine("Candidate information deleted.");
            Console.WriteLine("Press any Key to continue");
            Console.Readkey();
        }
        static void PrintComplain()
        {
            clearScreen();

            for (int idx = 0; idx < countUsers; idx++)
            {
                Console.WriteLine("{0} \t {1}\t",namesCandidates[idx],complain[idx]);
            }
        }
        static void PrintTestSchedule(int numTests)
        {
            Console.WriteLine("\nTest Schedule:\n");
            Console.WriteLine("--------------------------\n");
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("{0} on {1}  at  \n",testNames[i],testDates[i],testTimes[i]);
            }
        }
        static void UpdatingTestSchedule(int numTests)
        {
            for (int i = 0; i < numTests; i++)
            {
                Console.Writeline("Enter the name of test {0} : ",i + 1);
                testNames[i] = Console.ReadLine();
                Console.ReadLine("Enter the date of test {0}  (dd/mm/yyyy): ",i + 1);
                testDates[i] =  Console.ReadLine();
                Console.WriteLine("Enter the time of test {0} (hh:mm): ",i + 1);
                testTimes[i] = Console.ReadLine();
            }
        }
        static void AddPhysicalFitnessTest(int idx)
        {
            for (int i = 0; i < 5; i++)
            {
                PhysicalTest[i][idx] = int.Parse(Console.ReadLine);
            }
            clearScreen();
        }
        static void SettingTestSchedule(int idx, string role)
        {
            int numTests;
            Console.WriteLine("How many tests do you want to schedule? ") ;
            numTests = IntegerValidation();
            UpdatingTestSchedule(numTests);
            PrintTestSchedule(numTests);
            if (role == "Admin")
            {
                AdminScreen(idx);
            }
            else if (role == "Staff")
            {
                StaffScreen(idx);
            }
        }
        ///Validations
        string isAlpha(string input)
        {
            int size;
            int check;
            bool flap;
            while (true)
            {
                size = input.Length;
                for (int i = 0; i < size; i++)
                {
                    check = Convert.ToInt32(input[i]);
                    if ((check >= 65 && check <= 90) || (check >= 97 && check <= 122) || input[i] == ' ')
                    {
                        flap = true;
                    }
                    else
                    {
                        flap = false;
                        break;
                    }
                }
                if (flap == true)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Wrong Charater...");
                    Console.WriteLine("Enter Again: ");
                    input = Console.ReadLine();
                }
            }
        }

        static int IntegerValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Enter integer: ");
            }
            return number;
        }

        static bool validateInput(string option)
        {
            bool flag = false;
            if (option == "1" || option == "2" || option == "3" || option == "4" || option == "5" || option == "6" || option == "7" || option == "8" || option == "9")
            {
                flag = true;
            }
            return flag;
        }
        //File Handling
        static void StoreDataInOutputMode()
        {
                string path = "C:\\Users\\HP\\source\\repos\\Business Application Version 1\\File Storage\\Admin.txt";
                StreamWriter file = new StreamWriter();
                file.Write(NameAdmin + "," + role + "," + passwordAdmin + "," + ageAdmin + "," + phoneNumberAdmin + "," + addressAdmin);
                file.Flush();
                file.Close();
        }
        static void storeAdminFile(string name, string phoneNumber, string password, int age, string role)
        {
            StoreNextRecord("Admin");
            string path = "Admin.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.Write(name + "," + role + "," + password + "," + age + "," + phoneNumber);
            file.Flush();
            file.Close();
            NameAdmin = name;
            roleAdmin = role;
            passwordAdmin = password;
            ageAdmin = age;
            phoneNumberAdmin = phoneNumber;
        }

        void StoreNextRecord(string filename)
        { 

            StreamWriter file = new StreamWriter(path, true);
            if (filename == "CandidateData")
            {
                string path = "C:\\Users\\HP\\source\\repos\\Business Application Version 1\\File Storage\\CandidateData.txt";
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine();
            }
            else if (filename == "Admin")
            {
                string path = "C:\\Users\\HP\\source\\repos\\Business Application Version 1\\File Storage\\Admin.txt";
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine();
            }
/*
            else if (filename == "EmployeesData")
            {
                file.open("EmployeesData.txt", ios::app);
                file << endl;
                file.close();
            }
            */


        }
        static void LoadDataFromAdminFile()
        {
            string path = @"D:\PF github\Management Group\Admin.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                NameAdmin = getField(line, 1);
                roleAdmin = getField(line, 2);
                passwordAdmin = getField(line, 3);
                if (getField(line, 4) == " ")
                {
                    ageAdmin = -1;
                }
                else
                {
                    ageAdmin = int.Parse(getField(line, 4));
                }
                phoneNumberAdmin = getField(line, 5);
                addressAdmin = getField(line, 6);
            }
        }

        static string getField(string line, int index)
        {
            string[] fields = line.Split(',');
            if (fields.Length >= index)
            {
                return fields[index - 1];
            }
            else
            {
                return "";
            }
        }

        // Supported Functions
        static void PrintHeader()
        {
            Console.Clear();
            ///HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            ///int color = rand() % 15 + 1;
            ///SetConsoleTextAttribute(hConsole, color);
            Console.WriteLine("###################################################################################################################################################");
            gotoxy(4, 2);
            Console.WriteLine(" _______  __  __  __  __    ");
            gotoxy(4, 3);
             "|   |   ||__||  ||__||  |_ .---.-..----..--.--. " << endl;
            gotoxy(4, 4);
            cout << "|       ||  ||  ||  ||   _||  _  ||   _||  |  | " << endl;
            gotoxy(4, 5);
            cout << "|__|_|__||__||__||__||____||___._||__|  |___  | " << endl;
            gotoxy(4, 6);
            cout << "                                        |_____| " << endl;
            gotoxy(4, 7);
            cout << " ____         _              _    _    " << endl;
            gotoxy(4, 8);
            cout << "/ ___|   ___ | |  ___   ___ | |_ (_)  ___   _ __  " << endl;
            gotoxy(4, 9);
            cout << "\\__\\  / _\\| | / _\\ / __|| __|| | / _ \\ | '_ \\ " << endl;
            gotoxy(4, 10);
            cout << " ___) ||  __/| ||  __/| (__ | |_ | || (_) || | | |" << endl;
            gotoxy(4, 11);
            cout << "|____/ \\___||_|\\___|\\___|\\__||_|\\___/ |_| |_|" << endl;
            cout << "###################################################################################################################################################" << endl;
        }
        static int SearchString(string name, string role)
        {
            int idx = -1;
            if (role == "Candidate")
            {
                for (int i = 0; i < countUsers; i++)
                {
                    if (namesCandidates[i] == name)
                    {
                        idx = i;
                        break;
                    }
                }
            }
            else if (role == "Staff")
            {
                for (int i = 0; i < countStaff; i++)
                {
                    if (namesStaff[i] == name)
                    {
                        idx = i;
                        break;
                    }
                }
            }
            return idx;
        }

    }
}