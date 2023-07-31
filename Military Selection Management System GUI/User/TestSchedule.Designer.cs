namespace Military_Selection_Management_System_GUI.User
{
    partial class TestSchedule
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
            TestScheduleHeadPanel = new Panel();
            TestScheduleHead = new Label();
            TestScheduleHeadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TestScheduleHeadPanel
            // 
            TestScheduleHeadPanel.BackColor = Color.FromArgb(46, 51, 73);
            TestScheduleHeadPanel.Controls.Add(TestScheduleHead);
            TestScheduleHeadPanel.Location = new Point(3, 3);
            TestScheduleHeadPanel.Name = "TestScheduleHeadPanel";
            TestScheduleHeadPanel.Size = new Size(1044, 118);
            TestScheduleHeadPanel.TabIndex = 0;
            // 
            // TestScheduleHead
            // 
            TestScheduleHead.AutoSize = true;
            TestScheduleHead.Font = new Font("Broadway", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TestScheduleHead.ForeColor = Color.White;
            TestScheduleHead.Location = new Point(373, 39);
            TestScheduleHead.Name = "TestScheduleHead";
            TestScheduleHead.Size = new Size(299, 41);
            TestScheduleHead.TabIndex = 3;
            TestScheduleHead.Text = "Test Schedule";
            // 
            // TestSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(TestScheduleHeadPanel);
            Name = "TestSchedule";
            Size = new Size(1047, 688);
            TestScheduleHeadPanel.ResumeLayout(false);
            TestScheduleHeadPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TestScheduleHeadPanel;
        private Label TestScheduleHead;
    }
}
