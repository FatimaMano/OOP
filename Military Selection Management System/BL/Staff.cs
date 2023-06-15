using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    class Staff : Person
    {
        public Staff(string name, string password, string address, int age, int phoneNumber, string emailAddress, string role) : base(name, password, address, age, phoneNumber, emailAddress, role)
        {

        }
        public Staff(string name,string password) : base(name,password)
        {

        }
        public Staff(string name, string password,string role) : base(name,password,role)
        {

        }
    }
}
