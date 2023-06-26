using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System.DL
{
    class PersonDL
    {
        public static List<Person> PersonsList = new List<Person>();
        public void AddPerson(Person p)
        {
            PersonsList.Add(p);
        }
        public void RemovePerson(Person p)
        {
            PersonsList.Remove(p);
        }
        public void StoreDatainStaffFile(string filePath, Staff staff)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.Write(staff.getName() + ",");
                file.Write(staff.getAge() + ",");
                file.Write(staff.getPassword() + ",");
                file.Write(staff.getphoneNumber() + ",");
                file.Write(staff.getRole() + ",");
                file.Write(staff.getemailAddress() + ",");
                file.Write(staff.getaddress() + ",");
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
                string path = @"C:\Users\HP\source\repos\Business Application Version 1\File Storage\CandidateData.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
            else if (filename == "Staff")
            {
                string path = @"C:\Users\HP\source\repos\Business Application Version 1\File Storage\Admin.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
        }
    }
}
