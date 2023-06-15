using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignInSignUpApplication : Form
    {
        public SignInSignUpApplication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SignIn signInButton = new SignIn();
            signInButton.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SignUp signUpButton = new SignUp();
            signUpButton.Show();
            this.Hide();
        }
    }
}
