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
    public partial class StudentStruct_FRM : Form
    {
        public StudentStruct_FRM()
        {
            InitializeComponent();
        }
        string Data = "";
        int[] Score =new int[3] { 1, 2, 3 };

        public int[] Score1 { get => Score; set => Score = value; }

        public void button1_Click(object sender, EventArgs e)
        {
            string Name = Name_txt.Text;
           Score[0]=int.Parse(CN_txt.Text);
           Score[1]  = int.Parse(ENG_txt.Text);
           Score[2]= int.Parse(MT_txt.Text);
           Data = $"姓名:{Name}\t 國文:{Score[0]} \t 英文:{Score[1]}\t 數學:{Score[2]}";
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Grade_txt.Text = Data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score[0] = int.Parse(CN_txt.Text);
            Score[1] = int.Parse(ENG_txt.Text);
            Score[2] = int.Parse(MT_txt.Text);
            int 最高分 =Score.Max();
            int 最低分 = Score.Min();
            int 最高分科目=Array.IndexOf(Score, 最高分);
            int 最低分科目= Array.IndexOf(Score, 最低分);
            string HScore = "";
            string LScore = "";
            if (最高分科目 == 0)
            {
                HScore = $"最高分科目 國文:{最高分}";
            }
            else if (最高分科目 == 1)
            {
               HScore = $"最高分科目 英文:{最高分}";
            }
            else
            { HScore = $"最高分科目 數學:{最高分}"; }

            if (最低分科目 == 0)
            {
                LScore = $"最低分科目 國文:{最低分}";
            }
            else if (最低分科目 == 1)
            {
                LScore = $"最低分科目 英文:{最低分}";
            }
            else
            {
                LScore = $"最低分科目 數學:{最低分}";
            }
            textBox2.Text =$"{HScore}\n  {LScore}";
        }
    }
   





        
}
