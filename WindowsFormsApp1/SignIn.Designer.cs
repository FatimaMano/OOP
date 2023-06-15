
namespace WindowsFormsApp1
{
    partial class SignIn
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
            this.UserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "SignInSignUpApplication";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(122, 179);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(89, 20);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "UserName:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(122, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 20);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(257, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 26);
            this.textBox4.TabIndex = 9;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(444, 346);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(120, 39);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(180, 346);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 39);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
    }
}