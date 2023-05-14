using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using UAMSStudent;
using UAMSDegreeProgram;
using UAMSSubject;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace UAMS
{
    class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreePorgram> programList = new List<DegreePorgram>();

        static void Main(string[] args)
        {
            int option = Menu();
            clearScreen();
            decideMenu(option);
        }
        static void decideMenu(int option)
        {
            do
            {

                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreePorgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }
                else if (option == 3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = sortStudentByMerit(programList);
                    giveAdmission(sortedStudentList);
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.WriteLine("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStudentinDegree(degName);
                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        viewSubject(s);
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFeeForAll();
                }
                clearScreen();

            } while (option != 8);
            Console.ReadKey();

        }
        static int Menu()
        {
            header();
            int option;
            Console.WriteLine("1. Add Student ");
            Console.WriteLine("2. Add Degree Program ");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specfic Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;

        }


        static Student StudentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (s.Name == name && s.regDegree != null)
                {
                    return s;
                }
            }
        }
        static void calculateFeeForAll()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " has" + s.calculateFee() + " fees");

                }
            }

        }
        static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subject you want to registet");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the Subject code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.Subjects)
                {
                    if (code == sub.CourseCode && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter the Valid Course");
                    x--;
                }
            }
        }
        static List<Student> sortStudentByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach(Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach(Student s in sortedStudentList)
            {
                foreach(DegreePorgram d in s.preferences)
                {
                    if(d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        static void printStudents()
        {
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " got Admission in " + s.regDegree.Title);
                }
                else
                {
                    Console.WriteLine(s.Name + " did not get Admission");
                }
            }
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void viewStudentinDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach(Student s in studentList)
            {
                if(degName == s.regDegree.Title)
                {
                    Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.Age);

                }
            }
        }
        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach(Student s in studentList)
            {
                if(s.regDegree !=null)
                {
                    Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.Age);
                }
            }
        }
        static void addIntoDegreeList(DegreePorgram d)
        {
            programList.Add(d);
        }
        static DegreePorgram takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.WriteLine("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            DegreePorgram degProg = new DegreePorgram(degreeName, degreeDuration, seats);
            Console.Write("Enter how many Subject you want to Enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int x=0; x<count; x++)
            {
                degProg.AddSubject(takeInputForSubject());
            }
            return degProg;
        }
        static Subject takeInputForSubject()
        {
            string code, type;
            int creditHours, subjectFees;
            Console.WriteLine("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter Subject Type: ");
            type = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fees");
            subjectFees = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHours, subjectFees);
            return sub;
        }
        static void addIntoStudentList(Student s)
        {
            StudentList.Add(s);
        }
        static Student takeInputForStudent()
        {
            string name;
            int age;
            double fscMarks,ecatMarks;
            List<DegreePorgram> preferences = new List<DegreePorgram>();
            Console.WriteLine("Enter Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSc Marks: ");
            fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Ecat Marks");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            viewDegreePrograms();
            Console.WriteLine("Enter how many preferences to Enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int x=0; x<count; x++)
            {
                string degName = Console.ReadLine();
                bool flag  = false;
                foreach(DegreePorgram dp in programList)
                {
                    if (degName = dp.Title && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }

                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name ");
                    x--;
                }

            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static void viewDegreePrograms()
        {
            foreach(DegreePorgram dp in programList)
            {
                Console.WriteLine(dp.Title);
            }
        }
        static void header()
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                     /*/       UAMS     /*/                               ");
            Console.WriteLine("**************************************************************************");
        }
        static void viewSubject(Student s)
        {
            if(s.regDegree != null)
            {
                Console.WriteLine("Sub Code\t Sub Type");
                foreach(Subject sub in s.regDegree.Subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }

            }
        }

    }
}