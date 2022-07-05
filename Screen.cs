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
    public partial class Screen : Form
    {
        int Pic_方向;
        int x;
        int y;
        int Start = 0;
        public Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            if (Start == 0)
            {
                Start = 1;
                Pic_方向 = ran.Next(1, 5);
                this.Cursor = new Cursor(Cursor.Current.Handle);
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
                pictureBox1.Top = 0;
                pictureBox1.Left = 0;
            }

             if (this.pictureBox1.Left <= 0 || this.pictureBox1.Left >= this.Width - 1.2*this.pictureBox1.Width ||
                 this.pictureBox1.Top <= 0 || this.pictureBox1.Top >= this.Height - 2*this.pictureBox1.Height)
            //彈到邊框的if條件式
            {
                if (Pic_方向 == 1)
                {
                    Pic_方向 = 4;
                }
                else if (Pic_方向 == 4)
                {
                    Pic_方向 = 3;
                }
                else if (Pic_方向 == 3)
                {
                    Pic_方向 = 2;
                }
                else if (Pic_方向 == 2)
                {
                    Pic_方向 = 1;
                }

            }
            switch (Pic_方向)
            {
                case 1:
                    右下();
                    break;
                case 2:
                    左下();
                    break;
                case 3:
                    左上();
                    break;
                case 4:
                    右上();
                    break;
            }
            MoveCursor();
        }
        
        void 左上()
        {
            pictureBox1.Top--;
            pictureBox1.Left--;
        }
        void 右上()
        {
            pictureBox1.Top--;
            pictureBox1.Left++;
        }
        void 左下()
        {
            pictureBox1.Top++;
            pictureBox1.Left--;
        }
        void 右下()
        {
            pictureBox1.Top++;
            pictureBox1.Left++;
        }
        private void Screen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MoveCursor()
        {
            if (Cursor.Position.X - x > 50 || Cursor.Position.Y - y > 50)
            {
                this.Close();
            }
        }

    
    }
}
