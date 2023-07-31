namespace Military_Selection_Management_System_GUI.User
{
    partial class Application
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
            components = new System.ComponentModel.Container();
            ApplicationHeadPanel = new Panel();
            ApplicationHead = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            ApplicationBodyPanel = new Panel();
            ApplicationHeadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ApplicationHeadPanel
            // 
            ApplicationHeadPanel.BackColor = Color.FromArgb(46, 51, 73);
            ApplicationHeadPanel.Controls.Add(ApplicationHead);
            ApplicationHeadPanel.Dock = DockStyle.Top;
            ApplicationHeadPanel.Location = new Point(0, 0);
            ApplicationHeadPanel.Name = "ApplicationHeadPanel";
            ApplicationHeadPanel.Size = new Size(1047, 118);
            ApplicationHeadPanel.TabIndex = 0;
            // 
            // ApplicationHead
            // 
            ApplicationHead.AutoSize = true;
            ApplicationHead.Font = new Font("Broadway", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicationHead.ForeColor = Color.White;
            ApplicationHead.Location = new Point(394, 39);
            ApplicationHead.Name = "ApplicationHead";
            ApplicationHead.Size = new Size(258, 41);
            ApplicationHead.TabIndex = 0;
            ApplicationHead.Text = "Application";
            // 
            // ApplicationBodyPanel
            // 
            ApplicationBodyPanel.Dock = DockStyle.Fill;
            ApplicationBodyPanel.Location = new Point(0, 118);
            ApplicationBodyPanel.Name = "ApplicationBodyPanel";
            ApplicationBodyPanel.Size = new Size(1047, 570);
            ApplicationBodyPanel.TabIndex = 1;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ApplicationBodyPanel);
            Controls.Add(ApplicationHeadPanel);
            Name = "Application";
            Size = new Size(1047, 688);
            ApplicationHeadPanel.ResumeLayout(false);
            ApplicationHeadPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ApplicationHeadPanel;
        private Label ApplicationHead;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel ApplicationBodyPanel;
    }
}
