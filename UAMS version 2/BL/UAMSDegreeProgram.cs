using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMSDegreeProgram.BL
{
    public class DegreeProgram
    {
        public string Title;
        public float Duration;
        public List<Subject> Subjects = new List<Subject>();
        public int seats;
        //here we will have a function
        public DegreeProgram(string Title, float duration, int seats)
        {
            this.Title = Title;
            this.Duration = duration;
            this.Subjects = new List<Subject>();
            this.seats = seats;
        }
        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < Subjects.Count; x++)
            {
                count = count + Subject[x].CreditHours;
            }
            return count;
        }
        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.CreditHours <= 20)
            {
                Subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isSubjectExists(Subject sub)
        {
            foreach (Subject s in Subjects)
            {
                if (s.CourseCode == sub.CourseCode)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
