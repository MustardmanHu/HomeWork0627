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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Month = "";
        public void button1_Click(object sender, EventArgs e)
        {
            bool WLT = int.TryParse(WholeLoan_txt.Text, out int A);
            bool PCT = int.TryParse(Percent_txt.Text, out int B);
            bool DLT = int.TryParse(DeadLine_txt.Text, out int C);
            bool HDT = int.TryParse(Head_txt.Text, out int D);
            if (WLT == false || PCT == false || DLT == false || HDT == false)
            {
                MessageBox.Show("請輸入數值後再計算");
            }
            else
            {
                int WL = int.Parse(WholeLoan_txt.Text);
                int PC = int.Parse(Percent_txt.Text);
                int DL = int.Parse(DeadLine_txt.Text);
                int HD = int.Parse(Head_txt.Text);
                double M1 = PC * 0.01 / 12;//利率換做月利率%
                double M2 = Math.Pow((1 + M1), DL * 12);//(1+月利率)的期數次方
                double M3 = (M2 * M1) / (M2 - 1);//M2*月利率/(M2-1)
                double M4 = WL - HD;//本金-頭期款
                double M5 = M4 * M3;//月付額           
                Month = M5.ToString();
                if (Month == "")
                {
                    MessageBox.Show("請輸入數字");
                }
                else
                {
                    MessageBox.Show(Month);
                }
            }
        }
        string Total = "";
        public void button2_Click(object sender, EventArgs e)
        {
            bool WLT = int.TryParse(WholeLoan_txt.Text, out int A);
            bool PCT = int.TryParse(Percent_txt.Text, out int B);
            bool DLT = int.TryParse(DeadLine_txt.Text, out int C);
            bool HDT = int.TryParse(Head_txt.Text, out int D);
            if (WLT == false || PCT == false || DLT == false || HDT == false)
            {
                MessageBox.Show("請輸入數值後再計算");
            }
            else
            {
                int WL = int.Parse(WholeLoan_txt.Text);
                int PC = int.Parse(Percent_txt.Text);
                int DL = int.Parse(DeadLine_txt.Text);
                int HD = int.Parse(Head_txt.Text);
                double M1 = PC * 0.01 / 12;//利率換做月利率%
                double M2 = Math.Pow((1 + M1), DL * 12);//(1+月利率)的期數次方
                double M3 = (M2 * M1) / (M2 - 1);//M2*月利率/(M2-1)
                double M4 = WL - HD;//本金-頭期款
                double M5 = M4 * M3;//月付額       
                double M6 = M5 * 12 * DL;
                Total = M6.ToString();
                if (Total == "")
                {
                    MessageBox.Show("請輸入數字");
                }
                else
                {
                    MessageBox.Show(Total);
                }
            }
        }
    private void button3_Click(object sender, EventArgs e)
        {
            Loan_FRM Report = new Loan_FRM();

            if (Total == "" || Month == "")
            {
                MessageBox.Show("請先計算總付款和月付額");
            }
            else
            {
                Report.WL_txt.Text = WholeLoan_txt.Text;
                Report.PC_txt.Text = Percent_txt.Text;
                Report.DL_txt.Text = DeadLine_txt.Text;
                Report.Total_txt.Text = Total;
                Report.MP_txt.Text = Month;
                Report.Show();
            }
        }
    }
    public partial class CalculateClass
    {
        double Month = 0;
        public int  MonthlyPay()
        {
            Form1 Loan_FRm = new Form1();
            int WL =int.Parse(Loan_FRm.WholeLoan_txt.Text);
            int PC = int.Parse(Loan_FRm.Percent_txt.Text);
            int DL= int.Parse(Loan_FRm.DeadLine_txt.Text);
            int HD= int.Parse(Loan_FRm.Head_txt.Text);

            double M1 = PC * 0.01/12;//月利率換做%
            double M2 = Math.Pow((1 + M1), DL * 12);//(1+月利率的期數次方
            double M3 = (M1 * PC)/(M2-1);//M2*月利率/(M2-1)
            double M4 = WL - HD;//本金-頭期款
            double M5 = M4 * M3;//月付額           
            Month = M5;
            return Convert.ToInt32(Month);
        }
    }
}
