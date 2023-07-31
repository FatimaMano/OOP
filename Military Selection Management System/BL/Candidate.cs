using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.Extras;
using Military_Selection_Management_System.UI;
using static System.Net.Mime.MediaTypeNames;

namespace Military_Selection_Management_System.BL
{
    public class Candidate : Person
    {
        //Attributes
        private string Allergies;
        private string complain;
        private float MatricMarks;
        private float InterMarksPart;
        private float CGPA;
        private string Educational_Status;
        private int IntelligenceTest;
        private int AcademicTest;
        private int Height;
        private int Weight;
        private string SelectionStatus;
        private int count;
        private double Result;
        private const double MatricPassPercentage = 70.0;
        private const double InterPassPercentage = 70.0;
        private const double CgpaPassThreshold = 3.5;
        private const double IntelligenceTestPassPercentage = 80.0;
        private const double AcademicTestPassPercentage = 80.0;

        // Constructors
        public Candidate()
        {

        }
        public Candidate(string ID,string name, string password) : base(ID,name, password)
        {

        }
        public Candidate(string ID,string name, string password, string address, int age, double phoneNumber, string emailAddress, string role) : base(ID,name, password, address, age, phoneNumber, emailAddress, role)
        {


        }
        public Candidate(string ID, string password) : base(ID, password)
        {

        }

        //AddintoList


        // Getter Setters
        public int getAcademicTest()
        {
            return AcademicTest;
        }

        public int getIntelligenceTest()
        {
            return IntelligenceTest;
        }
        public string getAllergies()
        {
            return Allergies;
        }

        public string getcomplain()
        {
            return complain;
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
        public int getWeight()
        {
            return Weight;
        }
        public string getSelectionStatus()
        {
            return SelectionStatus;
        }
        public double getResult()
        {
            return Result;
        }
        //Setters
        public void setMatricMarks(float MatricMarks)
        {
            this.MatricMarks = MatricMarks;
        }
        public void setInterMarksPart(float InterMarksPart)
        {
            this.InterMarksPart = InterMarksPart;
        }
        public void setHeight(int height)
        {
            this.Height = height;
        }
        public void setCGPA(float CGPA)
        {
            this.CGPA = CGPA;
        }
        public void setComplain(string complain)
        {
            this.complain = complain;
        }
        public void setAllergies(string Allergies)
        {
            this.Allergies = Allergies;

        }
        public void setWeight(int weight)
        {
            this.Weight = weight;
        }
        public void setSelectionStatus(string SelectionStatus)
        {
            this.SelectionStatus = SelectionStatus;
        }
        public void setResult(Candidate candidate)
        {
            Result = CalculateOverallPercentage(candidate);
        }
        public void setAcademicTest(int AcademicTest)
        {
            this.AcademicTest = AcademicTest;
        }

        public void setIntelligenceTest(int IntelligenceTest)
        {
            this.IntelligenceTest = IntelligenceTest;
        }
        public void SetEducationalStatus(string Status)
        {
            this.Educational_Status = Status;
        }

        public double CalculateOverallPercentage(Candidate candidate)
        {

            // Calculate the percentage of marks obtained in each test
            double matricPercentage = CalculatePercentage(candidate.getMatricMarks());
            double interPercentage = CalculatePercentage(candidate.getInterMarksPart());
            double cgpaPercentage = CalculateCgpaPercentage(candidate.getCGPA());
            double intelligenceTestPercentage = CalculateIntelligencePercentage(candidate.getIntelligenceTest());
            double academicTestPercentage = CalculateAcademicPercentage(candidate.getAcademicTest());

            // Check if the student has passed overall
            bool overallPassed = CheckOverallPass(matricPercentage, interPercentage, cgpaPercentage, intelligenceTestPercentage, academicTestPercentage);

            // Calculate the overall percentage based on the weightage
            double overallPercentage = CalculateWeightedAverage(matricPercentage, interPercentage, cgpaPercentage, intelligenceTestPercentage, academicTestPercentage);

            // Return the overall percentage or 0 if the student has not passed overall
            return overallPassed ? overallPercentage : 0.0;
        }

        private static float CalculatePercentage(float obtainedMarks)
        {
            return (obtainedMarks / 1100) * 100;
        }
        private static float CalculateIntelligencePercentage(int obtainedMarks)
        {
            return (obtainedMarks / 160) * 100;
        }
        private static float CalculateAcademicPercentage(int obtainedMarks)
        {
            return (obtainedMarks / 200) * 100;
        }

        private static double CalculateCgpaPercentage(float cgpa)
        {
            return (cgpa / 4.0) * 100.0;
        }

        private static bool CheckOverallPass(double matricPercentage, double interPercentage, double cgpaPercentage, double intelligenceTestPercentage, double academicTestPercentage)
        {
            return matricPercentage >= MatricPassPercentage &&
                   interPercentage >= InterPassPercentage &&
                   cgpaPercentage >= CgpaPassThreshold &&
                   intelligenceTestPercentage >= IntelligenceTestPassPercentage &&
                   academicTestPercentage >= AcademicTestPassPercentage;
        }

        private static double CalculateWeightedAverage(double matricPercentage, double interPercentage, double cgpaPercentage, double intelligenceTestPercentage, double academicTestPercentage)
        {
            return (matricPercentage + interPercentage + cgpaPercentage + intelligenceTestPercentage + academicTestPercentage) / 5.0;
        }

    }

}
