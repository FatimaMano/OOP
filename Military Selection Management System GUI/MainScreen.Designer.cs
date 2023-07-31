namespace Military_Selection_Management_System_GUI
{
    partial class MilitarySelection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilitarySelection));
            label1 = new Label();
            btnSignin = new Guna.UI2.WinForms.Guna2Button();
            btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 63);
            label1.Name = "label1";
            label1.Size = new Size(640, 32);
            label1.TabIndex = 1;
            label1.Text = "Military Selection Management System";
            // 
            // btnSignin
            // 
            btnSignin.CustomizableEdges = customizableEdges1;
            btnSignin.DisabledState.BorderColor = Color.DarkGray;
            btnSignin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignin.FillColor = Color.FromArgb(46, 51, 73);
            btnSignin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(280, 215);
            btnSignin.Name = "btnSignin";
            btnSignin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSignin.Size = new Size(270, 68);
            btnSignin.TabIndex = 2;
            btnSignin.Text = "Signin";
            btnSignin.Click += btnSignin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.CustomizableEdges = customizableEdges3;
            btnSignUp.DisabledState.BorderColor = Color.DarkGray;
            btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignUp.FillColor = Color.FromArgb(46, 51, 73);
            btnSignUp.FocusedColor = Color.Gray;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(617, 215);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSignUp.Size = new Size(270, 68);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Signup";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // MilitarySelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1266, 593);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignin);
            Controls.Add(label1);
            Name = "MilitarySelection";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
    }
}