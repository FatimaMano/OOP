using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.UI;
namespace Military_Selection_Management_System.BL
{
    public class Candidate : Person
    {
        //Attributes
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
        private double Result;
        // Constructors
        public Candidate(string name, string password) : base(name, password)
        {

        }
        public Candidate(string name, string password, string address, int age, double phoneNumber, string emailAddress, string role) : base(name, password, address, age, phoneNumber, emailAddress, role)
        {


        }

        internal DL.CandidateDL CandidateDL
        {
            get => default;
            set
            {
            }
        }

        // Getter Setters

        public void setAcademicTest(int AcademicTest)
        {
            this.AcademicTest = AcademicTest;
        }

        public void setIntelligenceTest(int IntelligenceTest)
        {
            this.IntelligenceTest = IntelligenceTest;
        }

        public int getAcademicTest(int AcademicTest)
        {
            return AcademicTest;
        }

        public int getIntelligenceTest(int IntelligenceTest)
        {
            return IntelligenceTest;
        }
        public string getAllergies()
        {
            return Allergies;
        }
        public string getTreatments()
        {
            return Treatments;
        }
        public string getcomplain()
        {
            return Treatments;
        }
        public float getMatricMarks()
        {
            return MatricMarks;
        }
        public float getInterMarksPart()
        {
            return InterMarksPart;
        }
        public float getCGPA()
        {
            return CGPA;
        }
        public int getHeight()
        {
            return Height;
        }
        public void setWeight(int weight)
        {
            this.Weight = weight;
        }
        public void setSelectionStatus(string SelectionStatus)
        {
            this.SelectionStatus = SelectionStatus;
        }
        public string getSelectionStatus()
        {
            return SelectionStatus;
        }
        public double getResult()
        {
            return Result;
        }
        public void setResult(double result)
        {
            Result = result;
        }

    }
}
