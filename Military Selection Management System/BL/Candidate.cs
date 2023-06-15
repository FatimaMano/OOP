using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.UI;
namespace Military_Selection_Management_System.BL
{
    class Candidate : Person
    {
        private string Allergies;
        private string Treatments;
        private string complain;
        private float MatricMarks;
        private float InterMarksPart;
        private float CGPA;
        private int IntelligenceTest;
        private int AcademicTest;
        private int Height;
        private int Weight;
        private string SelectionStatus;
        private int count;

        public Candidate(string name, string password) : base(name, password)
        {

        }
        public Candidate(string name, string password, string address, int age, double phoneNumber, string emailAddress, string role) : base(name, password, address, age, phoneNumber, emailAddress, role)
        {


        }

        public static void setName(Candidate candidate)
        {
            candidate.name = PersonUI.isAlpha(Console.ReadLine());
        }

        public static  void setPassword(Candidate candidate)
        {
            candidate.password = Console.ReadLine();
        }

        public static void setAcademicTest(Candidate candidate)
        {
            candidate.AcademicTest = PersonUI.IntegerValidation();
        }

        public static void setIntelligenceTest(Candidate candidate)
        {
            candidate.IntelligenceTest = PersonUI.IntegerValidation();
        }

    }
}
