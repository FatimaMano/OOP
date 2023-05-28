using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMSSubject.BL
{
        public class Subject
        {
            public string CourseCode;
            public string CourseType;
            public int CreditHours;
            public int SubjectFees;
            public Subject(string courseCode, string courseType, int creditHours, int subjectfees)
            {
                CourseCode = courseCode;
                CourseType = courseType;
            CreditHours = creditHours;
                SubjectFees = subjectfees;
            }


        }
}
