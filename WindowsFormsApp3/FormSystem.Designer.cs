namespace WindowsFormsApp3
{
    partial class FormSystem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn轉換時數 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radio公假 = new System.Windows.Forms.RadioButton();
            this.radio病假 = new System.Windows.Forms.RadioButton();
            this.radio事假 = new System.Windows.Forms.RadioButton();
            this.lbl請假時數 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn確認送出 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt請假事由 = new System.Windows.Forms.TextBox();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp起始時間 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo部門 = new System.Windows.Forms.ComboBox();
            this.txt員工姓名 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv請假紀錄 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv請假紀錄)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.btn轉換時數);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.radio公假);
            this.tabPage1.Controls.Add(this.radio病假);
            this.tabPage1.Controls.Add(this.radio事假);
            this.tabPage1.Controls.Add(this.lbl請假時數);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn確認送出);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt請假事由);
            this.tabPage1.Controls.Add(this.dtp結束時間);
            this.tabPage1.Controls.Add(this.dtp起始時間);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.combo部門);
            this.tabPage1.Controls.Add(this.txt員工姓名);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "請假單";
            // 
            // btn轉換時數
            // 
            this.btn轉換時數.Location = new System.Drawing.Point(721, 287);
            this.btn轉換時數.Name = "btn轉換時數";
            this.btn轉換時數.Size = new System.Drawing.Size(114, 34);
            this.btn轉換時數.TabIndex = 83;
            this.btn轉換時數.Text = "轉換時數";
            this.btn轉換時數.UseVisualStyleBackColor = true;
            this.btn轉換時數.Click += new System.EventHandler(this.btn轉換時數_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(348, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 82;
            this.label5.Text = "假別";
            // 
            // radio公假
            // 
            this.radio公假.AutoSize = true;
            this.radio公假.Location = new System.Drawing.Point(641, 375);
            this.radio公假.Name = "radio公假";
            this.radio公假.Size = new System.Drawing.Size(73, 29);
            this.radio公假.TabIndex = 81;
            this.radio公假.TabStop = true;
            this.radio公假.Text = "公假";
            this.radio公假.UseVisualStyleBackColor = true;
            // 
            // radio病假
            // 
            this.radio病假.AutoSize = true;
            this.radio病假.Location = new System.Drawing.Point(547, 375);
            this.radio病假.Name = "radio病假";
            this.radio病假.Size = new System.Drawing.Size(73, 29);
            this.radio病假.TabIndex = 80;
            this.radio病假.TabStop = true;
            this.radio病假.Text = "病假";
            this.radio病假.UseVisualStyleBackColor = true;
            // 
            // radio事假
            // 
            this.radio事假.AutoSize = true;
            this.radio事假.Location = new System.Drawing.Point(452, 375);
            this.radio事假.Name = "radio事假";
            this.radio事假.Size = new System.Drawing.Size(73, 29);
            this.radio事假.TabIndex = 79;
            this.radio事假.TabStop = true;
            this.radio事假.Text = "事假";
            this.radio事假.UseVisualStyleBackColor = true;
            // 
            // lbl請假時數
            // 
            this.lbl請假時數.AutoSize = true;
            this.lbl請假時數.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbl請假時數.Location = new System.Drawing.Point(841, 292);
            this.lbl請假時數.Name = "lbl請假時數";
            this.lbl請假時數.Size = new System.Drawing.Size(132, 25);
            this.lbl請假時數.TabIndex = 78;
            this.lbl請假時數.Text = "共幾小時幾分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(469, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 77;
            this.label4.Text = "員工請假單";
            // 
            // btn確認送出
            // 
            this.btn確認送出.Location = new System.Drawing.Point(476, 497);
            this.btn確認送出.Name = "btn確認送出";
            this.btn確認送出.Size = new System.Drawing.Size(132, 41);
            this.btn確認送出.TabIndex = 76;
            this.btn確認送出.Text = "確認送出";
            this.btn確認送出.UseVisualStyleBackColor = true;
            this.btn確認送出.Click += new System.EventHandler(this.btn確認送出_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(332, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "請假時間";
            // 
            // txt請假事由
            // 
            this.txt請假事由.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt請假事由.Location = new System.Drawing.Point(458, 423);
            this.txt請假事由.Name = "txt請假事由";
            this.txt請假事由.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt請假事由.Size = new System.Drawing.Size(244, 38);
            this.txt請假事由.TabIndex = 74;
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.CustomFormat = "HH:mm";
            this.dtp結束時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp結束時間.Location = new System.Drawing.Point(458, 316);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(244, 34);
            this.dtp結束時間.TabIndex = 73;
            this.dtp結束時間.Enter += new System.EventHandler(this.dtp結束時間_Enter);
            this.dtp結束時間.Leave += new System.EventHandler(this.dtp結束時間_Leave);
            // 
            // dtp起始時間
            // 
            this.dtp起始時間.CustomFormat = "HH:mm";
            this.dtp起始時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp起始時間.Location = new System.Drawing.Point(458, 266);
            this.dtp起始時間.Name = "dtp起始時間";
            this.dtp起始時間.Size = new System.Drawing.Size(244, 34);
            this.dtp起始時間.TabIndex = 72;
            this.dtp起始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(401, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 71;
            this.label11.Text = "從";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(401, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 29);
            this.label10.TabIndex = 70;
            this.label10.Text = "到";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "請假事由";
            // 
            // combo部門
            // 
            this.combo部門.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo部門.FormattingEnabled = true;
            this.combo部門.Location = new System.Drawing.Point(461, 167);
            this.combo部門.Name = "combo部門";
            this.combo部門.Size = new System.Drawing.Size(244, 37);
            this.combo部門.TabIndex = 68;
            // 
            // txt員工姓名
            // 
            this.txt員工姓名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt員工姓名.Location = new System.Drawing.Point(461, 122);
            this.txt員工姓名.Name = "txt員工姓名";
            this.txt員工姓名.Size = new System.Drawing.Size(244, 38);
            this.txt員工姓名.TabIndex = 67;
            this.txt員工姓名.TextChanged += new System.EventHandler(this.txt員工姓名_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(360, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(360, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "部門";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Moccasin;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(456, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 29);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "00000000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(360, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 29);
            this.label14.TabIndex = 63;
            this.label14.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.btn重新整理);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgv請假紀錄);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "請假紀錄";
            // 
            // btn重新整理
            // 
            this.btn重新整理.Location = new System.Drawing.Point(855, 531);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(129, 44);
            this.btn重新整理.TabIndex = 79;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = true;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(404, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 36);
            this.label6.TabIndex = 78;
            this.label6.Text = "員工請假歷史紀錄";
            // 
            // dgv請假紀錄
            // 
            this.dgv請假紀錄.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv請假紀錄.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv請假紀錄.Location = new System.Drawing.Point(82, 53);
            this.dgv請假紀錄.Name = "dgv請假紀錄";
            this.dgv請假紀錄.RowHeadersWidth = 51;
            this.dgv請假紀錄.RowTemplate.Height = 27;
            this.dgv請假紀錄.Size = new System.Drawing.Size(902, 472);
            this.dgv請假紀錄.TabIndex = 0;
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1086, 636);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSystem";
            this.Text = "FormSystem";
            this.Load += new System.EventHandler(this.FormSystem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv請假紀錄)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio公假;
        private System.Windows.Forms.RadioButton radio病假;
        private System.Windows.Forms.RadioButton radio事假;
        private System.Windows.Forms.Label lbl請假時數;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn確認送出;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt請假事由;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp起始時間;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo部門;
        private System.Windows.Forms.TextBox txt員工姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv請假紀錄;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.Button btn轉換時數;
    }
}