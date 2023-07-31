using Military_Selection_Management_System.DL;

namespace Military_Selection_Management_System_GUI
{
    public partial class MilitarySelection : Form
    {
        public MilitarySelection()
        {
            InitializeComponent();
            string path1 = "CandidateData.txt";
            string path2 = "EmployeesData.txt";
            if (CandidateDL.LoadFromCandidateFile(path1) && PersonDL.LoadFromEmployeesFile(path2))
            {
                MessageBox.Show("Data Loaded from the file");
            }
            else
            {
                MessageBox.Show("Data not loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            LogIn login_form = new LogIn();
            login_form.Show();
        }
    }
}