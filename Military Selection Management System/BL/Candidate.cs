﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.Extras;
using Military_Selection_Management_System.UI;
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
        public void setResult(double result)
        {
            Result = result;
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

    }
}
