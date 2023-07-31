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

namespace Military_Selection_Management_System_GUI.User
{
    public partial class Dashboard : UserControl
    {
        public Dashboard(Candidate candidate)
        {
            InitializeComponent();
            lblTotalCandidatesText.Text = CandidateDL.candidatesList.Count.ToString();

        }
    }
}
