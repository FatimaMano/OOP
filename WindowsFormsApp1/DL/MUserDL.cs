using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
namespace WindowsFormsApp1.DL
{
    class MUserDL
    {
        private static List<MUser> usersList = new List<MUser>();
        public static void addUserIntoList(MUser user)
        {
            usersList.Add(user);
        }
        public static MUser SignIn(MUser user)
        {
            foreach (MUser storedUser in usersList)
            {
                if (storedUser.getUserName() == user.getUserName() && storedUser.getUserPassword == user.getUserPassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x=0; x < record.Length;x++)
            {
                if(record[x] == ',')
                {

                }

            }
        }
    }
}
