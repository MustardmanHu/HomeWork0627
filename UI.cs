using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uno;

namespace WindowsFormsApp2
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gender_txt HelloForm = new Gender_txt();
            
            splitContainer1.Panel2.Controls.Clear();
            HelloForm.TopLevel = false;
            HelloForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(HelloForm);
            HelloForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 LoanForm = new Form1();
            
            splitContainer1.Panel2.Controls.Clear();
            LoanForm.TopLevel = false;
            LoanForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(LoanForm);
            LoanForm.Show();

            //DialogResult FS = LoanForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator_Frm CalForm = new Calculator_Frm();

            splitContainer1.Panel2.Controls.Clear();
            CalForm.TopLevel = false;
            CalForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(CalForm);
            CalForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            POS_FRM  LoanForm = new POS_FRM();

            splitContainer1.Panel2.Controls.Clear();
            LoanForm.TopLevel = false;
            LoanForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(LoanForm);
            LoanForm.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentStruct_FRM LoanForm = new StudentStruct_FRM();

            splitContainer1.Panel2.Controls.Clear();
            LoanForm.TopLevel = false;
            LoanForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(LoanForm);
            LoanForm.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentGrade_FRM LoanForm = new StudentGrade_FRM();

            splitContainer1.Panel2.Controls.Clear();
            LoanForm.TopLevel = false;
            LoanForm.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Add(LoanForm);
            LoanForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen Screen = new Screen();
            splitContainer1.Panel2.Controls.Clear();


           Screen.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(Screen);
            Screen.Show();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
