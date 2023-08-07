namespace WindowsFormsApp3
{
    partial class FormMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox搜尋結果 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio已婚 = new System.Windows.Forms.RadioButton();
            this.radio單身 = new System.Windows.Forms.RadioButton();
            this.radio全部 = new System.Windows.Forms.RadioButton();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp起始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.combo資料欄位 = new System.Windows.Forms.ComboBox();
            this.txt欄位搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.dgv會員資料列表 = new System.Windows.Forms.DataGridView();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(40, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox搜尋結果);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.dtp結束時間);
            this.tabPage1.Controls.Add(this.dtp起始時間);
            this.tabPage1.Controls.Add(this.btn搜尋);
            this.tabPage1.Controls.Add(this.combo資料欄位);
            this.tabPage1.Controls.Add(this.txt欄位搜尋關鍵字);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料搜尋";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 47);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 2, 100, 2);
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "搜尋結果";
            // 
            // listBox搜尋結果
            // 
            this.listBox搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox搜尋結果.FormattingEnabled = true;
            this.listBox搜尋結果.ItemHeight = 29;
            this.listBox搜尋結果.Location = new System.Drawing.Point(578, 89);
            this.listBox搜尋結果.Name = "listBox搜尋結果";
            this.listBox搜尋結果.Size = new System.Drawing.Size(406, 439);
            this.listBox搜尋結果.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox5.Controls.Add(this.radio已婚);
            this.groupBox5.Controls.Add(this.radio單身);
            this.groupBox5.Controls.Add(this.radio全部);
            this.groupBox5.Location = new System.Drawing.Point(70, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 81);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // radio已婚
            // 
            this.radio已婚.AutoSize = true;
            this.radio已婚.Location = new System.Drawing.Point(217, 28);
            this.radio已婚.Name = "radio已婚";
            this.radio已婚.Size = new System.Drawing.Size(73, 29);
            this.radio已婚.TabIndex = 2;
            this.radio已婚.TabStop = true;
            this.radio已婚.Text = "已婚";
            this.radio已婚.UseVisualStyleBackColor = true;
            this.radio已婚.CheckedChanged += new System.EventHandler(this.radio已婚_CheckedChanged);
            // 
            // radio單身
            // 
            this.radio單身.AutoSize = true;
            this.radio單身.Location = new System.Drawing.Point(121, 28);
            this.radio單身.Name = "radio單身";
            this.radio單身.Size = new System.Drawing.Size(73, 29);
            this.radio單身.TabIndex = 1;
            this.radio單身.TabStop = true;
            this.radio單身.Text = "單身";
            this.radio單身.UseVisualStyleBackColor = true;
            this.radio單身.CheckedChanged += new System.EventHandler(this.radio單身_CheckedChanged);
            // 
            // radio全部
            // 
            this.radio全部.AutoSize = true;
            this.radio全部.Location = new System.Drawing.Point(33, 28);
            this.radio全部.Name = "radio全部";
            this.radio全部.Size = new System.Drawing.Size(73, 29);
            this.radio全部.TabIndex = 0;
            this.radio全部.TabStop = true;
            this.radio全部.Text = "全部";
            this.radio全部.UseVisualStyleBackColor = true;
            this.radio全部.CheckedChanged += new System.EventHandler(this.radio全部_CheckedChanged);
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Location = new System.Drawing.Point(156, 271);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(231, 34);
            this.dtp結束時間.TabIndex = 21;
            // 
            // dtp起始時間
            // 
            this.dtp起始時間.Location = new System.Drawing.Point(156, 221);
            this.dtp起始時間.Name = "dtp起始時間";
            this.dtp起始時間.Size = new System.Drawing.Size(231, 34);
            this.dtp起始時間.TabIndex = 20;
            this.dtp起始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Location = new System.Drawing.Point(173, 489);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(134, 39);
            this.btn搜尋.TabIndex = 19;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // combo資料欄位
            // 
            this.combo資料欄位.FormattingEnabled = true;
            this.combo資料欄位.Location = new System.Drawing.Point(70, 109);
            this.combo資料欄位.Name = "combo資料欄位";
            this.combo資料欄位.Size = new System.Drawing.Size(118, 33);
            this.combo資料欄位.TabIndex = 18;
            // 
            // txt欄位搜尋關鍵字
            // 
            this.txt欄位搜尋關鍵字.Location = new System.Drawing.Point(191, 108);
            this.txt欄位搜尋關鍵字.Name = "txt欄位搜尋關鍵字";
            this.txt欄位搜尋關鍵字.Size = new System.Drawing.Size(182, 34);
            this.txt欄位搜尋關鍵字.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(65, 340);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(90, 0, 100, 0);
            this.label13.Size = new System.Drawing.Size(341, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "婚姻狀態選擇";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(65, 168);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(90, 0, 100, 0);
            this.label12.Size = new System.Drawing.Size(341, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "生日區間搜尋";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PeachPuff;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(114, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "從";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PeachPuff;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(114, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "到";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(65, 63);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(80, 0, 85, 0);
            this.label9.Size = new System.Drawing.Size(339, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "欄位關鍵字搜尋";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.Controls.Add(this.btn重新整理);
            this.tabPage2.Controls.Add(this.dgv會員資料列表);
            this.tabPage2.Controls.Add(this.btn資料修改);
            this.tabPage2.Controls.Add(this.btn清空欄位);
            this.tabPage2.Controls.Add(this.btn刪除資料);
            this.tabPage2.Controls.Add(this.btn新增資料);
            this.tabPage2.Controls.Add(this.chk婚姻狀態);
            this.tabPage2.Controls.Add(this.dtp生日);
            this.tabPage2.Controls.Add(this.txt點數);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txt地址);
            this.tabPage2.Controls.Add(this.txt電話);
            this.tabPage2.Controls.Add(this.txt姓名);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "資料更改";
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.Bisque;
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.ForeColor = System.Drawing.Color.Black;
            this.btn重新整理.Location = new System.Drawing.Point(880, 518);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(120, 36);
            this.btn重新整理.TabIndex = 58;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // dgv會員資料列表
            // 
            this.dgv會員資料列表.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料列表.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv會員資料列表.Location = new System.Drawing.Point(442, 28);
            this.dgv會員資料列表.Name = "dgv會員資料列表";
            this.dgv會員資料列表.RowHeadersWidth = 51;
            this.dgv會員資料列表.RowTemplate.Height = 27;
            this.dgv會員資料列表.Size = new System.Drawing.Size(587, 470);
            this.dgv會員資料列表.TabIndex = 55;
            this.dgv會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料列表_CellClick);
            // 
            // btn資料修改
            // 
            this.btn資料修改.BackColor = System.Drawing.Color.Cornsilk;
            this.btn資料修改.Location = new System.Drawing.Point(30, 485);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(120, 50);
            this.btn資料修改.TabIndex = 54;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = false;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.Gainsboro;
            this.btn清空欄位.Location = new System.Drawing.Point(289, 394);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(107, 38);
            this.btn清空欄位.TabIndex = 53;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.BackColor = System.Drawing.Color.Cornsilk;
            this.btn刪除資料.Location = new System.Drawing.Point(316, 485);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(120, 50);
            this.btn刪除資料.TabIndex = 52;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = false;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.BackColor = System.Drawing.Color.Cornsilk;
            this.btn新增資料.Location = new System.Drawing.Point(171, 485);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(120, 50);
            this.btn新增資料.TabIndex = 51;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = false;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk婚姻狀態.Location = new System.Drawing.Point(168, 300);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(81, 33);
            this.chk婚姻狀態.TabIndex = 49;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(142, 256);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(254, 38);
            this.dtp生日.TabIndex = 48;
            // 
            // txt點數
            // 
            this.txt點數.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(152, 350);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(244, 38);
            this.txt點數.TabIndex = 47;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(152, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 38);
            this.txtEmail.TabIndex = 46;
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(152, 168);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(244, 38);
            this.txt地址.TabIndex = 45;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(152, 124);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(244, 38);
            this.txt電話.TabIndex = 44;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(152, 80);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(244, 38);
            this.txt姓名.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Moccasin;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(156, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 29);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(44, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(44, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(44, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(44, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "點數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(44, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "婚姻狀態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "電話";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(60, 38);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 29);
            this.label14.TabIndex = 34;
            this.label14.Text = "ID";
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1113, 691);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio已婚;
        private System.Windows.Forms.RadioButton radio單身;
        private System.Windows.Forms.RadioButton radio全部;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp起始時間;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox combo資料欄位;
        private System.Windows.Forms.TextBox txt欄位搜尋關鍵字;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox搜尋結果;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.DataGridView dgv會員資料列表;
        private System.Windows.Forms.Button btn重新整理;
    }
}