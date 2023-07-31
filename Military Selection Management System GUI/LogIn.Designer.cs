namespace Military_Selection_Management_System_GUI
{
    partial class LogIn
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
            IDText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordText = new TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // IDText
            // 
            IDText.Location = new Point(133, 286);
            IDText.Name = "IDText";
            IDText.Size = new Size(311, 31);
            IDText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(133, 233);
            label2.Name = "label2";
            label2.Size = new Size(44, 38);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(133, 353);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(133, 406);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(311, 31);
            PasswordText.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(46, 51, 73);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(158, 497);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(270, 68);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LogIn";
            btnLogin.Click += btnLogin_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 668);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(PasswordText);
            Controls.Add(label2);
            Controls.Add(IDText);
            ForeColor = Color.Black;
            Name = "LogIn";
            Text = "    ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox IDText;
        private Label label2;
        private Label label3;
        private TextBox PasswordText;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}