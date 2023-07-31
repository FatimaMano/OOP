namespace Military_Selection_Management_System_GUI.User
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTotalCandidate = new Label();
            lblTotalCandidatesText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnTestSchedule = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lblTotalCandidate
            // 
            lblTotalCandidate.AutoSize = true;
            lblTotalCandidate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCandidate.Location = new Point(54, 197);
            lblTotalCandidate.Name = "lblTotalCandidate";
            lblTotalCandidate.Size = new Size(354, 29);
            lblTotalCandidate.TabIndex = 0;
            lblTotalCandidate.Text = "Total Number of Candidates:";
            // 
            // lblTotalCandidatesText
            // 
            lblTotalCandidatesText.BackColor = Color.Transparent;
            lblTotalCandidatesText.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCandidatesText.Location = new Point(414, 197);
            lblTotalCandidatesText.Name = "lblTotalCandidatesText";
            lblTotalCandidatesText.Size = new Size(21, 36);
            lblTotalCandidatesText.TabIndex = 1;
            lblTotalCandidatesText.Text = "0";
            // 
            // btnTestSchedule
            // 
            btnTestSchedule.BackColor = Color.FromArgb(46, 51, 73);
            btnTestSchedule.CustomizableEdges = customizableEdges1;
            btnTestSchedule.DisabledState.BorderColor = Color.DarkGray;
            btnTestSchedule.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTestSchedule.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTestSchedule.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTestSchedule.FillColor = Color.Black;
            btnTestSchedule.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTestSchedule.ForeColor = Color.White;
            btnTestSchedule.Location = new Point(677, 165);
            btnTestSchedule.Name = "btnTestSchedule";
            btnTestSchedule.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTestSchedule.Size = new Size(270, 68);
            btnTestSchedule.TabIndex = 2;
            btnTestSchedule.Text = "Test Schedule";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 117);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 380);
            panel2.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnTestSchedule);
            Controls.Add(lblTotalCandidatesText);
            Controls.Add(lblTotalCandidate);
            Name = "Dashboard";
            Size = new Size(1047, 688);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalCandidate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCandidatesText;
        private Guna.UI2.WinForms.Guna2Button btnTestSchedule;
        private Panel panel1;
        private Panel panel2;
    }
}
