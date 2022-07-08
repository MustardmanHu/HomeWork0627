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
    public partial class StudentGrade_FRM : Form
    {
        public StudentGrade_FRM()
        {
            InitializeComponent();
        }
        string Data = "";
        int[] Score = new int[3] { 1, 2, 3 };
        public int[] Score1 { get => Score; set => Score = value; }
        int WholeCScore = 0;
        int TotalScore = 0;
        int Avg = 0;
        int WholeEScore = 0;
        int WholeMScore = 0;
        List<int> SavingCScore = new List<int>();
        List<int> SavingEScore = new List<int>();
        List<int> SavingMScore = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            Count++;
            string Name = Name_txt.Text;
            Score[0] = int.Parse(CN_txt.Text);
            Score[1] = int.Parse(ENG_txt.Text);
            Score[2] = int.Parse(MT_txt.Text);
            int 最高分 = Score.Max();
            int 最低分 = Score.Min();
            int 最高分科目 = Array.IndexOf(Score, 最高分);
            int 最低分科目 = Array.IndexOf(Score, 最低分);
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
            TotalScore = Score[0] + Score[1] + Score[2];
            Avg = TotalScore / 3;
            WholeCScore +=Score[0] ;
            WholeEScore += Score[1];
            WholeMScore += Score[2];
            SavingCScore.Add(Score[0]);
            SavingEScore.Add(Score[1]);
            SavingMScore.Add(Score[2]);
            Data = $"\r\n姓名:{FixedWidth(Name, 9, true)}國文:{FixedWidth(Score[0], 7, true)}" +
                    $"英文:{FixedWidth(Score[1], 7, true)}數學:{FixedWidth(Score[2], 7, true)}" +
                    $"總分{FixedWidth(TotalScore, 7, true)}平均{FixedWidth(Avg, 7, true)}" +
                    $"{FixedWidth(HScore, 7, true)}\t{FixedWidth(LScore, 7, true)}";
            Grade_txt.Text += $"{Data}";
        }
        int Count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Count++;
            Random ran1 = new Random(Count);
            Random ran2 = new Random(Count + 2);
            Random ran3 = new Random(Count + 5);
            string Name = Count.ToString();
            Score[0] = ran1.Next(0, 101);
            Score[1] = ran2.Next(0, 101);
            Score[2] = ran3.Next(0, 101);
            int 最高分 = Score.Max();
            int 最低分 = Score.Min();
            int 最高分科目 = Array.IndexOf(Score, 最高分);
            int 最低分科目 = Array.IndexOf(Score, 最低分);
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
                LScore = $"最低分科目 國文:{最低分}";
            }
            else
            {
                LScore = $"最低分科目 數學:{最低分}";
            }
            WholeCScore += Score[0];
            WholeEScore += Score[1];
            WholeMScore += Score[2];
            SavingCScore.Add(Score[0]);
            SavingEScore.Add(Score[1]);
            SavingMScore.Add(Score[2]);
            Data = $"\r\n姓名:{FixedWidth(Name, 9, true)}國文:{FixedWidth(Score[0], 7, true)}" +
                    $"英文:{FixedWidth(Score[1], 7, true)}數學:{FixedWidth(Score[2], 7, true)}" +
                    $"{FixedWidth(HScore, 7, true)}\t{FixedWidth(LScore, 7, true)}";
            Grade_txt.Text += $"{Data}";
            button3.Enabled = true;
        }
        static string FixedWidth(object value, int width, bool leftalign)
        {
            var s = value == null ? string.Empty : value.ToString();
            return leftalign ? s.PadRight(width) : s.PadRight(width);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Count++;
                Random ran1 = new Random(Count);
                Random ran2 = new Random(Count + 2);
                Random ran3 = new Random(Count + 5);
                string Name = Count.ToString();

                Score[0] = ran1.Next(0, 101);
                Score[1] = ran2.Next(0, 101);
                Score[2] = ran3.Next(0, 101);
                int 最高分 = Score.Max();
                int 最低分 = Score.Min();
                int 最高分科目 = Array.IndexOf(Score, 最高分);
                int 最低分科目 = Array.IndexOf(Score, 最低分);
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
                    LScore = $"最低分科目 國文:{最低分}";
                }
                else
                {
                    LScore = $"最低分科目 數學:{最低分}";
                }
                WholeCScore += Score[0];
                WholeEScore += Score[1];
                WholeMScore += Score[2];
                SavingCScore.Add(Score[0]);
                SavingEScore.Add(Score[1]);
                SavingMScore.Add(Score[2]);
                Data = $"\r\n姓名:{FixedWidth(Name, 9, true)}國文:{FixedWidth(Score[0], 7, true)}" +
                        $"英文:{FixedWidth(Score[1], 7, true)}數學:{FixedWidth(Score[2], 7, true)}" +
                        $"{FixedWidth(HScore, 7, true)} \t{FixedWidth(LScore, 7, true)}";
                Grade_txt.Text += $"{Data}";
                button3.Enabled = true;
            }
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            Count = 0;
            Score[0] =0;
            Score[1] =0;
            Score[2] =0;
            WholeCScore = 0;
            WholeEScore = 0;
            WholeMScore = 0;
            SavingCScore.Clear();
            SavingEScore.Clear();
            SavingMScore.Clear();
            Data = $"";
            Grade_txt.Text = $"";
            button3.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            統計_txt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int AVGCScore = WholeCScore / Count;
            int AVGEScore = WholeEScore/Count;
            int AVGMScore=WholeMScore/Count;
            string HCScore=SavingCScore.Max().ToString();
            string HEScore=SavingEScore.Max().ToString();
            string HMScore=SavingMScore.Max().ToString();
            string LCScore = SavingCScore.Min().ToString();
            string LEScore = SavingEScore.Min().ToString();
            string LMScore = SavingMScore.Min().ToString();

            string 總分 = $":{WholeCScore}\t{WholeEScore}\t:{WholeMScore}";
            string 平均 = $"{AVGCScore}\t{AVGEScore}\t{AVGMScore}";
            string 最高分 = $"{HCScore}\t{HEScore}\t{HMScore}";
            string 最低分 = $"{LCScore}\t{LEScore}\t{LMScore}";

            //string resultC = $"總分:{WholeCScore}\r\n平均:{AVGCScore}\r\n最高分:{HCScore}\r\n最低分:{LCScore}";
            //string resultE = $"總分:{WholeEScore}\r\n平均:{AVGEScore}\r\n最高分:{HEScore}\r\n最低分:{LEScore}";
            //string resultM = $"總分:{WholeMScore}\r\n平均:{AVGMScore}\r\n最高分:{HMScore}\r\n最低分:{LMScore}";
            統計_txt.Text = $"總分:{總分}\r\n平均:{平均}\r\n最高分:{最高分}\r\n最低分:{最低分}\r\n";

            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
