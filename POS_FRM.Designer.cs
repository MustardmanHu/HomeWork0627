
namespace WindowsFormsApp2
{
    partial class POS_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_FRM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Good4 = new System.Windows.Forms.Button();
            this.Good3 = new System.Windows.Forms.Button();
            this.Good2 = new System.Windows.Forms.Button();
            this.Good1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalPrice_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreditCard_Pay = new System.Windows.Forms.Button();
            this.CashPay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cart4_txt = new System.Windows.Forms.TextBox();
            this.Cart3_txt = new System.Windows.Forms.TextBox();
            this.Cart2_txt = new System.Windows.Forms.TextBox();
            this.Cart1_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.Good4);
            this.groupBox1.Controls.Add(this.Good3);
            this.groupBox1.Controls.Add(this.Good2);
            this.groupBox1.Controls.Add(this.Good1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品列表";
            // 
            // Good4
            // 
            this.Good4.BackColor = System.Drawing.SystemColors.Highlight;
            this.Good4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Good4.Location = new System.Drawing.Point(139, 204);
            this.Good4.Name = "Good4";
            this.Good4.Size = new System.Drawing.Size(98, 138);
            this.Good4.TabIndex = 3;
            this.Good4.Text = "Good4";
            this.Good4.UseVisualStyleBackColor = false;
            this.Good4.Click += new System.EventHandler(this.Good4_Click);
            // 
            // Good3
            // 
            this.Good3.BackColor = System.Drawing.SystemColors.Highlight;
            this.Good3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Good3.Location = new System.Drawing.Point(19, 204);
            this.Good3.Name = "Good3";
            this.Good3.Size = new System.Drawing.Size(98, 138);
            this.Good3.TabIndex = 2;
            this.Good3.Text = "Good3";
            this.Good3.UseVisualStyleBackColor = false;
            this.Good3.Click += new System.EventHandler(this.Good3_Click);
            // 
            // Good2
            // 
            this.Good2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Good2.Location = new System.Drawing.Point(139, 40);
            this.Good2.Name = "Good2";
            this.Good2.Size = new System.Drawing.Size(98, 138);
            this.Good2.TabIndex = 1;
            this.Good2.Text = "Good2";
            this.Good2.UseVisualStyleBackColor = true;
            this.Good2.Click += new System.EventHandler(this.Good2_Click);
            // 
            // Good1
            // 
            this.Good1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Good1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Good1.Location = new System.Drawing.Point(19, 40);
            this.Good1.Name = "Good1";
            this.Good1.Size = new System.Drawing.Size(98, 138);
            this.Good1.TabIndex = 0;
            this.Good1.Text = "Good1";
            this.Good1.UseVisualStyleBackColor = false;
            this.Good1.Click += new System.EventHandler(this.Good1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.TotalPrice_txt);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額";
            // 
            // TotalPrice_txt
            // 
            this.TotalPrice_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TotalPrice_txt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TotalPrice_txt.Location = new System.Drawing.Point(6, 63);
            this.TotalPrice_txt.Multiline = true;
            this.TotalPrice_txt.Name = "TotalPrice_txt";
            this.TotalPrice_txt.ReadOnly = true;
            this.TotalPrice_txt.Size = new System.Drawing.Size(277, 45);
            this.TotalPrice_txt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Controls.Add(this.CreditCard_Pay);
            this.groupBox3.Controls.Add(this.CashPay);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(264, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // CreditCard_Pay
            // 
            this.CreditCard_Pay.BackColor = System.Drawing.Color.IndianRed;
            this.CreditCard_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditCard_Pay.Location = new System.Drawing.Point(149, 64);
            this.CreditCard_Pay.Name = "CreditCard_Pay";
            this.CreditCard_Pay.Size = new System.Drawing.Size(147, 60);
            this.CreditCard_Pay.TabIndex = 1;
            this.CreditCard_Pay.Text = "信用卡(九折)";
            this.CreditCard_Pay.UseVisualStyleBackColor = false;
            this.CreditCard_Pay.Click += new System.EventHandler(this.CreditCard_Pay_Click);
            // 
            // CashPay
            // 
            this.CashPay.BackColor = System.Drawing.Color.IndianRed;
            this.CashPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashPay.Location = new System.Drawing.Point(6, 64);
            this.CashPay.Name = "CashPay";
            this.CashPay.Size = new System.Drawing.Size(127, 60);
            this.CashPay.TabIndex = 0;
            this.CashPay.Text = "現金付款";
            this.CashPay.UseVisualStyleBackColor = false;
            this.CashPay.Click += new System.EventHandler(this.CashPay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.Cart4_txt);
            this.groupBox4.Controls.Add(this.Cart3_txt);
            this.groupBox4.Controls.Add(this.Cart2_txt);
            this.groupBox4.Controls.Add(this.Cart1_txt);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(572, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 294);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(14, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "清空我的購物清單";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cart4_txt
            // 
            this.Cart4_txt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cart4_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cart4_txt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cart4_txt.Location = new System.Drawing.Point(14, 159);
            this.Cart4_txt.Multiline = true;
            this.Cart4_txt.Name = "Cart4_txt";
            this.Cart4_txt.ReadOnly = true;
            this.Cart4_txt.Size = new System.Drawing.Size(277, 33);
            this.Cart4_txt.TabIndex = 3;
            // 
            // Cart3_txt
            // 
            this.Cart3_txt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cart3_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cart3_txt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cart3_txt.Location = new System.Drawing.Point(14, 120);
            this.Cart3_txt.Multiline = true;
            this.Cart3_txt.Name = "Cart3_txt";
            this.Cart3_txt.ReadOnly = true;
            this.Cart3_txt.Size = new System.Drawing.Size(277, 33);
            this.Cart3_txt.TabIndex = 2;
            // 
            // Cart2_txt
            // 
            this.Cart2_txt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cart2_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cart2_txt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cart2_txt.Location = new System.Drawing.Point(14, 81);
            this.Cart2_txt.Multiline = true;
            this.Cart2_txt.Name = "Cart2_txt";
            this.Cart2_txt.ReadOnly = true;
            this.Cart2_txt.Size = new System.Drawing.Size(277, 33);
            this.Cart2_txt.TabIndex = 1;
            // 
            // Cart1_txt
            // 
            this.Cart1_txt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cart1_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cart1_txt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cart1_txt.Location = new System.Drawing.Point(14, 42);
            this.Cart1_txt.Multiline = true;
            this.Cart1_txt.Name = "Cart1_txt";
            this.Cart1_txt.ReadOnly = true;
            this.Cart1_txt.Size = new System.Drawing.Size(277, 33);
            this.Cart1_txt.TabIndex = 0;
            // 
            // POS_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "POS_FRM";
            this.Text = "POS_FRM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Good4;
        private System.Windows.Forms.Button Good3;
        private System.Windows.Forms.Button Good2;
        private System.Windows.Forms.Button Good1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalPrice_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreditCard_Pay;
        private System.Windows.Forms.Button CashPay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Cart1_txt;
        private System.Windows.Forms.TextBox Cart4_txt;
        private System.Windows.Forms.TextBox Cart3_txt;
        private System.Windows.Forms.TextBox Cart2_txt;
        private System.Windows.Forms.Button button1;
    }
}