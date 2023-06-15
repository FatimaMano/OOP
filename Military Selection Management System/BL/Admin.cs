using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    class Admin : Staff
    {
        public Admin(string name,string password) : base(name,password)
        {
        }
        public Admin(string name,string password,string role) : base(name,password,role)
        {

        }
    }
}
