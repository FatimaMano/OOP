using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Military_Selection_Management_System.BL;
using Military_Selection_Management_System.DL;

namespace Military_Selection_Management_System_GUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = IDText.Text;
            string password = PasswordText.Text;
            Person person = new Person(ID,password);
            string check = Person.SignIn(person);
            if(check == "false")
            {
                MessageBox.Show("Not Exist", "Error");
            }
            else if(check == "Candidate")
            {
                Candidate candidate = CandidateDL.GetCandidateObject(person);
                CandidateScreen candidateScreen = new CandidateScreen(candidate);
                candidateScreen.Show();
                this.Hide();
            }
            else if(check == "Person")
            {
                person = Person.GetPersonObject(person);
                if(person.getRole() == "Admin")
                {
                    Admin_Screen adminscreen = new Admin_Screen();
                    adminscreen.Show();
                    this.Hide();
                }
                else if(person.getRole() == "Staff")
                {
                    StaffScreen staffscreen = new StaffScreen();
                    staffscreen.Show();
                    this.Hide();
                }
            }

        }
    }
}
