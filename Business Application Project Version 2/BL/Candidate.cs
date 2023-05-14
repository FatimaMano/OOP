using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application_Version_1_Class_in_C.BL
{
    public class Candidate
    {
        public string name;
        public string password;
        public string Address;
        public int age;
        public string phoneNumber;
        public string emailAddress;
        public string role;
        public string Allergies;
        public string Treatments;
        public string complain;
        public string ages;
        public float  MatricMarks;
        public float InterMarksPart;
        public float CGPA;
        public int IntelligenceTest;
        public int AcademicTest;
        public int Height;
        public int Weight;
        public string SelectionStatus;
        public int count;
    }
    public Candidate(string name,string password)
    {
        this.name = name;
        this.password = password;
    }
    public Candidate(string name,string password, string role)
    {
        this.name = name;
        this.password = password;
        this.role = role;

    }


}
