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
    public partial class EducationalDetails : UserControl
    {
        public Candidate candidate1;
        public EducationalDetails(Candidate candidate)
        {
            candidate1 = candidate;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateAndSetMatricMarks(out float matricMarksValue))
            {
                candidate1.setMatricMarks(matricMarksValue);
            }

            if (ValidateAndSetIntermediateMarks(out float interMarksValue))
            {
                candidate1.setInterMarksPart(interMarksValue);
            }

            if (ValidateAndSetCGPA(out float CGPAvalue))
            {
                candidate1.setCGPA(CGPAvalue);
            }

            if (ValidateAndSetIntelligenceMarks(out int intelligenceMarksValue))
            {
                candidate1.setIntelligenceTest(intelligenceMarksValue);
            }

            if (ValidateAndSetAcademicMarks(out int academicMarksValue))
            {
                candidate1.setAcademicTest(academicMarksValue);
            }
        }

        private bool ValidateAndSetMatricMarks(out float value)
        {
            if (float.TryParse(MatricMarks.Text, out value) && value >= 0 && value <= 1100)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number between 0 and 1100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MatricMarks.Text = string.Empty;
                return false;
            }
        }

        private bool ValidateAndSetIntermediateMarks(out float value)
        {
            if (float.TryParse(IntermediateMarks.Text, out value) && value >= 0 && value <= 1100)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number between 0 and 1100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IntermediateMarks.Text = string.Empty;
                return false;
            }
        }

        private bool ValidateAndSetCGPA(out float value)
        {
            if (float.TryParse(CGPA.Text, out value) && value >= 1.0 && value <= 4.0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid floating-point number between 1.0 and 4.0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CGPA.Text = string.Empty;
                return false;
            }
        }

        private bool ValidateAndSetIntelligenceMarks(out int value)
        {
            if (int.TryParse(IntelligenceTestMarks.Text, out value) && value >= 0 && value <= 160)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer between 0 and 160.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IntelligenceTestMarks.Text = string.Empty;
                return false;
            }
        }

        private bool ValidateAndSetAcademicMarks(out int value)
        {
            if (int.TryParse(AcademicTestMarks.Text, out value) && value >= 0 && value <= 200)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer between 0 and 200.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AcademicTestMarks.Text = string.Empty;
                return false;
            }
        }
    }
}
