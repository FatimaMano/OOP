using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    class Person
    {
		protected string name;
		protected string password;
		protected string address;
		protected int age;
		protected double phoneNumber;
		protected string emailAddress;
		protected string role;
		public Person(string name, string password, string address, int age, double phoneNumber, string emailAddress, string role)
		{
			this.name = name;
			this.password = password;
			this.address = address;
			this.age = age;
			this.phoneNumber = phoneNumber;
			this.emailAddress = emailAddress;
			this.role = role;
		}
		public Person(string name,string password)
        {
			this.name = name;
			this.password = password;
        }
	}
}
