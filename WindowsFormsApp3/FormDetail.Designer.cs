namespace WindowsFormsApp3
{
    partial class FormDetail
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
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn選取圖片 = new System.Windows.Forms.Button();
            this.btn移除圖片 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn儲存變更 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox類別 = new System.Windows.Forms.ComboBox();
            this.btn刪除商品 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.SuspendLayout();
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(203, 561);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(460, 140);
            this.txt商品描述.TabIndex = 17;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(203, 503);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(279, 35);
            this.txt商品價格.TabIndex = 16;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.BackColor = System.Drawing.Color.White;
            this.txt商品名稱.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(203, 444);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(460, 35);
            this.txt商品名稱.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Bisque;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(203, 336);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblID.Size = new System.Drawing.Size(180, 36);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "00000000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(18, 561);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label5.Size = new System.Drawing.Size(179, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "商品描述";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(18, 503);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(179, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "商品價格";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 444);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(179, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "商品名稱";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 337);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.InitialImage = global::WindowsFormsApp3.Properties.Resources.白圖;
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(161, 58);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(256, 256);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 18;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("新宋体", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "商品詳細資訊";
            // 
            // btn選取圖片
            // 
            this.btn選取圖片.BackColor = System.Drawing.Color.Silver;
            this.btn選取圖片.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選取圖片.Location = new System.Drawing.Point(471, 173);
            this.btn選取圖片.Name = "btn選取圖片";
            this.btn選取圖片.Size = new System.Drawing.Size(130, 41);
            this.btn選取圖片.TabIndex = 20;
            this.btn選取圖片.Text = "選取圖片";
            this.btn選取圖片.UseVisualStyleBackColor = false;
            this.btn選取圖片.Click += new System.EventHandler(this.btn選取圖片_Click);
            // 
            // btn移除圖片
            // 
            this.btn移除圖片.BackColor = System.Drawing.Color.RosyBrown;
            this.btn移除圖片.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除圖片.ForeColor = System.Drawing.Color.White;
            this.btn移除圖片.Location = new System.Drawing.Point(471, 245);
            this.btn移除圖片.Name = "btn移除圖片";
            this.btn移除圖片.Size = new System.Drawing.Size(130, 41);
            this.btn移除圖片.TabIndex = 21;
            this.btn移除圖片.Text = "移除圖片";
            this.btn移除圖片.UseVisualStyleBackColor = false;
            this.btn移除圖片.Click += new System.EventHandler(this.btn移除圖片_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(543, 707);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(130, 41);
            this.btn清空欄位.TabIndex = 22;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn儲存變更
            // 
            this.btn儲存變更.BackColor = System.Drawing.Color.Goldenrod;
            this.btn儲存變更.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存變更.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn儲存變更.Location = new System.Drawing.Point(308, 771);
            this.btn儲存變更.Name = "btn儲存變更";
            this.btn儲存變更.Size = new System.Drawing.Size(151, 48);
            this.btn儲存變更.TabIndex = 23;
            this.btn儲存變更.Text = "儲存變更";
            this.btn儲存變更.UseVisualStyleBackColor = false;
            this.btn儲存變更.Click += new System.EventHandler(this.btn儲存變更_Click);
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn取消.Location = new System.Drawing.Point(115, 771);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(151, 48);
            this.btn取消.TabIndex = 24;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(18, 390);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label6.Size = new System.Drawing.Size(179, 35);
            this.label6.TabIndex = 25;
            this.label6.Text = "類別";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox類別
            // 
            this.comboBox類別.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox類別.FormattingEnabled = true;
            this.comboBox類別.Location = new System.Drawing.Point(209, 394);
            this.comboBox類別.Name = "comboBox類別";
            this.comboBox類別.Size = new System.Drawing.Size(237, 31);
            this.comboBox類別.TabIndex = 26;
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.BackColor = System.Drawing.Color.Tomato;
            this.btn刪除商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除商品.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn刪除商品.Location = new System.Drawing.Point(500, 771);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(151, 48);
            this.btn刪除商品.TabIndex = 27;
            this.btn刪除商品.Text = "刪除商品";
            this.btn刪除商品.UseVisualStyleBackColor = false;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(744, 841);
            this.Controls.Add(this.btn刪除商品);
            this.Controls.Add(this.comboBox類別);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn儲存變更);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.btn移除圖片);
            this.Controls.Add(this.btn選取圖片);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn選取圖片;
        private System.Windows.Forms.Button btn移除圖片;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn儲存變更;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox類別;
        private System.Windows.Forms.Button btn刪除商品;
    }
}