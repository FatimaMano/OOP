namespace Military_Selection_Management_System_GUI.User
{
    partial class PersonalInformation
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
            AddressText = new RichTextBox();
            Email = new Label();
            PhoneNumberText = new TextBox();
            Address = new Label();
            EmailText = new TextBox();
            PhoneNumber = new Label();
            AgeText = new TextBox();
            Age = new Label();
            NameText = new TextBox();
            lblName = new Label();
            IDText = new TextBox();
            ID = new Label();
            lblPersonalInformation = new Label();
            SuspendLayout();
            // 
            // AddressText
            // 
            AddressText.Location = new Point(583, 385);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(318, 119);
            AddressText.TabIndex = 41;
            AddressText.Text = "";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = Color.White;
            Email.Location = new Point(583, 113);
            Email.Name = "Email";
            Email.Size = new Size(181, 29);
            Email.TabIndex = 40;
            Email.Text = "Email Address";
            // 
            // PhoneNumberText
            // 
            PhoneNumberText.Location = new Point(583, 251);
            PhoneNumberText.Name = "PhoneNumberText";
            PhoneNumberText.Size = new Size(311, 31);
            PhoneNumberText.TabIndex = 39;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Address.ForeColor = Color.White;
            Address.Location = new Point(583, 324);
            Address.Name = "Address";
            Address.Size = new Size(109, 29);
            Address.TabIndex = 38;
            Address.Text = "Address";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(583, 155);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(311, 31);
            EmailText.TabIndex = 37;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber.ForeColor = Color.White;
            PhoneNumber.Location = new Point(583, 204);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(189, 29);
            PhoneNumber.TabIndex = 36;
            PhoneNumber.Text = "Phone Number";
            // 
            // AgeText
            // 
            AgeText.Location = new Point(145, 417);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(311, 31);
            AgeText.TabIndex = 35;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Age.ForeColor = Color.White;
            Age.Location = new Point(145, 343);
            Age.Name = "Age";
            Age.Size = new Size(58, 29);
            Age.TabIndex = 34;
            Age.Text = "Age";
            // 
            // NameText
            // 
            NameText.Location = new Point(145, 262);
            NameText.Name = "NameText";
            NameText.Size = new Size(311, 31);
            NameText.TabIndex = 33;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(145, 204);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 29);
            lblName.TabIndex = 32;
            lblName.Text = "Name";
            // 
            // IDText
            // 
            IDText.Location = new Point(145, 155);
            IDText.Name = "IDText";
            IDText.Size = new Size(311, 31);
            IDText.TabIndex = 29;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ID.ForeColor = Color.White;
            ID.Location = new Point(145, 113);
            ID.Name = "ID";
            ID.Size = new Size(42, 29);
            ID.TabIndex = 28;
            ID.Text = "ID";
            // 
            // lblPersonalInformation
            // 
            lblPersonalInformation.AutoSize = true;
            lblPersonalInformation.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersonalInformation.ForeColor = Color.White;
            lblPersonalInformation.Location = new Point(313, 45);
            lblPersonalInformation.Name = "lblPersonalInformation";
            lblPersonalInformation.Size = new Size(351, 38);
            lblPersonalInformation.TabIndex = 42;
            lblPersonalInformation.Text = "Personal Information";
            // 
            // PersonalInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(lblPersonalInformation);
            Controls.Add(AddressText);
            Controls.Add(Email);
            Controls.Add(PhoneNumberText);
            Controls.Add(Address);
            Controls.Add(EmailText);
            Controls.Add(PhoneNumber);
            Controls.Add(AgeText);
            Controls.Add(Age);
            Controls.Add(NameText);
            Controls.Add(lblName);
            Controls.Add(IDText);
            Controls.Add(ID);
            Name = "PersonalInformation";
            Size = new Size(1047, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox AddressText;
        private Label Email;
        private TextBox PhoneNumberText;
        private Label Address;
        private TextBox EmailText;
        private Label PhoneNumber;
        private TextBox AgeText;
        private Label Age;
        private TextBox NameText;
        private Label lblName;
        private TextBox IDText;
        private Label ID;
        private Label lblPersonalInformation;
    }
}
