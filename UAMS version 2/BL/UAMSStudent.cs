using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subject.BL;
using DegreeProgram.BL;

namespace UAMSStudent.BL
{
    public class Student
    {
        public string Name;
        public int Age;
        public double FSCMarks;
        public double EcatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        public Student(string name, int age, double fsc, double ecat, List<DegreePorgram> preferences)
        {
            this.Name = name;
            this.Age = age;
            this.FSCMarks = fsc;
            this.EcatMarks = ecat;
            this.preferences = preferences;
            regSubject = new List<Subject>();

        }
        public static void calculateMerit()
        {
            this.merit = (((FSCMarks / 1100) * 0.45F) + ((EcatMarks / 400) * 0.55F)) * 100;
        }
        public static bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
        }
        public static int getCreditHours()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.CreditHours;
            }
            return count;
        }
        public static float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject sub in regSubject)
                {
                    fee = fee + sub.SubjectFees;
                }
            }
            return fee;
        }
    }
}
