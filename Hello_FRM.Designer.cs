
namespace WindowsFormsApp2
{
    partial class Gender_txt
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gender_txt));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.EngName_txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Zodiac_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(21, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "如果今天是你生日";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(258, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "今天不是你生日";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(177, 55);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(320, 22);
            this.Name_txt.TabIndex = 2;
            // 
            // EngName_txt
            // 
            this.EngName_txt.Location = new System.Drawing.Point(177, 120);
            this.EngName_txt.Name = "EngName_txt";
            this.EngName_txt.Size = new System.Drawing.Size(320, 22);
            this.EngName_txt.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(320, 22);
            this.textBox3.TabIndex = 4;
            // 
            // Zodiac_txt
            // 
            this.Zodiac_txt.Location = new System.Drawing.Point(177, 253);
            this.Zodiac_txt.Name = "Zodiac_txt";
            this.Zodiac_txt.Size = new System.Drawing.Size(320, 22);
            this.Zodiac_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "EnglishName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "生日(****/**/**)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(8, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "星座";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Zodiac_txt);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.EngName_txt);
            this.panel1.Controls.Add(this.Name_txt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 448);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(503, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 439);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(503, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 437);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // Gender_txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Gender_txt";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox EngName_txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Zodiac_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

