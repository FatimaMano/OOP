namespace Military_Selection_Management_System_GUI.User
{
    partial class LeaderBoard
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
            LeaderBoardHeadPanel = new Panel();
            LeaderboardHead = new Label();
            LeaderboardDataGrid = new DataGridView();
            LeaderBoardHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LeaderboardDataGrid).BeginInit();
            SuspendLayout();
            // 
            // LeaderBoardHeadPanel
            // 
            LeaderBoardHeadPanel.BackColor = Color.FromArgb(46, 51, 73);
            LeaderBoardHeadPanel.Controls.Add(LeaderboardHead);
            LeaderBoardHeadPanel.Location = new Point(0, 0);
            LeaderBoardHeadPanel.Name = "LeaderBoardHeadPanel";
            LeaderBoardHeadPanel.Size = new Size(1047, 118);
            LeaderBoardHeadPanel.TabIndex = 0;
            // 
            // LeaderboardHead
            // 
            LeaderboardHead.AutoSize = true;
            LeaderboardHead.Font = new Font("Broadway", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LeaderboardHead.ForeColor = Color.White;
            LeaderboardHead.Location = new Point(376, 38);
            LeaderboardHead.Name = "LeaderboardHead";
            LeaderboardHead.Size = new Size(288, 41);
            LeaderboardHead.TabIndex = 0;
            LeaderboardHead.Text = "Leaderboard";
            // 
            // LeaderboardDataGrid
            // 
            LeaderboardDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeaderboardDataGrid.Location = new Point(103, 184);
            LeaderboardDataGrid.Name = "LeaderboardDataGrid";
            LeaderboardDataGrid.RowHeadersWidth = 62;
            LeaderboardDataGrid.RowTemplate.Height = 33;
            LeaderboardDataGrid.Size = new Size(857, 453);
            LeaderboardDataGrid.TabIndex = 1;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LeaderboardDataGrid);
            Controls.Add(LeaderBoardHeadPanel);
            Name = "LeaderBoard";
            Size = new Size(1047, 688);
            LeaderBoardHeadPanel.ResumeLayout(false);
            LeaderBoardHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LeaderboardDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeaderBoardHeadPanel;
        private Label LeaderboardHead;
        private DataGridView LeaderboardDataGrid;
    }
}
