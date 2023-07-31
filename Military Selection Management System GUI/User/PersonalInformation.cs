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

namespace Military_Selection_Management_System_GUI.User
{
    public partial class PersonalInformation : UserControl
    {
        public PersonalInformation(Candidate candidate)
        {
            InitializeComponent();
            IDText.Text = candidate.getID();
            NameText.Text = candidate.getName();
            EmailText.Text = candidate.getemailAddress();
            AgeText.Text = candidate.getAge().ToString();
            PhoneNumberText.Text = candidate.getphoneNumber().ToString();
            AddressText.Text = candidate.getaddress();
        }
    }
}
