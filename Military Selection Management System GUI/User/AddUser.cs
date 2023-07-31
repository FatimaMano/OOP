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
using Military_Selection_Management_System.UI;

namespace Military_Selection_Management_System_GUI.User
{
    public partial class AddUser : UserControl
    {
        Candidate candidate1;
        public AddUser()
        {
            InitializeComponent();
        }
        private bool ClearFields(Candidate candidate)
        {
            bool flag = true;
            // Validate and clear the IDText field

            if (!string.IsNullOrEmpty(IDText.Text))
            {
                if (int.TryParse(IDText.Text, out int id))
                {
                    candidate.setID(id.ToString());
                    IDText.Text = "";

                }
                else
                {
                    flag = false;
                    MessageBox.Show("Invalid ID. Please enter a valid integer value for ID.", "Error");
                }
            }
            else
            {
                flag = false;
            }

            // Validate and clear the NameText field
            if (!string.IsNullOrEmpty(NameText.Text))
            {
                // Perform additional validation here if needed
                candidate.setName(NameText.Text);
                // Clear the field
                NameText.Text = "";
            }
            else
            {
                flag = false;
            }

            // Validate and clear the EmailText field
            if (!string.IsNullOrEmpty(EmailText.Text))
            {
                // Perform additional validation here if needed
                if (PersonUI.IsValidEmail(EmailText.Text))
                {
                    candidate.setemailAddress(EmailText.Text);
                }
                // Clear the field
                EmailText.Text = "";
            }
            else
            {
                flag = false;
            }

            // Validate and clear the PhoneNumberText field
            if (!string.IsNullOrEmpty(PhoneNumberText.Text))
            {
                // Perform additional validation here if needed
                if (PersonUI.isValidPhoneNumber(PhoneNumberText.Text))
                {
                    double phoneNumber = Double.Parse(PhoneNumberText.Text);
                    candidate.setphoneNumber(phoneNumber);
                }
                // Clear the field
                PhoneNumberText.Text = "";
            }
            else
            {
                flag = false;
            }

            // Validate and clear the AddressText field
            if (!string.IsNullOrEmpty(AddressText.Text))
            {
                // Perform additional validation here if needed

                // Clear the field
                AddressText.Text = "";
            }
            else
            {
                flag = false;
            }

            // Validate and clear the PasswordText field
            if (!string.IsNullOrEmpty(PasswordText.Text))
            {
                // Perform additional validation here if needed

                // Clear the field
                PasswordText.Text = "";
            }
            else
            {
                flag = false;
            }

            // Validate and clear the AgeText field
            if (!string.IsNullOrEmpty(AgeText.Text))
            {
                if (int.TryParse(AgeText.Text, out int age))
                {
                    // Perform additional validation here if needed
                    // For example, you might want to check if the age is within a valid range
                    if (PersonUI.isValidAgeCandidate(age))
                    {
                        candidate.setAge(age);
                    }
                    // Clear the field
                    AgeText.Text = "";
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Invalid age. Please enter a valid integer value for age.", "Error");
                }
            }
            else
            {
                flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("All Fields are necessary to fill!", "Error");
            }
            candidate1 = candidate;
            return flag;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = ClearFields(candidate1);
            if (check)
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Failed to add the Candidate Try again");
            }
        }
    }
}
