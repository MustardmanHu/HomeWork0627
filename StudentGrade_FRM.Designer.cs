
namespace WindowsFormsApp2
{
    partial class StudentGrade_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGrade_FRM));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Grade_txt = new System.Windows.Forms.TextBox();
            this.統計_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.CN_txt = new System.Windows.Forms.TextBox();
            this.ENG_txt = new System.Windows.Forms.TextBox();
            this.MT_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "加入成績資料";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(33, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "加入隨機生成資料";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(33, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "各科統計";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(33, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "清除所有資料";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(33, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "隨機加入20筆資料";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Grade_txt);
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 315);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名         國文       英文       數學       總分       平均       最高分       最低分";
            // 
            // Grade_txt
            // 
            this.Grade_txt.Location = new System.Drawing.Point(4, 27);
            this.Grade_txt.Multiline = true;
            this.Grade_txt.Name = "Grade_txt";
            this.Grade_txt.ReadOnly = true;
            this.Grade_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Grade_txt.Size = new System.Drawing.Size(545, 287);
            this.Grade_txt.TabIndex = 0;
            // 
            // 統計_txt
            // 
            this.統計_txt.Location = new System.Drawing.Point(226, 344);
            this.統計_txt.Multiline = true;
            this.統計_txt.Name = "統計_txt";
            this.統計_txt.ReadOnly = true;
            this.統計_txt.Size = new System.Drawing.Size(550, 101);
            this.統計_txt.TabIndex = 6;
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name_txt.Location = new System.Drawing.Point(46, 21);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(162, 29);
            this.Name_txt.TabIndex = 7;
            // 
            // CN_txt
            // 
            this.CN_txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CN_txt.Location = new System.Drawing.Point(46, 68);
            this.CN_txt.Name = "CN_txt";
            this.CN_txt.Size = new System.Drawing.Size(162, 29);
            this.CN_txt.TabIndex = 8;
            // 
            // ENG_txt
            // 
            this.ENG_txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ENG_txt.Location = new System.Drawing.Point(46, 118);
            this.ENG_txt.Name = "ENG_txt";
            this.ENG_txt.Size = new System.Drawing.Size(162, 29);
            this.ENG_txt.TabIndex = 9;
            // 
            // MT_txt
            // 
            this.MT_txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MT_txt.Location = new System.Drawing.Point(46, 165);
            this.MT_txt.Name = "MT_txt";
            this.MT_txt.Size = new System.Drawing.Size(162, 29);
            this.MT_txt.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(3, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "國文";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(2, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "英文";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "數學";
            // 
            // StudentGrade_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MT_txt);
            this.Controls.Add(this.ENG_txt);
            this.Controls.Add(this.CN_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.統計_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StudentGrade_FRM";
            this.Text = "StudentGrade_FRM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Grade_txt;
        private System.Windows.Forms.TextBox 統計_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox CN_txt;
        private System.Windows.Forms.TextBox ENG_txt;
        private System.Windows.Forms.TextBox MT_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}