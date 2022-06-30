using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator_Frm : Form
    {
        public Calculator_Frm()
        {
            InitializeComponent();
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(textBox1.Text);
            double Num2 = double.Parse(textBox2.Text);
            string Result = (Num1 + Num2).ToString();
            textBox3.Text = Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(textBox1.Text);
            double Num2 = double.Parse(textBox2.Text);
            string Result = (Num1 - Num2).ToString();
            textBox3.Text = Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(textBox1.Text);
            double Num2 = double.Parse(textBox2.Text);
            string Result = (Num1 * Num2).ToString();
            textBox3.Text = Result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double Num1 = double.Parse(textBox1.Text);
            double Num2 = double.Parse(textBox2.Text);
            if (Num2 == 0) { MessageBox.Show("除數不可為0"); }
            else
            {
                string Result = (Num1 / Num2).ToString();
                textBox3.Text = Result;
            }
        }
    }
}
