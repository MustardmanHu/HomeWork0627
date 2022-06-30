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
    public partial class Gender_txt : Form
    {
        public Gender_txt()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            string Name = Name_txt.Text;
            string Eng = EngName_txt.Text;
            string gender = textBox3.Text;
            string Zodiac = Zodiac_txt.Text;
            MessageBox.Show( $"祝{Name}\n{Eng}\n{gender}生日\n" +
                $"{Zodiac}座\n的你\n生日快樂!!"   );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            string Name = Name_txt.Text;
            string Eng = EngName_txt.Text;
            string gender = textBox3.Text;
            string Zodiac = Zodiac_txt.Text;
            MessageBox.Show($"噢不!\n{Name}\n{Eng}\n{gender}生日\n" +
                $"{Zodiac}座\n今天不是你的生日." );
                
        }
    }
}
