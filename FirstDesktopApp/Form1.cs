using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddNumbers();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = FirstLabel.Text + label2.Text;
        }

        private void ggf(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void AddNumbers()
        {
            if (int.Parse(FirstBox.Text) == 0 || int.Parse(SecondBox.Text) == 0) return;
            string v1 = FirstBox.Text;
            string v2 = SecondBox.Text;
            double result = double.Parse(v1) + double.Parse(v2);
            label3.Text = "" + result;
        }
        public void DivideNumbers()
        {
            string v1 = FirstBox.Text;
            string v2 = SecondBox.Text;
            double result = double.Parse(v1) / double.Parse(v2);
            label3.Text = "" + result;
        }
        public void MultiplyNumbers()
        {
            string v1 = FirstBox.Text;
            string v2 = SecondBox.Text;
            double result = double.Parse(v1) * double.Parse(v2);
            label3.Text = "" + result;
        }
        public void SubtractNumbers()
        {
            string v1 = FirstBox.Text;
            string v2 = SecondBox.Text;
            double result = double.Parse(v1) - double.Parse(v2);
            label3.Text = "" + result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNumbers();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            SubtractNumbers();
        }

        private void MultiplyBox_Click(object sender, EventArgs e)
        {
            MultiplyNumbers();
        }

        private void DivideBox_Click(object sender, EventArgs e)
        {
            DivideNumbers();
        }
    }
}
