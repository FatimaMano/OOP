namespace Military_Selection_Management_System_GUI
{
    partial class Admin_Screen
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Screen));
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            AdminScreenHeadPanel = new Guna.UI2.WinForms.Guna2Panel();
            Username = new Label();
            pictureBox1 = new PictureBox();
            BtnDashboard = new Button();
            btnCandidates = new Button();
            btnManagement = new Button();
            btnSignout = new Button();
            btnSettings = new Button();
            btnReport = new Button();
            guna2CustomGradientPanel1.SuspendLayout();
            AdminScreenHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(btnReport);
            guna2CustomGradientPanel1.Controls.Add(btnSettings);
            guna2CustomGradientPanel1.Controls.Add(btnSignout);
            guna2CustomGradientPanel1.Controls.Add(btnManagement);
            guna2CustomGradientPanel1.Controls.Add(btnCandidates);
            guna2CustomGradientPanel1.Controls.Add(BtnDashboard);
            guna2CustomGradientPanel1.Controls.Add(AdminScreenHeadPanel);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Left;
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(0, 0, 0, 40);
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(0, 0, 0, 20);
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(0, 0, 0, 50);
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(232, 689);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // AdminScreenHeadPanel
            // 
            AdminScreenHeadPanel.Controls.Add(Username);
            AdminScreenHeadPanel.Controls.Add(pictureBox1);
            AdminScreenHeadPanel.CustomizableEdges = customizableEdges1;
            AdminScreenHeadPanel.Dock = DockStyle.Top;
            AdminScreenHeadPanel.ForeColor = Color.White;
            AdminScreenHeadPanel.Location = new Point(0, 0);
            AdminScreenHeadPanel.Name = "AdminScreenHeadPanel";
            AdminScreenHeadPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AdminScreenHeadPanel.Size = new Size(232, 150);
            AdminScreenHeadPanel.TabIndex = 0;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(85, 97);
            Username.Name = "Username";
            Username.Size = new Size(63, 22);
            Username.TabIndex = 3;
            Username.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.HeadStaff;
            pictureBox1.Location = new Point(85, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            BtnDashboard.Location = new Point(0, 150);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(232, 47);
            BtnDashboard.TabIndex = 3;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnCandidates
            // 
            btnCandidates.BackColor = Color.Transparent;
            btnCandidates.Dock = DockStyle.Top;
            btnCandidates.FlatAppearance.BorderSize = 0;
            btnCandidates.FlatStyle = FlatStyle.Flat;
            btnCandidates.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCandidates.ForeColor = SystemColors.InactiveCaption;
            btnCandidates.Image = (Image)resources.GetObject("btnCandidates.Image");
            btnCandidates.Location = new Point(0, 197);
            btnCandidates.Name = "btnCandidates";
            btnCandidates.Size = new Size(232, 47);
            btnCandidates.TabIndex = 4;
            btnCandidates.Text = "Candidates";
            btnCandidates.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCandidates.UseVisualStyleBackColor = false;
            // 
            // btnManagement
            // 
            btnManagement.BackColor = Color.Transparent;
            btnManagement.Dock = DockStyle.Top;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnManagement.ForeColor = SystemColors.InactiveCaption;
            btnManagement.Image = (Image)resources.GetObject("btnManagement.Image");
            btnManagement.Location = new Point(0, 244);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(232, 47);
            btnManagement.TabIndex = 5;
            btnManagement.Text = "Management";
            btnManagement.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnManagement.UseVisualStyleBackColor = false;
            // 
            // btnSignout
            // 
            btnSignout.BackColor = Color.Transparent;
            btnSignout.Dock = DockStyle.Bottom;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignout.ForeColor = SystemColors.InactiveCaption;
            btnSignout.Image = (Image)resources.GetObject("btnSignout.Image");
            btnSignout.Location = new Point(0, 642);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(232, 47);
            btnSignout.TabIndex = 7;
            btnSignout.Text = "Sign out";
            btnSignout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSignout.UseVisualStyleBackColor = false;
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
            btnSettings.Size = new Size(232, 47);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Transparent;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = SystemColors.InactiveCaption;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.Location = new Point(0, 291);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(232, 47);
            btnReport.TabIndex = 9;
            btnReport.Text = "Report";
            btnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // Admin_Screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1343, 689);
            Controls.Add(guna2CustomGradientPanel1);
            Name = "Admin_Screen";
            Text = "Admin_Screen";
            guna2CustomGradientPanel1.ResumeLayout(false);
            AdminScreenHeadPanel.ResumeLayout(false);
            AdminScreenHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel AdminScreenHeadPanel;
        private Label Username;
        private PictureBox pictureBox1;
        private Button btnSettings;
        private Button btnSignout;
        private Button btnManagement;
        private Button btnCandidates;
        private Button BtnDashboard;
        private Button btnReport;
    }
}