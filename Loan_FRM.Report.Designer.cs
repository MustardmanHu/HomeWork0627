
namespace WindowsFormsApp2
{
    partial class Loan_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan_FRM));
            this.WL_txt = new System.Windows.Forms.TextBox();
            this.PC_txt = new System.Windows.Forms.TextBox();
            this.DL_txt = new System.Windows.Forms.TextBox();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.MP_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WL_txt
            // 
            this.WL_txt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WL_txt.Location = new System.Drawing.Point(188, 45);
            this.WL_txt.Name = "WL_txt";
            this.WL_txt.ReadOnly = true;
            this.WL_txt.Size = new System.Drawing.Size(251, 33);
            this.WL_txt.TabIndex = 0;
            // 
            // PC_txt
            // 
            this.PC_txt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PC_txt.Location = new System.Drawing.Point(188, 136);
            this.PC_txt.Name = "PC_txt";
            this.PC_txt.ReadOnly = true;
            this.PC_txt.Size = new System.Drawing.Size(251, 33);
            this.PC_txt.TabIndex = 1;
            // 
            // DL_txt
            // 
            this.DL_txt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DL_txt.Location = new System.Drawing.Point(188, 221);
            this.DL_txt.Name = "DL_txt";
            this.DL_txt.ReadOnly = true;
            this.DL_txt.Size = new System.Drawing.Size(251, 33);
            this.DL_txt.TabIndex = 2;
            // 
            // Total_txt
            // 
            this.Total_txt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Total_txt.Location = new System.Drawing.Point(188, 310);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.ReadOnly = true;
            this.Total_txt.Size = new System.Drawing.Size(251, 33);
            this.Total_txt.TabIndex = 3;
            // 
            // MP_txt
            // 
            this.MP_txt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MP_txt.Location = new System.Drawing.Point(188, 411);
            this.MP_txt.Name = "MP_txt";
            this.MP_txt.ReadOnly = true;
            this.MP_txt.Size = new System.Drawing.Size(251, 33);
            this.MP_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "利率(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "年限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "總付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(22, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "月付額";
            // 
            // Loan_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MP_txt);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.DL_txt);
            this.Controls.Add(this.PC_txt);
            this.Controls.Add(this.WL_txt);
            this.Name = "Loan_FRM";
            this.Text = "Loan_FRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox WL_txt;
        public System.Windows.Forms.TextBox PC_txt;
        public System.Windows.Forms.TextBox DL_txt;
        public System.Windows.Forms.TextBox Total_txt;
        public System.Windows.Forms.TextBox MP_txt;
    }
}