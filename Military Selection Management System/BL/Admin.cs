using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    public class Admin : Staff
    {
        public Admin(string ID,string name,string password) : base(ID,name,password)
        {
        }
        public Admin(string ID,string name,string password,string role) : base(ID,name,password,role)
        {

        }
        public Admin(string ID, string password) : base(ID, password)
        {
        }
    }
}
