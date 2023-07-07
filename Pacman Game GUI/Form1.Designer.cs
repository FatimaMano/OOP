
namespace Pacman_Game_GUI
{
    partial class PacmanGame
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
            this.components = new System.ComponentModel.Container();
            this.YellowGhost = new System.Windows.Forms.PictureBox();
            this.PinkGhost = new System.Windows.Forms.PictureBox();
            this.RedGhost = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall5 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.YellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            this.SuspendLayout();
            // 
            // YellowGhost
            // 
            this.YellowGhost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YellowGhost.Image = global::Pacman_Game_GUI.Properties.Resources.yellow_guy;
            this.YellowGhost.Location = new System.Drawing.Point(747, 56);
            this.YellowGhost.Name = "YellowGhost";
            this.YellowGhost.Size = new System.Drawing.Size(27, 41);
            this.YellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowGhost.TabIndex = 0;
            this.YellowGhost.TabStop = false;
            // 
            // PinkGhost
            // 
            this.PinkGhost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PinkGhost.Image = global::Pacman_Game_GUI.Properties.Resources.pink_guy;
            this.PinkGhost.Location = new System.Drawing.Point(222, 512);
            this.PinkGhost.Name = "PinkGhost";
            this.PinkGhost.Size = new System.Drawing.Size(27, 41);
            this.PinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PinkGhost.TabIndex = 1;
            this.PinkGhost.TabStop = false;
            // 
            // RedGhost
            // 
            this.RedGhost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RedGhost.Image = global::Pacman_Game_GUI.Properties.Resources.red_guy;
            this.RedGhost.Location = new System.Drawing.Point(330, 117);
            this.RedGhost.Name = "RedGhost";
            this.RedGhost.Size = new System.Drawing.Size(27, 41);
            this.RedGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedGhost.TabIndex = 2;
            this.RedGhost.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Pacman_Game_GUI.Properties.Resources.left;
            this.pictureBox1.Location = new System.Drawing.Point(330, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Wall3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wall3.Location = new System.Drawing.Point(222, 33);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(443, 10);
            this.Wall3.TabIndex = 4;
            this.Wall3.TabStop = false;
            this.Wall3.Tag = "Wall";
            this.Wall3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Wall5
            // 
            this.Wall5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Wall5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wall5.Location = new System.Drawing.Point(222, 472);
            this.Wall5.Name = "Wall5";
            this.Wall5.Size = new System.Drawing.Size(443, 10);
            this.Wall5.TabIndex = 5;
            this.Wall5.TabStop = false;
            this.Wall5.Tag = "Wall";
            this.Wall5.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Wall4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wall4.Location = new System.Drawing.Point(222, 239);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(443, 10);
            this.Wall4.TabIndex = 6;
            this.Wall4.TabStop = false;
            this.Wall4.Tag = "Wall";
            this.Wall4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Wall1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wall1.Location = new System.Drawing.Point(797, 106);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(15, 326);
            this.Wall1.TabIndex = 7;
            this.Wall1.TabStop = false;
            this.Wall1.Tag = "Wall";
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Wall2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wall2.Location = new System.Drawing.Point(111, 106);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(15, 326);
            this.Wall2.TabIndex = 8;
            this.Wall2.TabStop = false;
            this.Wall2.Tag = "Wall";
            // 
            // Coin
            // 
            this.Coin.Image = global::Pacman_Game_GUI.Properties.Resources.coin;
            this.Coin.Location = new System.Drawing.Point(529, 350);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(40, 37);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 9;
            this.Coin.TabStop = false;
            this.Coin.Tag = "Coin";
            // 
            // PacmanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(948, 591);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall5);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RedGhost);
            this.Controls.Add(this.PinkGhost);
            this.Controls.Add(this.YellowGhost);
            this.Name = "PacmanGame";
            this.Tag = "Wall";
            this.Text = "Pacman Game";
            this.Load += new System.EventHandler(this.PacmanGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox YellowGhost;
        private System.Windows.Forms.PictureBox PinkGhost;
        private System.Windows.Forms.PictureBox RedGhost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Wall3;
        private System.Windows.Forms.PictureBox Wall5;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox Wall1;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox Coin;
    }
}

