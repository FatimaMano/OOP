using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    class MUser
    {
        private string username;
        private string userPassword;
        private string userRole;
        public MUser(string username,string userPassword,string userRole)
        {
            this.username = username;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public MUser(string userName,string userPassword)
        {
            this.username = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }

        public string getUserName()
        {
            return username;
        }
        public string getUserPassword()
        {
            return userPassword;
        }
        public string getUSerRole()
        {
            return userRole;
        }
        public bool isAdmin()
        {
            if(userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
