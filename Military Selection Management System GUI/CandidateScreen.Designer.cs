namespace Military_Selection_Management_System_GUI
{
    partial class CandidateScreen
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Username = new Label();
            BtnDashboard = new Button();
            btnLeaderBoard = new Button();
            btnResult = new Button();
            btnMore = new Button();
            button4 = new Button();
            btnSettings = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnMore);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(btnLeaderBoard);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 689);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Username);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 144);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Military_Candidate_Image;
            pictureBox1.Location = new Point(65, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(65, 107);
            Username.Name = "Username";
            Username.Size = new Size(63, 22);
            Username.TabIndex = 1;
            Username.Text = "Name";
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.Transparent;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDashboard.ForeColor = Color.Green;
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(220, 36);
            BtnDashboard.TabIndex = 2;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnLeaderBoard
            // 
            btnLeaderBoard.BackColor = Color.Transparent;
            btnLeaderBoard.Dock = DockStyle.Top;
            btnLeaderBoard.FlatAppearance.BorderSize = 0;
            btnLeaderBoard.FlatStyle = FlatStyle.Flat;
            btnLeaderBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLeaderBoard.ForeColor = Color.Green;
            btnLeaderBoard.Location = new Point(0, 180);
            btnLeaderBoard.Name = "btnLeaderBoard";
            btnLeaderBoard.Size = new Size(220, 36);
            btnLeaderBoard.TabIndex = 2;
            btnLeaderBoard.Text = "LeaderBoard";
            btnLeaderBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnLeaderBoard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLeaderBoard.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Transparent;
            btnResult.Dock = DockStyle.Top;
            btnResult.FlatAppearance.BorderSize = 0;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResult.ForeColor = Color.Green;
            btnResult.Location = new Point(0, 216);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(220, 36);
            btnResult.TabIndex = 2;
            btnResult.Text = "Result";
            btnResult.TextAlign = ContentAlignment.MiddleLeft;
            btnResult.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnResult.UseVisualStyleBackColor = false;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.Transparent;
            btnMore.Dock = DockStyle.Top;
            btnMore.FlatAppearance.BorderSize = 0;
            btnMore.FlatStyle = FlatStyle.Flat;
            btnMore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.ForeColor = Color.Green;
            btnMore.Location = new Point(0, 252);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(220, 36);
            btnMore.TabIndex = 2;
            btnMore.Text = "More";
            btnMore.TextAlign = ContentAlignment.MiddleLeft;
            btnMore.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMore.UseVisualStyleBackColor = false;
            btnMore.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(0, 653);
            button4.Name = "button4";
            button4.Size = new Size(220, 36);
            button4.TabIndex = 2;
            button4.Text = "SignOut";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Green;
            btnSettings.Location = new Point(21, 592);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(180, 36);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += button3_Click;
            // 
            // CandidateScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1343, 689);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "CandidateScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CandidateScreen";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label Username;
        private Button BtnDashboard;
        private Button button4;
        private Button btnMore;
        private Button btnResult;
        private Button btnLeaderBoard;
        private Button btnSettings;
    }
}