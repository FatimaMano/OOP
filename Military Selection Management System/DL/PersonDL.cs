using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System.DL
{
    class PersonDL
    {
        public static List<Person> PersonsList = new List<Person>();
        public static void AddPerson(Person p)
        {
            PersonsList.Add(p);
        }
        public static void RemovePerson(Person p)
        {
            PersonsList.Remove(p);
        }
        public static void StoreDatainStaffFile(string filePath, Person person)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                StoreNextRecord("EmployeesData");
                file.Write(person.getName() + ",");
                file.Write(person.getAge() + ",");
                file.Write(person.getPassword() + ",");
                file.Write(person.getphoneNumber() + ",");
                file.Write(person.getRole() + ",");
                file.Write(person.getemailAddress() + ",");
                file.Write(person.getaddress() + ",");
            }
        }



        public static string getField(string line, int index)
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


        public static void StoreNextRecord(string filename)
        {
            if (filename == "CandidateData")
            {
                string path = @"C:\Users\HP\source\repos\Military Selection Management System\File Storage\CandidateData.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
            else if (filename == "EmployeesData")
            {
                string path = @"C:\Users\HP\source\repos\Military Selection Management System\File Storage\EmployeesData.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
        }
        //Load functions

        public static void LoadFromEmployeesFile(string filePath)
        {
            string[] attributes = File.ReadAllText(filePath).Split(',');
            while (attributes.Length > 0)
            {
                Staff staff = new Staff();
                int currentIndex = 0;
                staff.setName(attributes[currentIndex++]);
                staff.setAge(Convert.ToInt32(attributes[currentIndex++]));
                staff.setPassword(attributes[currentIndex++]);
                staff.setphoneNumber(Convert.ToDouble(attributes[currentIndex++]));
                staff.setRole(attributes[currentIndex++]);
                staff.setemailAddress(attributes[currentIndex++]);
                staff.setaddress(attributes[currentIndex++]);

                AddPerson(staff);

            }
        }

    }
}
