namespace Military_Selection_Management_System_GUI.User
{
    partial class Feedback
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
            FeedbackHeadPanel = new Panel();
            FeedbackHead = new Label();
            lblFeedback = new Guna.UI2.WinForms.Guna2HtmlLabel();
            FeebackText = new TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            FeedbackHeadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FeedbackHeadPanel
            // 
            FeedbackHeadPanel.BackColor = Color.FromArgb(46, 51, 73);
            FeedbackHeadPanel.Controls.Add(FeedbackHead);
            FeedbackHeadPanel.Location = new Point(0, 3);
            FeedbackHeadPanel.Name = "FeedbackHeadPanel";
            FeedbackHeadPanel.Size = new Size(1047, 118);
            FeedbackHeadPanel.TabIndex = 0;
            // 
            // FeedbackHead
            // 
            FeedbackHead.AutoSize = true;
            FeedbackHead.Font = new Font("Broadway", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FeedbackHead.ForeColor = Color.White;
            FeedbackHead.Location = new Point(414, 39);
            FeedbackHead.Name = "FeedbackHead";
            FeedbackHead.Size = new Size(218, 41);
            FeedbackHead.TabIndex = 2;
            FeedbackHead.Text = "Feedback";
            // 
            // lblFeedback
            // 
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.Location = new Point(382, 270);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(276, 31);
            lblFeedback.TabIndex = 1;
            lblFeedback.Text = "Give us Your Feedback";
            // 
            // FeebackText
            // 
            FeebackText.Location = new Point(268, 353);
            FeebackText.Name = "FeebackText";
            FeebackText.Size = new Size(539, 31);
            FeebackText.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(46, 51, 73);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(724, 588);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(270, 68);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSave);
            Controls.Add(FeebackText);
            Controls.Add(lblFeedback);
            Controls.Add(FeedbackHeadPanel);
            Name = "Feedback";
            Size = new Size(1047, 688);
            FeedbackHeadPanel.ResumeLayout(false);
            FeedbackHeadPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel FeedbackHeadPanel;
        private Label FeedbackHead;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFeedback;
        private TextBox FeebackText;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
