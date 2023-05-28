using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;
using UAMSDegreeProgram.BL;

namespace DegreeProgramCRUD.DL
{
    public class DegreeProgramCRUD
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();
        public static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
        public static DegreeProgram isDegreeExists(string degreeName)
        {
            foreach(DegreeProgram d in programList)
            {
                if(d.Title == degreeName) return d;
            }
            return null;
        }
        public static void storeIntoFile(string path,DegreeProgram d)
        {
            StreamWriter f = new StreamWriter(path);
            string SubjectNames = "";
            for(int x=0;x< d.Subjects.Count()-1;x++)
            {
                SubjectNames = SubjectNames + d.Subjects[x].type + ";";
            }
            SubjectNames = SubjectNames + d.Subjects[d.Subjects.Count()-1].type;
            f.WriteLine(d.Title + "," + d.Duration + "," + d.seats + "," + SubjectNames);
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if(File.Exists(path))
            {
                while((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    float degreeDuration = float.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(",");
                    DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats);
                    for(int x=0; x< splittedRecordForSubject; x++)
                    {
                        Subject s = SubjectCRUD.isSubjectExists(splittedRecordForSubject[x]);
                        if(s != null)
                        {
                            d.AddSubject(s);
                        }
                        addIntoDegreeList(d);
                    }
                    f.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
