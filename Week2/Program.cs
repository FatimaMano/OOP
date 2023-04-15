using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Week2
{
    class Program
    {
        class Students
        {
            public string name;
            public int roll_no;
            public float cgpa;
            public string department;
            public char isHostileide;
        }
        class Products
        {
            public string pname;
            public float productprice;
            public string pID;
            public string pCategory;
            public string pBrandname;
            public float pCountry;

        }
        class Credentials
        {
            public string username;
            public string password;
        }
        static void Main(string[] args)
        {
            /*
            CreateObject1();
            CreateObject2();
            TakeinputFromUserinObject();*/


        }
        static void CreateObject1()
        {
            Students s1 = new Students();
            s1.Name = "Ahmad";
            s1.Roll_no = 5;
            s1.CGPA = 3.3F;
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s1.Name, s1.Roll_no, s1.cgpa);
            Console.Read();
        }
        static void CreateObject2()
        {
            Students s2 = new Students();
            s2.Name = "Ahmad";
            s2.Roll_no = 5;
            s2.CGPA = 3.3F;
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s2.Name, s2.Roll_no, s2.cgpa);
        }
            static void MutipleObjects()
        {
            CreateObject1();
            CreateObject2();
        }
        static void TakeinputFromUserinObject()
        {
            Students s1 = new Students();
            Console.WriteLine("Enter your name");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter your Roll number");
            s1.Roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your CGPA");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s1.Name, s1.Roll_no, s1.cgpa);
            Console.Read();

        }
        static int LogMenuScreen()
        {
            Console.Clear();
            int option = 0;
            Console.WriteLine("1.Adding Student");
            Console.WriteLine("2.View Student");
            Console.WriteLine("3.Top three Student");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your option");
            option = int.Parse(Console.ReadLine());
            /*
            string check = " ";
            bool checkInput = false;
            while (!checkInput)
            {
                cout << "1.Sign in" << endl;
                cout << "2.Sign up" << endl;
                cout << "0.Exit" << endl;
                cout << "Enter your option" << endl;
                cin >> check;
                if (checkInput == true)
                {
                    option = TryParse(check);
                }
                system("cls");
            }
            */
            return option;
        }
        static Students addStudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.WriteLine("Enter your name");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter your Roll number");
            s1.Roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your CGPA");
            s1.CGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Department");
            s1.Department = Console.ReadLine();
            Console.WriteLine("Is hostile (Y/N)");
            s1.IsHostileide = char.Parse(Console.ReadLine());
            return s1;

        }
        static void ViewStudent(Students[] s,int count)
        {
            Console.Clear();
            for(int i =0 ; i < count; i++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} IsHostelide: {4}", s[i].Name, s[i].Roll_no, s[i].CGPA, s[i].Department, s[i].IsHostileide);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void topStudent(Students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present");
            }
            else if (count==1)
            {
                ViewStudent(s, 1);
            }
            else if (count==2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                ViewStudent(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count); Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                ViewStudent(s, 3);
            }

            }
        static int largest(Students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].CGPA;
            for (int x = start; x < end; x++)
            {
                if (large < s[x].CGPA)
{
                    large
                    =
                    s[x].CGPA;
                    index = x;
                }
            }
            return index;
        }
        static Products addProducts()
        {
            Products products = new Products();
            Console.WriteLine("Enter the product ID");
            products.pID = Console.ReadLine();
            Console.WriteLine("Enter the product name");
            products.pname = Console.ReadLine();
            Console.WriteLine("Enter the price of product");
            products.productprice = Console.ReadLine();
            Console.WriteLine("Enter the product category");
            products.pCategory = Console.ReadLine();
            Console.WriteLine("Enter Brandname of the product");
            products.pBrandname = Console.ReadLine();
            Console.WriteLine("Enter Country Name");
            products.pCountry = Console.ReadLine();
            return products;
        }
        static void ShowProducts()
        {
            Console.Clear();
            for(int i=0;i<6;i++)
            {
                Console.WriteLine("Name: {0} ID {1} Price:{2} Category: {3} BrandName: {4} Country:{5}");
            }
            Console.WriteLine("Press any key to continue");
            Console.Read();

        }
        static float TotalStoreWorth(Products products)
        {
            Console.Clear();
            float sum = 0;
            for(int i = 0;i<6;i++)
            {
                sum += products.productprice;
            }
            return sum;
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

    }
}
