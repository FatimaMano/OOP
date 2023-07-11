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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Username = new Label();
            BtnDashboard = new Button();
            btnleaderboard = new Button();
            button2 = new Button();
            button3 = new Button();
            btnSignOut = new Button();
            btnSettings = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnleaderboard);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 689);
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Military_Candidate_Image;
            pictureBox1.Location = new Point(65, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(65, 107);
            Username.Name = "Username";
            Username.Size = new Size(63, 22);
            Username.TabIndex = 1;
            Username.Text = "Name";
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
            btnleaderboard.Click += BtnDashboard_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InactiveCaption;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 238);
            button2.Name = "button2";
            button2.Size = new Size(220, 47);
            button2.TabIndex = 2;
            button2.Text = "Dashboard";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnDashboard_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.InactiveCaption;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 285);
            button3.Name = "button3";
            button3.Size = new Size(220, 69);
            button3.TabIndex = 2;
            button3.Text = "Dashboard";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnDashboard_Click;
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
            btnSignOut.Click += BtnDashboard_Click;
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
            btnSettings.Click += BtnDashboard_Click;
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
            // CandidateScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1343, 689);
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
        private Button button3;
        private Button button2;
        private Button btnleaderboard;
    }
}