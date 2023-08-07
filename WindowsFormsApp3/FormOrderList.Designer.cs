namespace WindowsFormsApp3
{
    partial class FormOrderList
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購資訊購物車區 = new System.Windows.Forms.Label();
            this.listBox訂購甜點品項列表 = new System.Windows.Forms.ListBox();
            this.chk購物袋 = new System.Windows.Forms.CheckBox();
            this.lbl訂購總價 = new System.Windows.Forms.Label();
            this.btn移除飲料所選品項 = new System.Windows.Forms.Button();
            this.btn清除飲料所有品項 = new System.Windows.Forms.Button();
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.btn輸出訂購單 = new System.Windows.Forms.Button();
            this.listBox訂購飲料品項列表 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn清除甜點所有品項 = new System.Windows.Forms.Button();
            this.btn移除甜點所選品項 = new System.Windows.Forms.Button();
            this.btn訂單送出 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.label1.Size = new System.Drawing.Size(265, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物車";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl訂購資訊購物車區
            // 
            this.lbl訂購資訊購物車區.AutoSize = true;
            this.lbl訂購資訊購物車區.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl訂購資訊購物車區.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購資訊購物車區.Location = new System.Drawing.Point(49, 79);
            this.lbl訂購資訊購物車區.Name = "lbl訂購資訊購物車區";
            this.lbl訂購資訊購物車區.Size = new System.Drawing.Size(190, 36);
            this.lbl訂購資訊購物車區.TabIndex = 5;
            this.lbl訂購資訊購物車區.Text = "姓名 內用外帶";
            // 
            // listBox訂購甜點品項列表
            // 
            this.listBox訂購甜點品項列表.BackColor = System.Drawing.Color.Linen;
            this.listBox訂購甜點品項列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購甜點品項列表.FormattingEnabled = true;
            this.listBox訂購甜點品項列表.ItemHeight = 29;
            this.listBox訂購甜點品項列表.Location = new System.Drawing.Point(47, 174);
            this.listBox訂購甜點品項列表.Name = "listBox訂購甜點品項列表";
            this.listBox訂購甜點品項列表.Size = new System.Drawing.Size(919, 178);
            this.listBox訂購甜點品項列表.TabIndex = 6;
            this.listBox訂購甜點品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購甜點品項列表_SelectedIndexChanged);
            // 
            // chk購物袋
            // 
            this.chk購物袋.AutoSize = true;
            this.chk購物袋.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk購物袋.Location = new System.Drawing.Point(762, 62);
            this.chk購物袋.Name = "chk購物袋";
            this.chk購物袋.Size = new System.Drawing.Size(193, 33);
            this.chk購物袋.TabIndex = 10;
            this.chk購物袋.Text = "購買購物袋 2元";
            this.chk購物袋.UseVisualStyleBackColor = true;
            this.chk購物袋.CheckedChanged += new System.EventHandler(this.chk購物袋_CheckedChanged);
            // 
            // lbl訂購總價
            // 
            this.lbl訂購總價.AutoSize = true;
            this.lbl訂購總價.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl訂購總價.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購總價.Location = new System.Drawing.Point(757, 98);
            this.lbl訂購總價.Name = "lbl訂購總價";
            this.lbl訂購總價.Size = new System.Drawing.Size(198, 29);
            this.lbl訂購總價.TabIndex = 11;
            this.lbl訂購總價.Text = "訂單總價00000元";
            // 
            // btn移除飲料所選品項
            // 
            this.btn移除飲料所選品項.BackColor = System.Drawing.Color.White;
            this.btn移除飲料所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除飲料所選品項.Location = new System.Drawing.Point(648, 394);
            this.btn移除飲料所選品項.Name = "btn移除飲料所選品項";
            this.btn移除飲料所選品項.Size = new System.Drawing.Size(141, 38);
            this.btn移除飲料所選品項.TabIndex = 12;
            this.btn移除飲料所選品項.Text = "移除所選品項";
            this.btn移除飲料所選品項.UseVisualStyleBackColor = false;
            this.btn移除飲料所選品項.Click += new System.EventHandler(this.btn移除飲料所選品項_Click);
            // 
            // btn清除飲料所有品項
            // 
            this.btn清除飲料所有品項.BackColor = System.Drawing.Color.White;
            this.btn清除飲料所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除飲料所有品項.Location = new System.Drawing.Point(801, 130);
            this.btn清除飲料所有品項.Name = "btn清除飲料所有品項";
            this.btn清除飲料所有品項.Size = new System.Drawing.Size(154, 40);
            this.btn清除飲料所有品項.TabIndex = 13;
            this.btn清除飲料所有品項.Text = "清除所有品項";
            this.btn清除飲料所有品項.UseVisualStyleBackColor = false;
            this.btn清除飲料所有品項.Click += new System.EventHandler(this.btn清除飲料所有品項_Click);
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.BackColor = System.Drawing.Color.BurlyWood;
            this.btn關閉表單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉表單.ForeColor = System.Drawing.Color.Black;
            this.btn關閉表單.Location = new System.Drawing.Point(172, 641);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(193, 51);
            this.btn關閉表單.TabIndex = 15;
            this.btn關閉表單.Text = "關閉表單";
            this.btn關閉表單.UseVisualStyleBackColor = false;
            this.btn關閉表單.Click += new System.EventHandler(this.btn關閉表單_Click);
            // 
            // btn輸出訂購單
            // 
            this.btn輸出訂購單.BackColor = System.Drawing.Color.BurlyWood;
            this.btn輸出訂購單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單.ForeColor = System.Drawing.Color.Black;
            this.btn輸出訂購單.Location = new System.Drawing.Point(445, 641);
            this.btn輸出訂購單.Name = "btn輸出訂購單";
            this.btn輸出訂購單.Size = new System.Drawing.Size(193, 51);
            this.btn輸出訂購單.TabIndex = 16;
            this.btn輸出訂購單.Text = "輸出訂購單(txt檔)";
            this.btn輸出訂購單.UseVisualStyleBackColor = false;
            this.btn輸出訂購單.Click += new System.EventHandler(this.btn輸出訂購單_Click);
            // 
            // listBox訂購飲料品項列表
            // 
            this.listBox訂購飲料品項列表.BackColor = System.Drawing.Color.Linen;
            this.listBox訂購飲料品項列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購飲料品項列表.FormattingEnabled = true;
            this.listBox訂購飲料品項列表.ItemHeight = 29;
            this.listBox訂購飲料品項列表.Location = new System.Drawing.Point(47, 440);
            this.listBox訂購飲料品項列表.Name = "listBox訂購飲料品項列表";
            this.listBox訂購飲料品項列表.Size = new System.Drawing.Size(919, 178);
            this.listBox訂購飲料品項列表.TabIndex = 17;
            this.listBox訂購飲料品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購飲料品項列表_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "訂購甜點品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "訂購飲料品項";
            // 
            // btn清除甜點所有品項
            // 
            this.btn清除甜點所有品項.BackColor = System.Drawing.Color.White;
            this.btn清除甜點所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除甜點所有品項.Location = new System.Drawing.Point(801, 394);
            this.btn清除甜點所有品項.Name = "btn清除甜點所有品項";
            this.btn清除甜點所有品項.Size = new System.Drawing.Size(154, 39);
            this.btn清除甜點所有品項.TabIndex = 20;
            this.btn清除甜點所有品項.Text = "清除所有品項";
            this.btn清除甜點所有品項.UseVisualStyleBackColor = false;
            this.btn清除甜點所有品項.Click += new System.EventHandler(this.btn清除甜點所有品項_Click);
            // 
            // btn移除甜點所選品項
            // 
            this.btn移除甜點所選品項.BackColor = System.Drawing.Color.White;
            this.btn移除甜點所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除甜點所選品項.Location = new System.Drawing.Point(654, 130);
            this.btn移除甜點所選品項.Name = "btn移除甜點所選品項";
            this.btn移除甜點所選品項.Size = new System.Drawing.Size(141, 40);
            this.btn移除甜點所選品項.TabIndex = 21;
            this.btn移除甜點所選品項.Text = "移除所選品項";
            this.btn移除甜點所選品項.UseVisualStyleBackColor = false;
            this.btn移除甜點所選品項.Click += new System.EventHandler(this.btn移除甜點所選品項_Click);
            // 
            // btn訂單送出
            // 
            this.btn訂單送出.BackColor = System.Drawing.Color.BurlyWood;
            this.btn訂單送出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單送出.ForeColor = System.Drawing.Color.Black;
            this.btn訂單送出.Location = new System.Drawing.Point(714, 641);
            this.btn訂單送出.Name = "btn訂單送出";
            this.btn訂單送出.Size = new System.Drawing.Size(193, 51);
            this.btn訂單送出.TabIndex = 22;
            this.btn訂單送出.Text = "訂單送出";
            this.btn訂單送出.UseVisualStyleBackColor = false;
            this.btn訂單送出.Click += new System.EventHandler(this.btn訂單送出_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1025, 709);
            this.Controls.Add(this.btn訂單送出);
            this.Controls.Add(this.btn移除甜點所選品項);
            this.Controls.Add(this.btn清除甜點所有品項);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox訂購飲料品項列表);
            this.Controls.Add(this.btn輸出訂購單);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.btn清除飲料所有品項);
            this.Controls.Add(this.btn移除飲料所選品項);
            this.Controls.Add(this.lbl訂購總價);
            this.Controls.Add(this.chk購物袋);
            this.Controls.Add(this.listBox訂購甜點品項列表);
            this.Controls.Add(this.lbl訂購資訊購物車區);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormOrderList";
            this.Text = "蘇格購物車";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購資訊購物車區;
        private System.Windows.Forms.ListBox listBox訂購甜點品項列表;
        private System.Windows.Forms.CheckBox chk購物袋;
        private System.Windows.Forms.Button btn移除飲料所選品項;
        private System.Windows.Forms.Button btn清除飲料所有品項;
        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Button btn輸出訂購單;
        public System.Windows.Forms.Label lbl訂購總價;
        private System.Windows.Forms.ListBox listBox訂購飲料品項列表;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn清除甜點所有品項;
        private System.Windows.Forms.Button btn移除甜點所選品項;
        private System.Windows.Forms.Button btn訂單送出;
    }
}