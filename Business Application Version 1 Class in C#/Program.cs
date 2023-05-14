using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Data;

namespace BootingCSharp
{
    class Program
    {
        static string name = " ";
        static string password = " ";
        static string Education = " ";
        static int budget;
        // Test Schedule
        static string[] testNames = new string[15];
        static string[] testDates = new string[15];
        static string[] testTimes = new string[15];
        // Admin
        static string NameAdmin = " ";
        static string passwordAdmin = " ";
        static string addressAdmin = " ";
        static int ageAdmin;
        static string phoneNumberAdmin = " ";
        static string emailAddressAdmin = " ";
        static string roleAdmin = " ";
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
        static string[] complain = new string[200];
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
        static int[,] PhysicalTest = new int[6, 200];
        static string[] TestNames = { "Running", "Sit ups", "Push Ups", "logmenuChin ups", "Ditch Crossing" };
        static int[] Height = new int[200];
        static int[] Weight = new int[200];
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
                    string name = Console.ReadLine();
                    name = isAlpha(name);
                    Console.WriteLine("Enter password");
                    password = Console.ReadLine();
                    Console.WriteLine("Enter your Role(Admin / Staff / Candidate");
                    role = Console.ReadLine();
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
                        Console.WriteLine("User Not exist");
                        Console.WriteLine("Sign up");
                        Console.Read();
                    }
                }
                if (option == 2)
                {
                    PrintHeader();
                    // Variables Decleration
                    string role, address = " ", email;
                    int age;
                    string phoneNumber;

                    // Input Number
                    subMenuBeforeMainMenu("Signup");
                    Console.WriteLine("Enter username");
                    name = isAlpha(name);
                    Console.WriteLine("Enter your Role(Admin / Staff / Candidate");
                    role = Console.ReadLine();
                    role = isAlpha(role);
                    ValidEmail();
                    Console.WriteLine("Create a new password");
                    password = Console.ReadLine();
                    Console.WriteLine("Enter your age");
                    age = IntegerValidation();
                    Console.WriteLine("Enter your Phone Number");
                    phoneNumber = Console.ReadLine();
                    string check;
                    check = Signup(name, phoneNumber, password, age, role, address);

                    if (check == "Success")
                    {
                        int idx;
                        Console.WriteLine("Sign up successfully");
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
            Console.Clear();
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
            /*
            else if (role == "Staff")
            {
                if (NameStaff == name && passwordStaff == password)
                {
                    flag = true;
                }
            }
            */
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
        // Admin Screen
        static int AdminMenu()
        {

            int option = 0;
            string check = " ";
            bool condition = false;
            while (!condition)
            {
                subMenu("AdminScreen");
                Console.WriteLine("1: To add Candidate");
                Console.WriteLine("2: to Viestatic int adminMenu()\r\n{\r\n    int option = 0;\r\n    string check = \" \";\r\n    bool condition = false;\r\n    while (!condition)\r\n    {\r\n        subMenu(\"AdminScreen\");\r\n        Console.WriteLine(\"1: To add Candidate\");\r\n        Console.WriteLine(\"2: to View the top candidates\");\r\n        Console.WriteLine(\"3: to Show a report\");\r\n        Console.WriteLine(\"4: to Modify the information of the candidates\");\r\n        Console.WriteLine(\"5: to Delete a candidate\");\r\n        Console.WriteLine(\"6: to Search a student\");\r\n        Console.WriteLine(\"7: to Update the test results of a student\");\r\n        Console.WriteLine(\"8: to See the complaints by the Students\");\r\n        Console.WriteLine(\"9: Set the test schedule\");\r\n        check = Console.ReadLine();\r\n        bool checkInput = int.TryParse(check, out option);\r\n        if (checkInput)\r\n        {\r\n            condition = true;\r\n        }\r\n    }\r\n    return option;\r\n}\r\nw the top candidates");
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
            return 0;
        }
        static void AdminScreen(int idx)
        {
            int adminOption = 0;
            while (adminOption != 10)
            {
                PrintHeader();
                subMenu("Admin");
                adminOption = AdminMenu();
                Console.Clear();
                if (adminOption == 1)
                {
                    Console.Clear();
                    PrintHeader();
                    addCandidate(countUsers);
                    AdminMenu();
                }
                else if (adminOption == 2)
                {
                    Console.Clear();
                    PrintHeader();
                    ViewTopCandidates();
                }
                else if (adminOption == 3)
                {
                    Console.Clear();
                    PrintHeader();
                    ShowReport();
                }
                else if (adminOption == 4)
                {
                    Console.Clear();
                    PrintHeader();
                    UpdateTheInfomationOfCandidateByAdmin();
                }
                else if (adminOption == 5)
                {
                    Console.Clear();
                    PrintHeader();
                    Console.WriteLine("Enter the name of the candidate you want to delete");
                    string name = Console.ReadLine();
                    deleteCandidate(name);
                }
                else if (adminOption == 6)
                {
                    Console.Clear();
                    PrintHeader();
                    Console.WriteLine("Enter the name of the student");
                    string name = Console.ReadLine();
                    SearchStudent(name);
                }
                else if (adminOption == 7)
                {
                    Console.Clear();
                    PrintHeader();
                    Console.WriteLine("Enter the name of the Student");
                    string name = Console.ReadLine();
                    name = isAlpha(name);
                    int indx = SearchString(name, "Candidate");
                    AddPhysicalFitnessTest(indx);
                }
                else if (adminOption == 8)
                {
                    Console.Clear();
                    PrintHeader();
                    PrintComplain();
                }
                else if (adminOption == 9)
                {
                    Console.Clear();
                    PrintHeader();
                    SettingTestSchedule(0, "Admin");
                }
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
        static void DecideMenu(string role, int idx)
        {
            AdminScreen(idx);
            // Here we are going to decide which menu to open
            /*
            if (role == "Admin")
            {
                AdminScreen(idx);
            }
            else if (role == "Candidate")
            {
                CandidateScreen(idx);
            }
            else if (role == "Staff")
            {
                StaffScreen(idx);
            }
            */
        }
        // Candidate Functions
        static void addCandidate(int idx)
        {
            Console.WriteLine("Enter name");
            namesCandidates[idx] = isAlpha(namesCandidates[idx]);
            Console.WriteLine("Create password");
            passwordsCandidates[idx] = Console.ReadLine();
            Console.WriteLine("Add his Academic score");
            AcademicTest[idx] = IntegerValidation();
            Console.WriteLine("Add his Intelligence Test");
            IntelligenceTest[idx] = IntegerValidation();
            StoreDataInOutputMode("Candidate");
        }
        static void ViewTopCandidates()
        {
            Console.WriteLine("Total Registered Candidates \t {0}", countUsers);
            Console.WriteLine("Total Selected Candidates are 10");
            Console.WriteLine("Name \t  Age\t  Performance\t  ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t", TopCandidatesName[i], TopCandidatesAge[i], TopCandidatesResult[i]);
            }
            Console.Read();
        }
        static void ShowReport()
        {
            Console.WriteLine("Total Registered Candidates \t {0}", countUsers);
            Console.WriteLine("Name \t Age\t Performance\\t");
            for (int idx = 0; idx < countUsers; idx++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t", namesCandidates[idx], agesCandidates[idx], SelectionStatus[idx]);
            }
        }
        static void UpdateTheInfomationOfCandidateByAdmin()
        {
            Console.WriteLine("Enter the  name of the student that you want to modify");
            name = Console.ReadLine();
            name = isAlpha(name);
            int idx = SearchString(name, "Candidate");
            addCandidate(idx);
        }
        static void SearchStudent(string name)
        {

            int idx = SearchString(name, "Candidate");
            Console.WriteLine("{0} \t {1} \t {2}", namesCandidates[idx], agesCandidates[idx], SelectionStatus[idx]);
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
            Console.Read();
        }
        static void clearScreen()
        {
            // It will clear the screen
            Console.Write("Press any key to continue");
            Console.Read();
            Console.Clear();
        }
        static void PrintComplain()
        {
            clearScreen();

            for (int idx = 0; idx < countUsers; idx++)
            {
                Console.WriteLine("{0} \t {1}\t", namesCandidates[idx], complain[idx]);
            }
        }
        static void PrintTestSchedule(int numTests)
        {
            Console.WriteLine("\nTest Schedule:\n");
            Console.WriteLine("--------------------------\n");
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("{0} on {1}  at  \n", testNames[i], testDates[i], testTimes[i]);
            }
        }
        static void UpdatingTestSchedule(int numTests)
        {
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine("Enter the name of test {0} : ", i + 1);
                testNames[i] = Console.ReadLine();
                Console.WriteLine("Enter the date of test {0}  (dd/mm/yyyy): ", i + 1);
                testDates[i] = Console.ReadLine();
                Console.WriteLine("Enter the time of test {0} (hh:mm): ", i + 1);
                testTimes[i] = Console.ReadLine();
            }
        }
        static void AddPhysicalFitnessTest(int idx)
        {
            for (int i = 0; i < 5; i++)
            {
                PhysicalTest[i, idx] = IntegerValidation();
            }
            Console.Clear();
        }
        static void SettingTestSchedule(int idx, string role)
        {
            int numTests;
            Console.WriteLine("How many tests do you want to schedule? ");
            numTests = IntegerValidation();
            UpdatingTestSchedule(numTests);
            PrintTestSchedule(numTests);
            if (role == "Admin")
            {
                AdminScreen(idx);
            }
            /*
            else if (role == "Staff")
            {
                StaffScreen(idx);
            }
            */
        }
        ///Validations
        static string isAlpha(string input)
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
        static string ValidEmail()
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
        //File Handling
        static void StoreDataInOutputMode(string role)
        {
            if (role == "Candidate")
            {
                string path = "C:\\Users\\HP\\source\\repos\\Business Application Version 1 C#\\File Storage\\CandidateData.txt";
                StreamWriter file = new StreamWriter(path, true);

                for (int idx = 0; idx < countUsers; idx++)
                {
                    if (namesCandidates[idx] != " ")
                    {
                        file.WriteLine(namesCandidates[idx], ",");
                        break;
                    }
                    else if (passwordsCandidates[idx] == " ")
                    {
                        file.WriteLine(passwordsCandidates[idx] + ",");
                        break;
                    }
                    else if (AddressesCandidates[idx] == " ")
                    {
                        file.Write(AddressesCandidates[idx] + ",");
                        file.Write(agesCandidates[idx] + ",");
                    }
                    else if (emailAddressCandidates[idx] == " ")
                    {
                        file.Write(emailAddressCandidates[idx] + ",");
                        file.Write(rolesCandidates[idx] + ",");
                    }
                    else if (Allergies[idx] == " ")
                    {
                        file.Write(Allergies[countUsers][idx] + ",");
                    }
                    else if (complain[idx] == " ")
                    {
                        file.Write(complain[idx] + ",");
                        file.Write(phoneNumbersCandidates[idx] + ",");
                    }
                    else if (MatricMarks[idx].ToString() == " ")
                    {
                        file.Write(MatricMarks[idx] + ",");
                    }
                    else if (InterMarksPart[idx].ToString() == " ")
                    {
                        file.Write(InterMarksPart[idx] + ",");
                    }
                    else if (CGPA[idx].ToString() == " ")
                    {
                        file.Write(CGPA[idx] + ",");
                    }
                    else if (IntelligenceTest[idx].ToString() == " ")
                    {
                        file.Write(IntelligenceTest[idx] + ",");
                    }
                    else if (AcademicTest[idx].ToString() == " ")
                    {
                        file.Write(AcademicTest[idx] + ",");
                    }

                    file.WriteLine();
                }
            }
            else if (role == "Admin")
            {
                string path = "C:\\Users\\HP\\source\\repos\\Business Application Version 1 C#\\File Storage\\Admin.txt";
                StreamWriter file = new StreamWriter(path, true);

                file.Write(NameAdmin + ",");
                file.Write(role + ",");
                file.Write(passwordAdmin + ",");
                file.Write(ageAdmin + ",");
                file.Write(phoneNumberAdmin + ",");
                file.Write(addressAdmin + ",");
                file.Flush();
                file.Close();
            }
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
        static void StoreAdminFile(string data)
        {
            using (StreamWriter sw = File.AppendText("C:\\Users\\HP\\source\\repos\\Business Application Version 1 C#\\File Storage\\Admin.txt"))
            {
                sw.Write(data + ",");
            }
        }

        static void StoreInCandidateFile(string data)
        {
            using (StreamWriter sw = File.AppendText("C:\\Users\\HP\\source\\repos\\Business Application Version 1 C#\\File Storage\\CandidateData.txt"))
            {
                sw.Write(data + ",");
            }
        }

        static void StoreDataBasedOnRole(string name, string phoneNumber, string password, int age, string role, string address, string lowercaserole)
        {
            // StoreDataBasedonRole
            if (lowercaserole == "candidate")
            {
                // Here Data is store in array and File both in their respective position
                StoreNextRecord("CandidateData"); // First the cursor shift to the new line in file
                namesCandidates[countUsers] = name;
                StoreInCandidateFile(name); // From here it will start storing the data by comma seperated
                passwordsCandidates[countUsers] = password;
                StoreInCandidateFile(password);
                roles[countUsers] = role;
                StoreInCandidateFile(role);
                agesCandidates[countUsers] = age;
                StoreInCandidateFile(age.ToString());
                phoneNumbersCandidates[countUsers] = phoneNumber;
                StoreInCandidateFile(phoneNumber);
                AddressesCandidates[countUsers] = address;
                StoreInCandidateFile(address);

            }
            /*
            else if (lowercaserole == "staff")
            {
                // Here Data is store in array and File both in their respective position
                StoreNextRecord("EmployeesData");
                namesStaff[countStaff] = name;
                storeInStaffFile(name);
                rolesStaff[countStaff] = role;
                storeInStaffFile(role);
                passwordsStaff[countStaff] = password;
                storeInStaffFile(password);
                agesStaff[countStaff] = age;
                storeInStaffFile(age.ToString());
                phoneNumbersStaff[countStaff] = phoneNumber;
                storeInStaffFile(phoneNumber);
                AddressesStaff[countStaff] = address;
                storeInStaffFile(address);
            }
            */
            else if (lowercaserole == "admin")
            {
                // Here Data is store in array and File both in their respective position
                StoreNextRecord("Admin");
                NameAdmin = name;
                StoreAdminFile(name);
                roleAdmin = role;
                StoreAdminFile(role);
                passwordAdmin = password;
                StoreAdminFile(password);
                ageAdmin = age;
                StoreAdminFile(age.ToString());
                phoneNumberAdmin = phoneNumber;
                StoreAdminFile(phoneNumber);
            }
        }


        static void StoreNextRecord(string filename)
        {
            if (filename == "CandidateData")
            {
                string path = @"C:\Users\HP\source\repos\Business Application Version 1\File Storage\CandidateData.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
            else if (filename == "Admin")
            {
                string path = @"C:\Users\HP\source\repos\Business Application Version 1\File Storage\Admin.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
            /*
            else if (filename == "EmployeesData")
            {
                using (StreamWriter file = new StreamWriter("EmployeesData.txt", true))
                {
                    file.WriteLine();
                }
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
            /*
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
            */
            return idx;
        }

    }
}