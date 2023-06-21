using System;
using System.Collections.Generic;
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
        public static void DeleteCandidate(Candidate candidate) 
        {
            candidatesList.Remove(candidate);
        }

    }
}
