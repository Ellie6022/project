namespace WindowsFormsApp3
{
    partial class FormPoint
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt會員姓名 = new System.Windows.Forms.TextBox();
            this.txt累積點數 = new System.Windows.Forms.TextBox();
            this.dgv會員點數 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt新增點數 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp購物時間 = new System.Windows.Forms.DateTimePicker();
            this.txt會員信箱 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn重新整理 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員點數)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "累積點數";
            // 
            // txt會員姓名
            // 
            this.txt會員姓名.Location = new System.Drawing.Point(126, 67);
            this.txt會員姓名.Name = "txt會員姓名";
            this.txt會員姓名.Size = new System.Drawing.Size(240, 34);
            this.txt會員姓名.TabIndex = 2;
            // 
            // txt累積點數
            // 
            this.txt累積點數.Location = new System.Drawing.Point(126, 317);
            this.txt累積點數.Name = "txt累積點數";
            this.txt累積點數.Size = new System.Drawing.Size(240, 34);
            this.txt累積點數.TabIndex = 3;
            // 
            // dgv會員點數
            // 
            this.dgv會員點數.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv會員點數.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員點數.Location = new System.Drawing.Point(496, 37);
            this.dgv會員點數.Name = "dgv會員點數";
            this.dgv會員點數.RowHeadersWidth = 51;
            this.dgv會員點數.RowTemplate.Height = 27;
            this.dgv會員點數.Size = new System.Drawing.Size(534, 497);
            this.dgv會員點數.TabIndex = 4;
            this.dgv會員點數.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員點數_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "購物時間";
            // 
            // txt新增點數
            // 
            this.txt新增點數.Location = new System.Drawing.Point(126, 245);
            this.txt新增點數.Name = "txt新增點數";
            this.txt新增點數.Size = new System.Drawing.Size(240, 34);
            this.txt新增點數.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "新增點數";
            // 
            // dtp購物時間
            // 
            this.dtp購物時間.Location = new System.Drawing.Point(126, 183);
            this.dtp購物時間.Name = "dtp購物時間";
            this.dtp購物時間.Size = new System.Drawing.Size(240, 34);
            this.dtp購物時間.TabIndex = 9;
            // 
            // txt會員信箱
            // 
            this.txt會員信箱.Location = new System.Drawing.Point(126, 123);
            this.txt會員信箱.Name = "txt會員信箱";
            this.txt會員信箱.Size = new System.Drawing.Size(240, 34);
            this.txt會員信箱.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "會員信箱";
            // 
            // btn重新整理
            // 
            this.btn重新整理.Location = new System.Drawing.Point(881, 541);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(149, 48);
            this.btn重新整理.TabIndex = 12;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = true;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // FormPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1054, 601);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.txt會員信箱);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp購物時間);
            this.Controls.Add(this.txt新增點數);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv會員點數);
            this.Controls.Add(this.txt累積點數);
            this.Controls.Add(this.txt會員姓名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPoint";
            this.Text = "FormPoint";
            this.Load += new System.EventHandler(this.FormPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員點數)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt會員姓名;
        private System.Windows.Forms.TextBox txt累積點數;
        private System.Windows.Forms.DataGridView dgv會員點數;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt新增點數;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp購物時間;
        private System.Windows.Forms.TextBox txt會員信箱;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn重新整理;
    }
}