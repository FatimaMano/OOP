using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.DL;
using Military_Selection_Management_System.UI;
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
		protected string ID;
        public Person()
        {

        }
        public Person(string ID,string name, string password, string address, int age, double phoneNumber, string emailAddress, string role)
		{
			this.name = name;
			this.password = password;
			this.address = address;
			this.age = age;
			this.phoneNumber = phoneNumber;
			this.emailAddress = emailAddress;
			this.role = role;
		}
		public Person(string ID, string name,string password,string role)
		{
			this.name = name;
			this.password = password;
			this.role = role;
			this.ID = ID;
		}
		public Person(string ID,string name,string password)
        {
			this.ID=ID;
			this.name = name;
			this.password = password;
        }
        public Person(string ID, string password)
        {
            this.ID = ID;
            this.password = password;
        }
        //Setters
        public void setID(string ID)
        {
            this.ID = ID;
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
		//Getters
        public string getID()
        {
            return ID;
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
		public string getRole()
		{
			return role;
		}
        // Exist Validating
        public static bool isPersonExistinList(string ID, string password)
        {
            foreach (Person person in PersonDL.PersonsList)
            {
                if (person.getID() == ID && person.getPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
		public static Person GetPersonObject(Person p)
		{
            foreach (Person person1 in PersonDL.PersonsList)
            {
                if (person1.getID() == p.getID() && person1.getPassword() == p.getPassword())
                {
                    return person1;
                }
            }
            return null;
        }
		//SignUp
        /*public static string Signup(string ID, string name, string password, double phoneNumber,  int age, string role, string address,string emailaddress)
        {
            string lowerCaseRole = role.ToLower();
            if (lowerCaseRole != "candidate" && lowerCaseRole != "staff" && lowerCaseRole != "admin")
            {
                return "Invalid role";
            }

            if (lowerCaseRole == "admin" && isPersonExistinList(name, password, role))
            {
                return "Sign in";
            }

            if (lowerCaseRole == "staff" && isPersonExistinList(name, password, role))
            {
                return "Sign in";
            }

            if (lowerCaseRole == "candidate" && isPersonExistinList(name, password, role))
            {
                return "Sign in";
            }
			if(lowerCaseRole == "admin" || lowerCaseRole == "staff")
			{
				Staff staff = new Staff(ID, name, password,address,PersonUI.CheckAgeStaff(age),phoneNumber,emailaddress,role);
				PersonDL.AddPerson(staff);
				PersonDL.StoreDatainStaffFile("EmployeesData.txt", staff);

            }
			else if (lowerCaseRole == "candidate")
			{
				Candidate candidate = new Candidate(ID,name, password, address, PersonUI.CheckAgeCandidate(age), phoneNumber, emailaddress, role);
				CandidateDL.AddCandidate(candidate);
				CandidateDL.StoreinCandidateFile(@"C:\\Users\\HP\\source\\repos\\Military Selection Management System\\File Storage\\CandidateData.txt", candidate);
			}

            return "Success";
        }
		*/
        public static string SignIn(Person p)
        {
            
            Candidate candidate = CandidateDL.CreateCandidateObject(p, Extras.Options.SignIn);
            Candidate candidateCheck = CandidateDL.isCandidateExist(candidate);
            bool check = isPersonExistinList(p.getID(), p.getPassword());
            if (candidateCheck == null && check == false)
            {
                return "false";
            }
            else
            {
                if(candidateCheck != null)
                {
                    return "Candidate";
                }
                else if(check)
                {
                    return "Person";
                }
                
            }
            return "false";
        }

    }
}
