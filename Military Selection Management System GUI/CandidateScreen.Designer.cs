namespace Military_Selection_Management_System_GUI
{
    partial class CandidateScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateScreen));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button6 = new Button();
            btnSettings = new Button();
            btnSignOut = new Button();
            btnEnableDropdown = new Button();
            BtnApplicationSubmission = new Button();
            btnleaderboard = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            Username = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(btnEnableDropdown);
            panel1.Controls.Add(BtnApplicationSubmission);
            panel1.Controls.Add(btnleaderboard);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 689);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.Enabled = false;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 350);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Green;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(21, 750);
            button6.Name = "button6";
            button6.Size = new Size(180, 47);
            button6.TabIndex = 2;
            button6.Text = "Dashboard";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = false;
            button6.Click += BtnDashboard_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.InactiveCaption;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 595);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(220, 47);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.Transparent;
            btnSignOut.Dock = DockStyle.Bottom;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignOut.ForeColor = Color.WhiteSmoke;
            btnSignOut.Image = (Image)resources.GetObject("btnSignOut.Image");
            btnSignOut.Location = new Point(0, 642);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(220, 47);
            btnSignOut.TabIndex = 2;
            btnSignOut.Text = "SignOut";
            btnSignOut.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnEnableDropdown
            // 
            btnEnableDropdown.BackColor = Color.Transparent;
            btnEnableDropdown.Dock = DockStyle.Top;
            btnEnableDropdown.FlatAppearance.BorderSize = 0;
            btnEnableDropdown.FlatStyle = FlatStyle.Flat;
            btnEnableDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnableDropdown.ForeColor = SystemColors.InactiveCaption;
            btnEnableDropdown.Image = (Image)resources.GetObject("btnEnableDropdown.Image");
            btnEnableDropdown.Location = new Point(0, 285);
            btnEnableDropdown.Name = "btnEnableDropdown";
            btnEnableDropdown.Size = new Size(220, 69);
            btnEnableDropdown.TabIndex = 2;
            btnEnableDropdown.Text = "More";
            btnEnableDropdown.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEnableDropdown.UseVisualStyleBackColor = false;
            btnEnableDropdown.Click += btnMore_Click;
            // 
            // BtnApplicationSubmission
            // 
            BtnApplicationSubmission.BackColor = Color.Transparent;
            BtnApplicationSubmission.Dock = DockStyle.Top;
            BtnApplicationSubmission.FlatAppearance.BorderSize = 0;
            BtnApplicationSubmission.FlatStyle = FlatStyle.Flat;
            BtnApplicationSubmission.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnApplicationSubmission.ForeColor = SystemColors.InactiveCaption;
            BtnApplicationSubmission.Image = (Image)resources.GetObject("BtnApplicationSubmission.Image");
            BtnApplicationSubmission.Location = new Point(0, 238);
            BtnApplicationSubmission.Name = "BtnApplicationSubmission";
            BtnApplicationSubmission.Size = new Size(220, 47);
            BtnApplicationSubmission.TabIndex = 2;
            BtnApplicationSubmission.Text = "Application";
            BtnApplicationSubmission.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnApplicationSubmission.UseVisualStyleBackColor = false;
            BtnApplicationSubmission.Click += btnApplication_Click;
            // 
            // btnleaderboard
            // 
            btnleaderboard.BackColor = Color.Transparent;
            btnleaderboard.Dock = DockStyle.Top;
            btnleaderboard.FlatAppearance.BorderSize = 0;
            btnleaderboard.FlatStyle = FlatStyle.Flat;
            btnleaderboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnleaderboard.ForeColor = SystemColors.InactiveCaption;
            btnleaderboard.Image = (Image)resources.GetObject("btnleaderboard.Image");
            btnleaderboard.Location = new Point(0, 191);
            btnleaderboard.Name = "btnleaderboard";
            btnleaderboard.Size = new Size(220, 47);
            btnleaderboard.TabIndex = 2;
            btnleaderboard.Text = "Leaderboard";
            btnleaderboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnleaderboard.UseVisualStyleBackColor = false;
            btnleaderboard.Click += btnLeaderBoard_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.Transparent;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDashboard.ForeColor = SystemColors.InactiveCaption;
            BtnDashboard.Image = (Image)resources.GetObject("BtnDashboard.Image");
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(220, 47);
            BtnDashboard.TabIndex = 2;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Username);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 144);
            panel2.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(79, 107);
            Username.Name = "Username";
            Username.Size = new Size(63, 22);
            Username.TabIndex = 1;
            Username.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Military_Candidate_Image;
            pictureBox1.Location = new Point(79, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(220, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1123, 689);
            panelContainer.TabIndex = 1;
            // 
            // CandidateScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1343, 689);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "CandidateScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CandidateScreen";
            Load += CandidateScreen_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label Username;
        private Button BtnDashboard;
        private Button button6;
        private Button btnSettings;
        private Button btnSignOut;
        private Button btnEnableDropdown;
        private Button BtnApplicationSubmission;
        private Button btnleaderboard;
        private ComboBox comboBox1;
        private Panel panelContainer;
    }
}