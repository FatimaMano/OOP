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
        public void AddCandidate(Candidate candidate)
        {
            candidatesList.Add(candidate);
        }
        public void DeleteCandidate(Candidate candidate) 
        {
            candidatesList.Remove(candidate);
        }
        public void StoreinCandidateFile(string filePath, Candidate candidate)
        {
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
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
        public Candidate LoadFromCandidateFile(string filePath)
        {
            string[] attributes = File.ReadAllText(filePath).Split(',');

            Candidate candidate = new Candidate();
            int currentIndex = 0;

            candidate.setName(attributes[currentIndex++]);
            candidate.setAge(Convert.ToInt32(attributes[currentIndex++]));
            candidate.setPassword(attributes[currentIndex++]);
            candidate.setphoneNumber(Convert.ToDouble(attributes[currentIndex++]));
            candidate.setRole(attributes[currentIndex++]);
            candidate.setemailAddress(attributes[currentIndex++]);
            candidate.setaddress(attributes[currentIndex++]);
            candidate.setHeight(Convert.ToInt32(attributes[currentIndex++]));
            candidate.setWeight(Convert.ToInt32(attributes[currentIndex++]));
            candidate.setMatricMarks(Convert.ToSingle(attributes[currentIndex++]));
            candidate.setInterMarksPart(Convert.ToSingle(attributes[currentIndex++]));
            candidate.setIntelligenceTest(Convert.ToInt32(attributes[currentIndex++]));
            candidate.setAcademicTest(Convert.ToInt32(attributes[currentIndex++]));
            candidate.setCGPA(Convert.ToSingle(attributes[currentIndex++]));
            candidate.setResult(Convert.ToDouble(attributes[currentIndex++]));
            candidate.setSelectionStatus((attributes[currentIndex++]));
            candidate.setComplain(attributes[currentIndex++]);
            candidate.setAllergies(attributes[currentIndex]);

            return candidate;
        }


    }
}
