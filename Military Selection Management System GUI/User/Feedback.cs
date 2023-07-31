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
    public partial class Feedback : UserControl
    {
        Candidate candidate;
        public Feedback(Candidate candidate)
        {
            InitializeComponent();
            this.candidate = candidate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            candidate.setComplain(FeebackText.Text);
            FeebackText.Text = string.Empty;
        }
    }
}
