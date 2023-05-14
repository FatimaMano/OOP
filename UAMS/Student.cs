using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSDegreeProgram;
using UAMSSubject;

namespace UAMSStudent
{
    public class Student
    {
        public string Name;
        public int Age;
        public double FSCMarks;
        public double EcatMarks;
        public double merit;
        public List<DegreePorgram> preferences;
        public List<Subject> regSubject;
        public DegreePorgram regDegree;

        public Student(string name,int age, double fsc, double ecat,List<DegreePorgram> preferences)
        {
            this.Name = name;
            this.Age = age;
            this.FSCMarks = fsc;
            this.EcatMarks = ecat;
            this.preferences = preferences;
            regSubject = new List<Subject>();

        }
        public void calculateMerit()
        {
            this.merit = (((FSCMarks / 1100) * 0.45F) + ((EcatMarks / 400) * 0.55F)) * 100;
        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.CreditHours;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if(regDegree != null)
            {
                foreach(Subject sub in regSubject)
                {
                    fee = fee + sub.SubjectFees;
                }
            }
            return fee;
        }
    }
}
