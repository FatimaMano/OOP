using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    class Test
    {
        private static List<string> TestNames = new List<string> { "Running", "Sit ups", "Push Ups", "logmenuChin ups", "Ditch Crossing" };
        private string TestName;
        private DateTime TestDateTime;
        public Test(string TestName,DateTime TestDateTime)
        {
            this.TestName = TestName;
            this.TestDateTime = TestDateTime;
        }
        public void setTestName(string TestName)
        {
            this.TestName = TestName;
        }
        public string getTestName()
        {
            return this.TestName;
        }
        public void setTestDateTime(DateTime dateTime)
        {
            this.TestDateTime = dateTime;
        }
        public DateTime getTestDateTime()
        {
            return TestDateTime;
        }
        public static bool CheckTestName(string testName)
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
        public static bool isTrueTestName(string testName)
        {
            if (CheckTestName(testName))
            {
                return true;
            }
            return false;
        }



    }
}
