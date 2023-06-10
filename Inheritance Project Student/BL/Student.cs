using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project_Student.BL
{
    class Student
    {
        public string name;
        public string session;
        public bool isDayScholar;
        public float EnterTestMarks;
        public float HSMarks;
        public Student(string name, string session, bool isDayScholar,float EntryTestMarks,float HSMarks)
        {
            this.name = name;
            this.session = session;
            this.isDayScholar = isDayScholar;
            this.EnterTestMarks = EntryTestMarks;
            this.HSMarks = HSMarks;

        }
        public double calculateMerit()
        {
            double merit = 0.0;
            merit =((HSMarks/1100)*0.7) + ((EnterTestMarks/400)*0.3);
            //Code
            return merit;
        }
    }
}
