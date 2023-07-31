using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Military_Selection_Management_System_GUI.User;
using Military_Selection_Management_System.BL;

namespace Military_Selection_Management_System_GUI
{
    public partial class CandidateScreen : Form
    {
        Candidate candidate;

        //[DllImport("6di32.dll", EntryPoint = "CreateRoundRectRgn")]
        /*private static extern IntPtr CreateRoundRectRgn

            (int nLeftRect,
            int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);*/
        public CandidateScreen(Candidate candidate)
        {
            InitializeComponent();
            Username.Text = candidate.getName();
            this.candidate = candidate;
            // Add items to the ComboBox.
            comboBox1.Items.Add("Admission Status");
            comboBox1.Items.Add("Test Schedule");
            comboBox1.Items.Add("Feedback");

            // Set the DropDownStyle to DropDownList to prevent user input.
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Attach the event handler for the SelectedIndexChanged event.
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            User.Dashboard dashboard = new User.Dashboard(candidate);
            AddUserControl(dashboard);
        }
        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            User.LeaderBoard leaderBoard = new User.LeaderBoard();
            AddUserControl(leaderBoard);
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            User.Application application = new User.Application();
            AddUserControl(application);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void CandidateScreen_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Perform actions based on the selected item.
            string selectedOption = comboBox1.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Option 1":
                    // Code for Option 1.
                    MessageBox.Show("Option 1 selected!");
                    break;

                case "Option 2":
                    // Code for Option 2.
                    MessageBox.Show("Option 2 selected!");
                    break;

                case "Option 3":
                    // Code for Option 3.
                    MessageBox.Show("Option 3 selected!");
                    break;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
           MilitarySelection mainscreen = new MilitarySelection();
           mainscreen.Show();
           this.Hide();
        }
    }
}
