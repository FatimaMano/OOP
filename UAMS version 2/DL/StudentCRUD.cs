using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using UAMSDegreeProgram.BL;
using UAMSStudent.BL;

namespace StudentCRUD.DL
{
    public class StudentCRUD
    {
        public static List<Student> studentList = new List<Student>();
        public static void addIntoStudentList(Student s)

        {
            studentList.Add(s)
        }
        public static Student StudentPresent(string name)
        {
            foreach(Student s in studentList)
            {
                if(name == s.Name && s.regDegree != null) return s;
            }
            return null;
        }
        public static List<Student> sortStudentByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        public static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (DegreePorgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        public static void storeIntoFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path,true);
            string degreeNames = " ";
            for(int x=0; x<s.preferences.Count(); x++)
            {
                degreeNames = degreeNames + s.preferences[x].Title + ";";
            }
            degreeNames = degreeNames + s.preferences[s.preference.Count() - 1].degreeName;
            f.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," + s.ecatMarks + "," + degreeNames);

        }

    }
}
