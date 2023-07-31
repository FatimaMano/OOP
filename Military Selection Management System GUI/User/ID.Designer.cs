namespace Military_Selection_Management_System_GUI.User
{
    partial class ID
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
            lblID = new Label();
            lblHeadID = new Label();
            textBox1 = new TextBox();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(20, 194);
            lblID.Name = "lblID";
            lblID.Size = new Size(50, 34);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblHeadID
            // 
            lblHeadID.AutoSize = true;
            lblHeadID.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeadID.Location = new Point(56, 96);
            lblHeadID.Name = "lblHeadID";
            lblHeadID.Size = new Size(225, 26);
            lblHeadID.TabIndex = 1;
            lblHeadID.Text = "Enter Candidate ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.CustomizableEdges = customizableEdges1;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.FillColor = Color.Black;
            btnNext.FocusedColor = Color.Gray;
            btnNext.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(176, 386);
            btnNext.Name = "btnNext";
            btnNext.PressedColor = Color.Silver;
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNext.Size = new Size(149, 56);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            // 
            // ID
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(textBox1);
            Controls.Add(lblHeadID);
            Controls.Add(lblID);
            Name = "ID";
            Size = new Size(359, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblHeadID;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}
