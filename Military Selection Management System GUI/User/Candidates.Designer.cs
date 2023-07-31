namespace Military_Selection_Management_System_GUI.User
{
    partial class Candidates
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            addCandidateToolStripMenuItem = new ToolStripMenuItem();
            searchCandidateToolStripMenuItem = new ToolStripMenuItem();
            deleteCandidateToolStripMenuItem = new ToolStripMenuItem();
            applicationStatusToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 102);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addCandidateToolStripMenuItem, searchCandidateToolStripMenuItem, deleteCandidateToolStripMenuItem, applicationStatusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1123, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addCandidateToolStripMenuItem
            // 
            addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            addCandidateToolStripMenuItem.Size = new Size(147, 29);
            addCandidateToolStripMenuItem.Text = "Add Candidate";
            addCandidateToolStripMenuItem.Click += addCandidateToolStripMenuItem_Click;
            // 
            // searchCandidateToolStripMenuItem
            // 
            searchCandidateToolStripMenuItem.Name = "searchCandidateToolStripMenuItem";
            searchCandidateToolStripMenuItem.Size = new Size(165, 29);
            searchCandidateToolStripMenuItem.Text = "Search Candidate";
            // 
            // deleteCandidateToolStripMenuItem
            // 
            deleteCandidateToolStripMenuItem.Name = "deleteCandidateToolStripMenuItem";
            deleteCandidateToolStripMenuItem.Size = new Size(163, 29);
            deleteCandidateToolStripMenuItem.Text = "Delete Candidate";
            // 
            // applicationStatusToolStripMenuItem
            // 
            applicationStatusToolStripMenuItem.Name = "applicationStatusToolStripMenuItem";
            applicationStatusToolStripMenuItem.Size = new Size(150, 29);
            applicationStatusToolStripMenuItem.Text = "Top Candidates";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1123, 587);
            panel2.TabIndex = 1;
            // 
            // Candidates
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Candidates";
            Size = new Size(1123, 689);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addCandidateToolStripMenuItem;
        private ToolStripMenuItem searchCandidateToolStripMenuItem;
        private ToolStripMenuItem deleteCandidateToolStripMenuItem;
        private ToolStripMenuItem applicationStatusToolStripMenuItem;
        private Panel panel2;
    }
}
