using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
namespace Military_Selection_Management_System.DL
{
    class StaffDL
    {
        public bool CheckTestName(string testName)
        {
            foreach (string storedTestName in Test.TestNames)
            {
                if (testName == storedTestName)
                {
                    return true;
                }
            }

            return false;
        }
        public bool isTrueTestName(string testName)
        {
            if(CheckTestName(testName))
            {
                return true;
            }
            return false;
        }

    }
}
