
namespace WindowsFormsApp2
{
    partial class StudentStruct_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStruct_FRM));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CN_txt = new System.Windows.Forms.TextBox();
            this.ENG_txt = new System.Windows.Forms.TextBox();
            this.MT_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Grade_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(19, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(208, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(492, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "最高分/低分 科目";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CN_txt
            // 
            this.CN_txt.Location = new System.Drawing.Point(114, 34);
            this.CN_txt.Name = "CN_txt";
            this.CN_txt.Size = new System.Drawing.Size(185, 22);
            this.CN_txt.TabIndex = 3;
            // 
            // ENG_txt
            // 
            this.ENG_txt.Location = new System.Drawing.Point(114, 120);
            this.ENG_txt.Name = "ENG_txt";
            this.ENG_txt.Size = new System.Drawing.Size(185, 22);
            this.ENG_txt.TabIndex = 4;
            // 
            // MT_txt
            // 
            this.MT_txt.Location = new System.Drawing.Point(114, 196);
            this.MT_txt.Name = "MT_txt";
            this.MT_txt.Size = new System.Drawing.Size(185, 22);
            this.MT_txt.TabIndex = 5;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(114, 284);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(185, 22);
            this.Name_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "國文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "英文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "數學";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Grade_txt);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(423, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 316);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 243);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(327, 67);
            this.textBox2.TabIndex = 1;
            // 
            // Grade_txt
            // 
            this.Grade_txt.Location = new System.Drawing.Point(6, 21);
            this.Grade_txt.Multiline = true;
            this.Grade_txt.Name = "Grade_txt";
            this.Grade_txt.ReadOnly = true;
            this.Grade_txt.Size = new System.Drawing.Size(327, 216);
            this.Grade_txt.TabIndex = 0;
            // 
            // StudentStruct_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.MT_txt);
            this.Controls.Add(this.ENG_txt);
            this.Controls.Add(this.CN_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StudentStruct_FRM";
            this.Text = "StudentStruct_FRM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CN_txt;
        private System.Windows.Forms.TextBox ENG_txt;
        private System.Windows.Forms.TextBox MT_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Grade_txt;
    }
}