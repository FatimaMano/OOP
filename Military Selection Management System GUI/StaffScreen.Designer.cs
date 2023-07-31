namespace Military_Selection_Management_System_GUI
{
    partial class StaffScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffScreen));
            StaffSidePanel = new Panel();
            BtnMore = new Button();
            StaffMoreComboBox = new ComboBox();
            btnSettings = new Button();
            btnSignout = new Button();
            btnAppllicationReview = new Button();
            btnCandidates = new Button();
            BtnDashboard = new Button();
            StaffScreenHead = new Panel();
            StaffImage = new PictureBox();
            StaffNameTag = new Label();
            panel1 = new Panel();
            StaffSidePanel.SuspendLayout();
            StaffScreenHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StaffImage).BeginInit();
            SuspendLayout();
            // 
            // StaffSidePanel
            // 
            StaffSidePanel.BackColor = Color.FromArgb(24, 30, 54);
            StaffSidePanel.Controls.Add(BtnMore);
            StaffSidePanel.Controls.Add(StaffMoreComboBox);
            StaffSidePanel.Controls.Add(btnSettings);
            StaffSidePanel.Controls.Add(btnSignout);
            StaffSidePanel.Controls.Add(btnAppllicationReview);
            StaffSidePanel.Controls.Add(btnCandidates);
            StaffSidePanel.Controls.Add(BtnDashboard);
            StaffSidePanel.Controls.Add(StaffScreenHead);
            StaffSidePanel.Dock = DockStyle.Left;
            StaffSidePanel.Location = new Point(0, 0);
            StaffSidePanel.Name = "StaffSidePanel";
            StaffSidePanel.Size = new Size(220, 689);
            StaffSidePanel.TabIndex = 0;
            // 
            // BtnMore
            // 
            BtnMore.BackColor = Color.Transparent;
            BtnMore.Dock = DockStyle.Top;
            BtnMore.FlatAppearance.BorderSize = 0;
            BtnMore.FlatStyle = FlatStyle.Flat;
            BtnMore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMore.ForeColor = SystemColors.InactiveCaption;
            BtnMore.Image = (Image)resources.GetObject("BtnMore.Image");
            BtnMore.Location = new Point(0, 312);
            BtnMore.Name = "BtnMore";
            BtnMore.Size = new Size(220, 47);
            BtnMore.TabIndex = 6;
            BtnMore.Text = "      More";
            BtnMore.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnMore.UseVisualStyleBackColor = false;
            // 
            // StaffMoreComboBox
            // 
            StaffMoreComboBox.BackColor = Color.Black;
            StaffMoreComboBox.Enabled = false;
            StaffMoreComboBox.ForeColor = Color.White;
            StaffMoreComboBox.FormattingEnabled = true;
            StaffMoreComboBox.Location = new Point(23, 365);
            StaffMoreComboBox.Name = "StaffMoreComboBox";
            StaffMoreComboBox.Size = new Size(182, 33);
            StaffMoreComboBox.TabIndex = 9;
            StaffMoreComboBox.Visible = false;
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
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
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
            btnSignout.Size = new Size(220, 47);
            btnSignout.TabIndex = 7;
            btnSignout.Text = "Sign out";
            btnSignout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSignout.UseVisualStyleBackColor = false;
            // 
            // btnAppllicationReview
            // 
            btnAppllicationReview.BackColor = Color.Transparent;
            btnAppllicationReview.Dock = DockStyle.Top;
            btnAppllicationReview.FlatAppearance.BorderSize = 0;
            btnAppllicationReview.FlatStyle = FlatStyle.Flat;
            btnAppllicationReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAppllicationReview.ForeColor = SystemColors.InactiveCaption;
            btnAppllicationReview.Image = (Image)resources.GetObject("btnAppllicationReview.Image");
            btnAppllicationReview.Location = new Point(0, 244);
            btnAppllicationReview.Name = "btnAppllicationReview";
            btnAppllicationReview.Size = new Size(220, 68);
            btnAppllicationReview.TabIndex = 5;
            btnAppllicationReview.Text = "Application Review";
            btnAppllicationReview.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAppllicationReview.UseVisualStyleBackColor = false;
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
            btnCandidates.Size = new Size(220, 47);
            btnCandidates.TabIndex = 4;
            btnCandidates.Text = "Candidates";
            btnCandidates.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCandidates.UseVisualStyleBackColor = false;
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
            BtnDashboard.Size = new Size(220, 47);
            BtnDashboard.TabIndex = 3;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // StaffScreenHead
            // 
            StaffScreenHead.BackColor = Color.FromArgb(34, 34, 56);
            StaffScreenHead.Controls.Add(StaffImage);
            StaffScreenHead.Controls.Add(StaffNameTag);
            StaffScreenHead.Dock = DockStyle.Top;
            StaffScreenHead.Location = new Point(0, 0);
            StaffScreenHead.Name = "StaffScreenHead";
            StaffScreenHead.Size = new Size(220, 150);
            StaffScreenHead.TabIndex = 0;
            // 
            // StaffImage
            // 
            StaffImage.Image = Properties.Resources.HeadStaff;
            StaffImage.Location = new Point(81, 33);
            StaffImage.Name = "StaffImage";
            StaffImage.Size = new Size(65, 59);
            StaffImage.SizeMode = PictureBoxSizeMode.StretchImage;
            StaffImage.TabIndex = 1;
            StaffImage.TabStop = false;
            // 
            // StaffNameTag
            // 
            StaffNameTag.AutoSize = true;
            StaffNameTag.Location = new Point(81, 106);
            StaffNameTag.Name = "StaffNameTag";
            StaffNameTag.Size = new Size(59, 25);
            StaffNameTag.TabIndex = 0;
            StaffNameTag.Text = "Name";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 689);
            panel1.TabIndex = 1;
            // 
            // StaffScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1343, 689);
            Controls.Add(panel1);
            Controls.Add(StaffSidePanel);
            ForeColor = Color.White;
            Name = "StaffScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffScreen";
            StaffSidePanel.ResumeLayout(false);
            StaffScreenHead.ResumeLayout(false);
            StaffScreenHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StaffImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel StaffSidePanel;
        private Panel StaffScreenHead;
        private PictureBox StaffImage;
        private Label StaffNameTag;
        private Button BtnDashboard;
        private Button btnSettings;
        private Button btnSignout;
        private Button btnAppllicationReview;
        private Button btnCandidates;
        private Button BtnMore;
        private ComboBox StaffMoreComboBox;
        private Panel panel1;
    }
}