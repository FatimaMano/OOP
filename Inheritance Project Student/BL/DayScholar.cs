using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project_Student.BL
{
    class DayScholar : Student
    {
        public string pickUpPoint;
        public int busNo;
        public int pickUpDistance;
        public DayScholar(string name, string session, bool isDayScholar,float EntryTestMarks,float HSMarks,string pickUpPoint, int busNo,int pickUpDistance) : base(name, session, isDayScholar,EntryTestMarks,HSMarks)
        {
            this.pickUpDistance = pickUpDistance;
            this.busNo = busNo;
            this.pickUpPoint = pickUpPoint;

        }
        public int getBusFee()
        {
            int fee=2000;
            // Code
            return fee;
        }
    }
}
