namespace Military_Selection_Management_System_GUI.User
{
    partial class AdmissionStatus
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
            ApplicationStatusHeadPanel = new Panel();
            ApplicationStatusHead = new Label();
            ApplicationStatusHeadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ApplicationStatusHeadPanel
            // 
            ApplicationStatusHeadPanel.BackColor = Color.FromArgb(46, 51, 73);
            ApplicationStatusHeadPanel.Controls.Add(ApplicationStatusHead);
            ApplicationStatusHeadPanel.Location = new Point(3, 3);
            ApplicationStatusHeadPanel.Name = "ApplicationStatusHeadPanel";
            ApplicationStatusHeadPanel.Size = new Size(1044, 118);
            ApplicationStatusHeadPanel.TabIndex = 0;
            // 
            // ApplicationStatusHead
            // 
            ApplicationStatusHead.AutoSize = true;
            ApplicationStatusHead.Font = new Font("Broadway", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicationStatusHead.ForeColor = Color.White;
            ApplicationStatusHead.Location = new Point(324, 39);
            ApplicationStatusHead.Name = "ApplicationStatusHead";
            ApplicationStatusHead.Size = new Size(396, 41);
            ApplicationStatusHead.TabIndex = 1;
            ApplicationStatusHead.Text = "Application Status";
            // 
            // AdmissionStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ApplicationStatusHeadPanel);
            Name = "AdmissionStatus";
            Size = new Size(1047, 688);
            ApplicationStatusHeadPanel.ResumeLayout(false);
            ApplicationStatusHeadPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ApplicationStatusHeadPanel;
        private Label ApplicationStatusHead;
    }
}
