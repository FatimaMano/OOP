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

namespace Military_Selection_Management_System_GUI
{
    public partial class CandidateScreen : Form
    {

        [DllImport("6di32.dll",EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn

            (int nLeftRect,
            int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public CandidateScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void CandidateScreen_Load(object sender, EventArgs e)
        {

        }
        
    }
}
