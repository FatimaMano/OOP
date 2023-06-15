
namespace WindowsFormsApp1
{
    partial class SignInSignUpApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.signInbutton = new System.Windows.Forms.CheckBox();
            this.signUpButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(98, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignInSignUpApplication";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // signInbutton
            // 
            this.signInbutton.AutoSize = true;
            this.signInbutton.BackColor = System.Drawing.SystemColors.Info;
            this.signInbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signInbutton.Location = new System.Drawing.Point(217, 194);
            this.signInbutton.Name = "signInbutton";
            this.signInbutton.Padding = new System.Windows.Forms.Padding(10);
            this.signInbutton.Size = new System.Drawing.Size(101, 44);
            this.signInbutton.TabIndex = 3;
            this.signInbutton.Text = "SignIn";
            this.signInbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInbutton.UseVisualStyleBackColor = false;
            this.signInbutton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.BackColor = System.Drawing.SystemColors.Info;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signUpButton.Location = new System.Drawing.Point(452, 194);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Padding = new System.Windows.Forms.Padding(10);
            this.signUpButton.Size = new System.Drawing.Size(108, 44);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "SignUp";
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // SignInSignUpApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInbutton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "SignInSignUpApplication";
            this.Text = "SignInSignUpApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox signInbutton;
        private System.Windows.Forms.CheckBox signUpButton;
    }
}