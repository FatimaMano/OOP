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
using Military_Selection_Management_System.UI;


namespace Military_Selection_Management_System_GUI.User
{
    public partial class LeaderBoard : UserControl
    {
        public LeaderBoard()
        {
            InitializeComponent();
            LeaderboardDataGrid.DataSource = CandidateDL.TopCandidatesList;
            //LeaderboardDataGrid.Columns["ID"].Visible = false;

        }

    }
}
