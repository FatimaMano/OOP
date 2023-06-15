
namespace FirstDesktopApp
{
    partial class Form1
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
            this.AddButton = new System.Windows.Forms.Button();
            this.SecondBox = new System.Windows.Forms.TextBox();
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MultiplyBox = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.DivideBox = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 259);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 49);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SecondBox
            // 
            this.SecondBox.Location = new System.Drawing.Point(278, 176);
            this.SecondBox.Name = "SecondBox";
            this.SecondBox.Size = new System.Drawing.Size(210, 26);
            this.SecondBox.TabIndex = 1;
            this.SecondBox.TextChanged += new System.EventHandler(this.ggf);
            // 
            // FirstBox
            // 
            this.FirstBox.Location = new System.Drawing.Point(16, 174);
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.Size = new System.Drawing.Size(210, 26);
            this.FirstBox.TabIndex = 2;
            this.FirstBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(12, 134);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(128, 20);
            this.FirstLabel.TabIndex = 3;
            this.FirstLabel.Text = "Enter First Value";
            this.FirstLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Second Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MultiplyBox
            // 
            this.MultiplyBox.Location = new System.Drawing.Point(367, 259);
            this.MultiplyBox.Name = "MultiplyBox";
            this.MultiplyBox.Size = new System.Drawing.Size(121, 49);
            this.MultiplyBox.TabIndex = 6;
            this.MultiplyBox.Text = "Multiply";
            this.MultiplyBox.UseVisualStyleBackColor = true;
            this.MultiplyBox.Click += new System.EventHandler(this.MultiplyBox_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(189, 259);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(121, 49);
            this.SubtractButton.TabIndex = 7;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // DivideBox
            // 
            this.DivideBox.Location = new System.Drawing.Point(554, 259);
            this.DivideBox.Name = "DivideBox";
            this.DivideBox.Size = new System.Drawing.Size(121, 49);
            this.DivideBox.TabIndex = 8;
            this.DivideBox.Text = "Divide";
            this.DivideBox.UseVisualStyleBackColor = true;
            this.DivideBox.Click += new System.EventHandler(this.DivideBox_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Location = new System.Drawing.Point(390, 18);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Padding = new System.Windows.Forms.Padding(50, 10, 50, 0);
            this.ResultBox.Size = new System.Drawing.Size(159, 30);
            this.ResultBox.TabIndex = 9;
            this.ResultBox.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.DivideBox);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.MultiplyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.FirstBox);
            this.Controls.Add(this.SecondBox);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SecondBox;
        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MultiplyBox;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button DivideBox;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Label label3;
    }
}

