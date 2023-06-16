using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Selection_Management_System.BL
{
    public class Person
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

		public void setName(string name)
		{
			this.name = name;
		}

		public void setPassword(string password)
		{
			this.password = password;
		}
		public void setAge(int age)
        {
			this.age = age;
        }
		public void setphoneNumber(double phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}
		public void setaddress(string address)
		{
			this.address = address;
		}
		public void setemailAddress(string emailaddress)
        {
			this.emailAddress = emailaddress;
        }
		public void setRole(string role)
        {
			this.role = role;
        }
		public string getName()
		{
			return name;
		}

		public string getPassword()
		{
			return password;
		}
		public int getAge()
		{
			return age;
		}
		public double getphoneNumber()
		{
			return phoneNumber;
		}
		public string getaddress()
		{
			return address;
		}
		public string getemailAddress()
		{
			return emailAddress;
		}
		public string setRole()
		{
			return role;
		}
	}
}
