using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project_Student.BL
{
    class Hostellite : Student
    {
        public int RoomNumber;
        public bool isFrigeAvailable;
        public bool isInternetAvailable;
        public Hostellite(string name, string session, bool isDayScholar,float EntryTestMarks,float HSMarks,bool isFrigeAvailable, int RoomNumber,bool isInternetAvailable) : base(name, session, isDayScholar,EntryTestMarks,HSMarks)
        {
            this.RoomNumber = RoomNumber;
            this.isFrigeAvailable = isFrigeAvailable;
            this.isInternetAvailable = isInternetAvailable;

        }
        public int getHostelFee()
        {
            int fee =10000;
            // Code
            return fee;
        }

    }
}
