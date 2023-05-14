using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
namespace Week3Class.BL
{
    class Student
    {
        public Student()
        {
            sname = "Jill";
            matricMarks = 1100;
            fscMarks = 1000;
            ecatMarks = 300;
            aggregate = 90;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;


    }
}