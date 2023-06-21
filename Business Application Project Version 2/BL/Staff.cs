using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application_Project_Version_2.BL
{
    class Staff : Person
    {
        Staff(string name,string password, string address, int age, int phoneNumber, string emailAddress, string role) : base(name,password,address,age,phoneNumber,emailAddress,role)
        {

        }
    }
}
