namespace WindowsFormsApp3
{
    partial class FormOrderManage
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
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo訂購狀況 = new System.Windows.Forms.ComboBox();
            this.dgv訂購單管理 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn修改商品 = new System.Windows.Forms.Button();
            this.btn刪除商品 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio外帶 = new System.Windows.Forms.RadioButton();
            this.radio內用 = new System.Windows.Forms.RadioButton();
            this.txt內用桌號 = new System.Windows.Forms.TextBox();
            this.lbl內用桌號 = new System.Windows.Forms.Label();
            this.chk購物袋 = new System.Windows.Forms.CheckBox();
            this.txt訂單總價 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.txt訂購品項 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂購單管理)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt訂購人
            // 
            this.txt訂購人.Location = new System.Drawing.Point(176, 71);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(254, 34);
            this.txt訂購人.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(50, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 29);
            this.label17.TabIndex = 11;
            this.label17.Text = "訂購人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "訂購品項";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(50, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "訂購狀況";
            // 
            // combo訂購狀況
            // 
            this.combo訂購狀況.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo訂購狀況.FormattingEnabled = true;
            this.combo訂購狀況.Location = new System.Drawing.Point(176, 123);
            this.combo訂購狀況.Name = "combo訂購狀況";
            this.combo訂購狀況.Size = new System.Drawing.Size(254, 37);
            this.combo訂購狀況.TabIndex = 16;
            // 
            // dgv訂購單管理
            // 
            this.dgv訂購單管理.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv訂購單管理.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂購單管理.Location = new System.Drawing.Point(511, 96);
            this.dgv訂購單管理.Name = "dgv訂購單管理";
            this.dgv訂購單管理.RowHeadersWidth = 51;
            this.dgv訂購單管理.RowTemplate.Height = 27;
            this.dgv訂購單管理.Size = new System.Drawing.Size(662, 482);
            this.dgv訂購單管理.TabIndex = 17;
            this.dgv訂購單管理.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂購單管理_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(506, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "訂購單列表";
            // 
            // btn新增商品
            // 
            this.btn新增商品.Location = new System.Drawing.Point(54, 633);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(119, 48);
            this.btn新增商品.TabIndex = 19;
            this.btn新增商品.Text = "新增訂單";
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn修改商品
            // 
            this.btn修改商品.Location = new System.Drawing.Point(194, 633);
            this.btn修改商品.Name = "btn修改商品";
            this.btn修改商品.Size = new System.Drawing.Size(119, 48);
            this.btn修改商品.TabIndex = 20;
            this.btn修改商品.Text = "修改訂單";
            this.btn修改商品.UseVisualStyleBackColor = true;
            this.btn修改商品.Click += new System.EventHandler(this.btn修改商品_Click);
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.Location = new System.Drawing.Point(341, 633);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(119, 48);
            this.btn刪除商品.TabIndex = 21;
            this.btn刪除商品.Text = "刪除訂單";
            this.btn刪除商品.UseVisualStyleBackColor = true;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Moccasin;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(178, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 29);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "00000000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(73, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 29);
            this.label14.TabIndex = 45;
            this.label14.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.radio外帶);
            this.groupBox1.Controls.Add(this.radio內用);
            this.groupBox1.Location = new System.Drawing.Point(54, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 63);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // radio外帶
            // 
            this.radio外帶.AutoSize = true;
            this.radio外帶.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio外帶.Location = new System.Drawing.Point(96, 24);
            this.radio外帶.Name = "radio外帶";
            this.radio外帶.Size = new System.Drawing.Size(80, 33);
            this.radio外帶.TabIndex = 1;
            this.radio外帶.TabStop = true;
            this.radio外帶.Text = "外帶";
            this.radio外帶.UseVisualStyleBackColor = true;
            this.radio外帶.CheckedChanged += new System.EventHandler(this.radio外帶_CheckedChanged);
            // 
            // radio內用
            // 
            this.radio內用.AutoSize = true;
            this.radio內用.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio內用.Location = new System.Drawing.Point(10, 24);
            this.radio內用.Name = "radio內用";
            this.radio內用.Size = new System.Drawing.Size(80, 33);
            this.radio內用.TabIndex = 0;
            this.radio內用.TabStop = true;
            this.radio內用.Text = "內用";
            this.radio內用.UseVisualStyleBackColor = true;
            this.radio內用.CheckedChanged += new System.EventHandler(this.radio內用_CheckedChanged);
            // 
            // txt內用桌號
            // 
            this.txt內用桌號.Location = new System.Drawing.Point(176, 186);
            this.txt內用桌號.Name = "txt內用桌號";
            this.txt內用桌號.Size = new System.Drawing.Size(254, 34);
            this.txt內用桌號.TabIndex = 49;
            // 
            // lbl內用桌號
            // 
            this.lbl內用桌號.AutoSize = true;
            this.lbl內用桌號.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl內用桌號.Location = new System.Drawing.Point(50, 186);
            this.lbl內用桌號.Name = "lbl內用桌號";
            this.lbl內用桌號.Size = new System.Drawing.Size(105, 29);
            this.lbl內用桌號.TabIndex = 48;
            this.lbl內用桌號.Text = "內用桌號";
            // 
            // chk購物袋
            // 
            this.chk購物袋.AutoSize = true;
            this.chk購物袋.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk購物袋.Location = new System.Drawing.Point(330, 578);
            this.chk購物袋.Name = "chk購物袋";
            this.chk購物袋.Size = new System.Drawing.Size(150, 33);
            this.chk購物袋.TabIndex = 50;
            this.chk購物袋.Text = "購買購物袋";
            this.chk購物袋.UseVisualStyleBackColor = true;
            this.chk購物袋.CheckedChanged += new System.EventHandler(this.chk購物袋_CheckedChanged);
            // 
            // txt訂單總價
            // 
            this.txt訂單總價.Location = new System.Drawing.Point(176, 243);
            this.txt訂單總價.Name = "txt訂單總價";
            this.txt訂單總價.Size = new System.Drawing.Size(254, 34);
            this.txt訂單總價.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "訂單總價";
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.Linen;
            this.btn重新整理.Location = new System.Drawing.Point(1027, 584);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(119, 41);
            this.btn重新整理.TabIndex = 53;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // txt訂購品項
            // 
            this.txt訂購品項.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購品項.Location = new System.Drawing.Point(54, 324);
            this.txt訂購品項.Multiline = true;
            this.txt訂購品項.Name = "txt訂購品項";
            this.txt訂購品項.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt訂購品項.Size = new System.Drawing.Size(425, 206);
            this.txt訂購品項.TabIndex = 54;
            // 
            // FormOrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1185, 688);
            this.Controls.Add(this.txt訂購品項);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.txt訂單總價);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk購物袋);
            this.Controls.Add(this.txt內用桌號);
            this.Controls.Add(this.lbl內用桌號);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn刪除商品);
            this.Controls.Add(this.btn修改商品);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv訂購單管理);
            this.Controls.Add(this.combo訂購狀況);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label17);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormOrderManage";
            this.Text = "FormOrderManage";
            this.Load += new System.EventHandler(this.FormOrderManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂購單管理)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo訂購狀況;
        private System.Windows.Forms.DataGridView dgv訂購單管理;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn修改商品;
        private System.Windows.Forms.Button btn刪除商品;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio外帶;
        private System.Windows.Forms.RadioButton radio內用;
        private System.Windows.Forms.TextBox txt內用桌號;
        private System.Windows.Forms.Label lbl內用桌號;
        private System.Windows.Forms.CheckBox chk購物袋;
        private System.Windows.Forms.TextBox txt訂單總價;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.TextBox txt訂購品項;
    }
}