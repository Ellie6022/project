namespace WindowsFormsApp3
{
    partial class FormMain
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
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn訂購單 = new System.Windows.Forms.Button();
            this.btn員工登入 = new System.Windows.Forms.Button();
            this.btn會員登入 = new System.Windows.Forms.Button();
            this.btn訪客 = new System.Windows.Forms.Button();
            this.lbl登入者名稱 = new System.Windows.Forms.Label();
            this.btn切換使用者 = new System.Windows.Forms.Button();
            this.btn會員點數 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn系統管理
            // 
            this.btn系統管理.BackColor = System.Drawing.Color.SeaShell;
            this.btn系統管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統管理.Location = new System.Drawing.Point(469, 207);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(176, 53);
            this.btn系統管理.TabIndex = 14;
            this.btn系統管理.Text = "員工請假單";
            this.btn系統管理.UseVisualStyleBackColor = false;
            this.btn系統管理.Click += new System.EventHandler(this.btn系統管理_Click);
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.SeaShell;
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(268, 130);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(179, 53);
            this.btn商品管理.TabIndex = 13;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.BackColor = System.Drawing.Color.SeaShell;
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(268, 207);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(179, 53);
            this.btn會員資料管理.TabIndex = 12;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = false;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.SeaShell;
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(72, 207);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(176, 53);
            this.btn訂單管理.TabIndex = 11;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn訂購單
            // 
            this.btn訂購單.BackColor = System.Drawing.Color.SeaShell;
            this.btn訂購單.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購單.Location = new System.Drawing.Point(72, 130);
            this.btn訂購單.Name = "btn訂購單";
            this.btn訂購單.Size = new System.Drawing.Size(176, 53);
            this.btn訂購單.TabIndex = 10;
            this.btn訂購單.Text = "訂購單Menu";
            this.btn訂購單.UseVisualStyleBackColor = false;
            this.btn訂購單.Click += new System.EventHandler(this.btn訂購單_Click);
            // 
            // btn員工登入
            // 
            this.btn員工登入.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工登入.Image = global::WindowsFormsApp3.Properties.Resources.baseline_login_black_18dp;
            this.btn員工登入.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn員工登入.Location = new System.Drawing.Point(582, 62);
            this.btn員工登入.Name = "btn員工登入";
            this.btn員工登入.Size = new System.Drawing.Size(110, 41);
            this.btn員工登入.TabIndex = 16;
            this.btn員工登入.Text = "   員工登入";
            this.btn員工登入.UseVisualStyleBackColor = true;
            this.btn員工登入.Click += new System.EventHandler(this.btn員工登入_Click);
            // 
            // btn會員登入
            // 
            this.btn會員登入.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員登入.Image = global::WindowsFormsApp3.Properties.Resources.baseline_login_black_18dp;
            this.btn會員登入.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn會員登入.Location = new System.Drawing.Point(469, 62);
            this.btn會員登入.Name = "btn會員登入";
            this.btn會員登入.Size = new System.Drawing.Size(105, 41);
            this.btn會員登入.TabIndex = 17;
            this.btn會員登入.Text = "   會員登入";
            this.btn會員登入.UseVisualStyleBackColor = true;
            this.btn會員登入.Click += new System.EventHandler(this.btn會員登入_Click);
            // 
            // btn訪客
            // 
            this.btn訪客.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訪客.Location = new System.Drawing.Point(372, 63);
            this.btn訪客.Name = "btn訪客";
            this.btn訪客.Size = new System.Drawing.Size(91, 38);
            this.btn訪客.TabIndex = 18;
            this.btn訪客.Text = "訪客";
            this.btn訪客.UseVisualStyleBackColor = true;
            this.btn訪客.Click += new System.EventHandler(this.btn訪客_Click);
            // 
            // lbl登入者名稱
            // 
            this.lbl登入者名稱.AutoSize = true;
            this.lbl登入者名稱.Location = new System.Drawing.Point(415, 7);
            this.lbl登入者名稱.Name = "lbl登入者名稱";
            this.lbl登入者名稱.Size = new System.Drawing.Size(80, 29);
            this.lbl登入者名稱.TabIndex = 19;
            this.lbl登入者名稱.Text = "label1";
            // 
            // btn切換使用者
            // 
            this.btn切換使用者.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn切換使用者.Image = global::WindowsFormsApp3.Properties.Resources.baseline_logout_black_24dp1;
            this.btn切換使用者.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn切換使用者.Location = new System.Drawing.Point(547, 3);
            this.btn切換使用者.Name = "btn切換使用者";
            this.btn切換使用者.Size = new System.Drawing.Size(145, 33);
            this.btn切換使用者.TabIndex = 20;
            this.btn切換使用者.Text = "    切換使用者";
            this.btn切換使用者.UseVisualStyleBackColor = true;
            this.btn切換使用者.Click += new System.EventHandler(this.btn切換使用者_Click);
            // 
            // btn會員點數
            // 
            this.btn會員點數.BackColor = System.Drawing.Color.SeaShell;
            this.btn會員點數.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員點數.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn會員點數.Location = new System.Drawing.Point(469, 130);
            this.btn會員點數.Name = "btn會員點數";
            this.btn會員點數.Size = new System.Drawing.Size(179, 53);
            this.btn會員點數.TabIndex = 22;
            this.btn會員點數.Text = "  會員點數";
            this.btn會員點數.UseVisualStyleBackColor = false;
            this.btn會員點數.Click += new System.EventHandler(this.btn會員點數_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.lbl登入者名稱);
            this.panel1.Controls.Add(this.btn切換使用者);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 40);
            this.panel1.TabIndex = 23;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.桌面1;
            this.ClientSize = new System.Drawing.Size(704, 653);
            this.Controls.Add(this.btn訪客);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn會員登入);
            this.Controls.Add(this.btn會員點數);
            this.Controls.Add(this.btn員工登入);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn訂購單);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn系統管理;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn訂購單;
        private System.Windows.Forms.Button btn員工登入;
        private System.Windows.Forms.Button btn會員登入;
        private System.Windows.Forms.Button btn訪客;
        private System.Windows.Forms.Label lbl登入者名稱;
        private System.Windows.Forms.Button btn切換使用者;
        private System.Windows.Forms.Button btn會員點數;
        private System.Windows.Forms.Panel panel1;
    }
}