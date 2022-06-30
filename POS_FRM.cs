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
    public partial class POS_FRM : Form
    {
        public POS_FRM()
        {
            InitializeComponent();
            TotalPrice_txt.Text =
            Cart1_txt.Text = "";
        }
       
        int CountG1 = 0;
        int CountG2 = 0;
        int CountG3 = 0;
        int CountG4 = 0;
        private void Good1_Click(object sender, EventArgs e)
        {
            CountG1++;
            TotalPrice_txt.Text = (CountG1 * 150 + CountG2 * 180 + CountG3 * 320 + CountG4 * 380).ToString();
            Cart1_txt.Text = $"\nGood1x{CountG1}件,共{CountG1*150}元";
        }

        private void Good2_Click(object sender, EventArgs e)
        {
           
            CountG2++;

            TotalPrice_txt.Text = (CountG1 * 150 + CountG2 * 180 + CountG3 * 320 + CountG4 * 380).ToString();
            Cart2_txt.Text = $"\nGood2 x{CountG2}件,共:{CountG2 * 180}元";
        }

        private void Good3_Click(object sender, EventArgs e)
        {
            
            CountG3++;
           
            TotalPrice_txt.Text = (CountG1 * 150 + CountG2 * 180 + CountG3 * 320 + CountG4 * 380).ToString();
            Cart3_txt.Text = $"\nGood3 x{CountG3}件,共:{CountG3 * 320}元";
        }

        private void Good4_Click(object sender, EventArgs e)
        {
         
            CountG4++;
            TotalPrice_txt.Text = (CountG1 * 150 + CountG2 * 180 + CountG3 * 320 + CountG4 * 380).ToString();
            Cart4_txt.Text = $"\nGood4 x{CountG4}件,共:{CountG4 * 380}元";
        }
        public string Result()
        {
            string result = $"Good1x{CountG1},共{CountG1*150}元\nGood2x{CountG2},共{CountG2*180}元\n" +
                $"Good3x{CountG3},共{CountG3*320}元\nGood4x{CountG4},共{CountG4*380}元";
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountG1 = 0;
            CountG2 = 0;
            CountG3 = 0;
            CountG4 = 0;
            TotalPrice_txt.Text = (CountG1 * 150 + CountG2 * 180 + CountG3 * 320 + CountG4 * 380).ToString();
            Cart4_txt.Text = "";
            Cart3_txt.Text = "";
            Cart2_txt.Text = "";
            Cart1_txt.Text ="";
        }

        private void CashPay_Click(object sender, EventArgs e)
        {
            string Price = TotalPrice_txt.Text;
            MessageBox.Show($"現金付款,共{Price}元");
        }
        private void CreditCard_Pay_Click(object sender, EventArgs e)
        {
            double Price = double.Parse(TotalPrice_txt.Text);
            string CreditcardPrice = (Price * 0.9).ToString(); 
            MessageBox.Show($"信用卡付款,共{CreditcardPrice}元");
        }
    }
}
//G1=150,G2=180,G3=320,G3=380