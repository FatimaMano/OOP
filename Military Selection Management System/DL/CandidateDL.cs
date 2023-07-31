using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
namespace Military_Selection_Management_System.DL
{
    class CandidateDL
    {
        public static List<Candidate> candidatesList = new List<Candidate>();
        public static List<Candidate> TopCandidatesList = new List<Candidate>();
        public static void AddCandidate(Candidate candidate)
        {
            candidatesList.Add(candidate);
        }
        public void SortDataByOverallPercentage()
        {
            // Sort the data in descending order of overall percentage
            CandidateDL.TopCandidatesList = CandidateDL.candidatesList.OrderByDescending(s => s.CalculateOverallPercentage(s)).ToList();

        }
        public  static void DeleteCandidate(string ID,string name) 
        {
            foreach(Candidate candidate in candidatesList)
            {
                if (candidate.getID() == ID && candidate.getName() == name)
                {
                    candidatesList.Remove(candidate);
                }
            }
        }
        public static Candidate SearchCandidate(string ID, string name)
        {
            foreach (Candidate candidate in candidatesList)
            {
                if (candidate.getID() == ID && candidate.getName() == name)
                {
                    return candidate;
                }
            }
            return null;
        }
        public static Candidate isCandidateExist(Candidate candidate)
        {
            foreach (Candidate Candidate1 in CandidateDL.candidatesList)
            {
                if (Candidate1.getID() == candidate.getID() && Candidate1.getPassword() == candidate.getPassword())
                {
                    return candidate;
                }
            }
            return null;
        }
        public static void StoreinCandidateFile(string filePath, Candidate candidate)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                PersonDL.StoreNextRecord("CandidateData");
                file.Write(candidate.getID() + ",");
                file.Write(candidate.getName() + ",");
                file.Write(candidate.getAge() + ",");
                file.Write(candidate.getPassword() + ",");
                file.Write(candidate.getphoneNumber() + ",");
                file.Write(candidate.getRole() + ",");
                file.Write(candidate.getemailAddress() + ",");
                file.Write(candidate.getaddress() + ",");
                file.Write(candidate.getHeight() + ",");
                file.Write(candidate.getWeight() + ",");
                file.Write(candidate.getMatricMarks() + ",");
                file.Write(candidate.getInterMarksPart() + ",");
                file.Write(candidate.getIntelligenceTest() + ",");
                file.Write(candidate.getAcademicTest() + ",");
                file.Write(candidate.getCGPA() + ",");
                file.Write(candidate.getResult() + ",");
                file.Write(candidate.getSelectionStatus() + ",");
                file.Write(candidate.getcomplain() + ",");
                file.Write(candidate.getAllergies() + ",");
            }
        }
        public static void LoadFromCandidateFile(string filePath)
        {
            StreamReader f = new StreamReader(filePath);
            string record;
            int currentIndex = 0;
            while ((record = f.ReadLine()) != null)
            {
                string[] attributes = record.Split(',');
                Candidate candidate = new Candidate();
                candidate.setID(attributes[currentIndex++]);
                candidate.setName(attributes[currentIndex++]); 
                candidate.setAge(PersonDL.ParseInt32(attributes[currentIndex++]));
                candidate.setPassword(attributes[currentIndex++]);
                candidate.setphoneNumber(PersonDL.ParseDouble(attributes[currentIndex++]));
                candidate.setRole(attributes[currentIndex++]);
                candidate.setemailAddress(attributes[currentIndex++]);
                candidate.setaddress(attributes[currentIndex++]);
                candidate.setHeight(PersonDL.ParseInt32(attributes[currentIndex++]));
                candidate.setWeight(PersonDL.ParseInt32(attributes[currentIndex++]));
                candidate.setMatricMarks(PersonDL.ParseSingle(attributes[currentIndex++]));
                candidate.setInterMarksPart(PersonDL.ParseSingle(attributes[currentIndex++]));
                candidate.setIntelligenceTest(PersonDL.ParseInt32(attributes[currentIndex++]));
                candidate.setAcademicTest(PersonDL.ParseInt32(attributes[currentIndex++]));
                candidate.setCGPA(PersonDL.ParseSingle(attributes[currentIndex++]));
                candidate.setResult(PersonDL.ParseDouble(attributes[currentIndex++]));
                candidate.setSelectionStatus(attributes[currentIndex++]);
                candidate.setComplain(attributes[currentIndex++]);
                candidate.setAllergies(attributes[currentIndex++]);
                AddCandidate(candidate);
                currentIndex = 0;
            }
        }

        public static Candidate CreateCandidateObject(Person person, Extras.Options decide)
        {
            if (decide == Extras.Options.SignUp)
            {
                Candidate candidate = new Candidate(person.getID(), person.getName(), person.getPassword(), person.getaddress(), person.getAge(), person.getphoneNumber(), person.getemailAddress(), "Candidate");
                return candidate;
            }
            else if (decide == Extras.Options.SignIn)
            {
                Candidate candidate = new Candidate(person.getID(), person.getPassword());
                return candidate;
            }
            return null;

        }


    }
}
