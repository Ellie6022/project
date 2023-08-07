namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage訂購資料 = new System.Windows.Forms.TabPage();
            this.btn資料送出 = new System.Windows.Forms.Button();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt內用桌號 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio外帶 = new System.Windows.Forms.RadioButton();
            this.radio內用 = new System.Windows.Forms.RadioButton();
            this.tabPage甜點 = new System.Windows.Forms.TabPage();
            this.txt甜點數量 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl訂購資訊甜點區 = new System.Windows.Forms.Label();
            this.listView甜點 = new System.Windows.Forms.ListView();
            this.tabPage飲料 = new System.Windows.Forms.TabPage();
            this.txt飲料數量 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo甜度 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.combo冰塊 = new System.Windows.Forms.ComboBox();
            this.listView飲料 = new System.Windows.Forms.ListView();
            this.lbl訂購資訊飲料區 = new System.Windows.Forms.Label();
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.imageList甜點產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.imageList飲料產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.lbl菜單訂購總價 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage訂購資料.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage甜點.SuspendLayout();
            this.tabPage飲料.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage訂購資料);
            this.tabControl1.Controls.Add(this.tabPage甜點);
            this.tabControl1.Controls.Add(this.tabPage飲料);
            this.tabControl1.Location = new System.Drawing.Point(27, 66);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 543);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage訂購資料
            // 
            this.tabPage訂購資料.BackColor = System.Drawing.Color.Tan;
            this.tabPage訂購資料.Controls.Add(this.btn資料送出);
            this.tabPage訂購資料.Controls.Add(this.txt訂購人);
            this.tabPage訂購資料.Controls.Add(this.label17);
            this.tabPage訂購資料.Controls.Add(this.txt內用桌號);
            this.tabPage訂購資料.Controls.Add(this.label18);
            this.tabPage訂購資料.Controls.Add(this.groupBox1);
            this.tabPage訂購資料.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage訂購資料.Location = new System.Drawing.Point(4, 34);
            this.tabPage訂購資料.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage訂購資料.Name = "tabPage訂購資料";
            this.tabPage訂購資料.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage訂購資料.Size = new System.Drawing.Size(1004, 505);
            this.tabPage訂購資料.TabIndex = 0;
            this.tabPage訂購資料.Text = "訂購資料";
            // 
            // btn資料送出
            // 
            this.btn資料送出.Location = new System.Drawing.Point(429, 373);
            this.btn資料送出.Name = "btn資料送出";
            this.btn資料送出.Size = new System.Drawing.Size(164, 47);
            this.btn資料送出.TabIndex = 10;
            this.btn資料送出.Text = "資料送出";
            this.btn資料送出.UseVisualStyleBackColor = true;
            this.btn資料送出.Click += new System.EventHandler(this.btn資料送出_Click);
            // 
            // txt訂購人
            // 
            this.txt訂購人.Location = new System.Drawing.Point(429, 280);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(254, 38);
            this.txt訂購人.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(315, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 36);
            this.label17.TabIndex = 7;
            this.label17.Text = "訂購人";
            // 
            // txt內用桌號
            // 
            this.txt內用桌號.Location = new System.Drawing.Point(429, 202);
            this.txt內用桌號.Name = "txt內用桌號";
            this.txt內用桌號.Size = new System.Drawing.Size(254, 38);
            this.txt內用桌號.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(287, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 36);
            this.label18.TabIndex = 5;
            this.label18.Text = "內用桌號";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.radio外帶);
            this.groupBox1.Controls.Add(this.radio內用);
            this.groupBox1.Location = new System.Drawing.Point(346, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radio外帶
            // 
            this.radio外帶.AutoSize = true;
            this.radio外帶.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio外帶.Location = new System.Drawing.Point(192, 37);
            this.radio外帶.Name = "radio外帶";
            this.radio外帶.Size = new System.Drawing.Size(92, 40);
            this.radio外帶.TabIndex = 1;
            this.radio外帶.TabStop = true;
            this.radio外帶.Text = "外帶";
            this.radio外帶.UseVisualStyleBackColor = true;
            this.radio外帶.CheckedChanged += new System.EventHandler(this.radio外帶_CheckedChanged);
            // 
            // radio內用
            // 
            this.radio內用.AutoSize = true;
            this.radio內用.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio內用.Location = new System.Drawing.Point(66, 37);
            this.radio內用.Name = "radio內用";
            this.radio內用.Size = new System.Drawing.Size(92, 40);
            this.radio內用.TabIndex = 0;
            this.radio內用.TabStop = true;
            this.radio內用.Text = "內用";
            this.radio內用.UseVisualStyleBackColor = true;
            this.radio內用.CheckedChanged += new System.EventHandler(this.radio內用_CheckedChanged);
            // 
            // tabPage甜點
            // 
            this.tabPage甜點.BackColor = System.Drawing.Color.Tan;
            this.tabPage甜點.Controls.Add(this.txt甜點數量);
            this.tabPage甜點.Controls.Add(this.label4);
            this.tabPage甜點.Controls.Add(this.lbl訂購資訊甜點區);
            this.tabPage甜點.Controls.Add(this.listView甜點);
            this.tabPage甜點.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage甜點.Location = new System.Drawing.Point(4, 34);
            this.tabPage甜點.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage甜點.Name = "tabPage甜點";
            this.tabPage甜點.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage甜點.Size = new System.Drawing.Size(1004, 505);
            this.tabPage甜點.TabIndex = 1;
            this.tabPage甜點.Text = "甜點";
            // 
            // txt甜點數量
            // 
            this.txt甜點數量.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt甜點數量.Location = new System.Drawing.Point(429, 451);
            this.txt甜點數量.Name = "txt甜點數量";
            this.txt甜點數量.Size = new System.Drawing.Size(191, 38);
            this.txt甜點數量.TabIndex = 15;
            this.txt甜點數量.TextChanged += new System.EventHandler(this.txt甜點數量_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(364, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "數量";
            // 
            // lbl訂購資訊甜點區
            // 
            this.lbl訂購資訊甜點區.AutoSize = true;
            this.lbl訂購資訊甜點區.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl訂購資訊甜點區.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購資訊甜點區.Location = new System.Drawing.Point(7, 5);
            this.lbl訂購資訊甜點區.Name = "lbl訂購資訊甜點區";
            this.lbl訂購資訊甜點區.Size = new System.Drawing.Size(157, 29);
            this.lbl訂購資訊甜點區.TabIndex = 3;
            this.lbl訂購資訊甜點區.Text = "姓名 內用外帶";
            // 
            // listView甜點
            // 
            this.listView甜點.BackColor = System.Drawing.Color.Bisque;
            this.listView甜點.HideSelection = false;
            this.listView甜點.Location = new System.Drawing.Point(3, 46);
            this.listView甜點.Name = "listView甜點";
            this.listView甜點.Size = new System.Drawing.Size(994, 399);
            this.listView甜點.TabIndex = 0;
            this.listView甜點.UseCompatibleStateImageBehavior = false;
            this.listView甜點.SelectedIndexChanged += new System.EventHandler(this.listView甜點_SelectedIndexChanged);
            // 
            // tabPage飲料
            // 
            this.tabPage飲料.BackColor = System.Drawing.Color.Tan;
            this.tabPage飲料.Controls.Add(this.txt飲料數量);
            this.tabPage飲料.Controls.Add(this.label5);
            this.tabPage飲料.Controls.Add(this.combo甜度);
            this.tabPage飲料.Controls.Add(this.label15);
            this.tabPage飲料.Controls.Add(this.label16);
            this.tabPage飲料.Controls.Add(this.combo冰塊);
            this.tabPage飲料.Controls.Add(this.listView飲料);
            this.tabPage飲料.Controls.Add(this.lbl訂購資訊飲料區);
            this.tabPage飲料.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage飲料.Location = new System.Drawing.Point(4, 34);
            this.tabPage飲料.Name = "tabPage飲料";
            this.tabPage飲料.Size = new System.Drawing.Size(1004, 505);
            this.tabPage飲料.TabIndex = 2;
            this.tabPage飲料.Text = "飲料";
            // 
            // txt飲料數量
            // 
            this.txt飲料數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt飲料數量.Location = new System.Drawing.Point(783, 468);
            this.txt飲料數量.Name = "txt飲料數量";
            this.txt飲料數量.Size = new System.Drawing.Size(191, 34);
            this.txt飲料數量.TabIndex = 32;
            this.txt飲料數量.TextChanged += new System.EventHandler(this.txt飲料數量_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(725, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "數量";
            // 
            // combo甜度
            // 
            this.combo甜度.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo甜度.FormattingEnabled = true;
            this.combo甜度.Location = new System.Drawing.Point(430, 469);
            this.combo甜度.Name = "combo甜度";
            this.combo甜度.Size = new System.Drawing.Size(211, 33);
            this.combo甜度.TabIndex = 30;
            this.combo甜度.SelectedIndexChanged += new System.EventHandler(this.combo甜度_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Khaki;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(372, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "甜度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Khaki;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(35, 472);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "冰塊";
            // 
            // combo冰塊
            // 
            this.combo冰塊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo冰塊.FormattingEnabled = true;
            this.combo冰塊.Location = new System.Drawing.Point(93, 469);
            this.combo冰塊.Name = "combo冰塊";
            this.combo冰塊.Size = new System.Drawing.Size(211, 33);
            this.combo冰塊.TabIndex = 27;
            this.combo冰塊.SelectedIndexChanged += new System.EventHandler(this.combo冰塊_SelectedIndexChanged);
            // 
            // listView飲料
            // 
            this.listView飲料.BackColor = System.Drawing.Color.Bisque;
            this.listView飲料.HideSelection = false;
            this.listView飲料.Location = new System.Drawing.Point(3, 55);
            this.listView飲料.Name = "listView飲料";
            this.listView飲料.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView飲料.Size = new System.Drawing.Size(988, 398);
            this.listView飲料.TabIndex = 5;
            this.listView飲料.UseCompatibleStateImageBehavior = false;
            this.listView飲料.SelectedIndexChanged += new System.EventHandler(this.listView飲料_SelectedIndexChanged);
            // 
            // lbl訂購資訊飲料區
            // 
            this.lbl訂購資訊飲料區.AutoSize = true;
            this.lbl訂購資訊飲料區.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl訂購資訊飲料區.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購資訊飲料區.Location = new System.Drawing.Point(24, 11);
            this.lbl訂購資訊飲料區.Name = "lbl訂購資訊飲料區";
            this.lbl訂購資訊飲料區.Size = new System.Drawing.Size(157, 29);
            this.lbl訂購資訊飲料區.TabIndex = 4;
            this.lbl訂購資訊飲料區.Text = "姓名 內用外帶";
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.Location = new System.Drawing.Point(588, 614);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(164, 49);
            this.btn查看購物車.TabIndex = 33;
            this.btn查看購物車.Text = "查看購物車";
            this.btn查看購物車.UseVisualStyleBackColor = true;
            this.btn查看購物車.Click += new System.EventHandler(this.btn查看購物車_Click);
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Location = new System.Drawing.Point(352, 614);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(164, 49);
            this.btn加入購物車.TabIndex = 7;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Bisque;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label19.Location = new System.Drawing.Point(425, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(22, 8, 22, 8);
            this.label19.Size = new System.Drawing.Size(199, 52);
            this.label19.TabIndex = 8;
            this.label19.Text = "蘇格甜點店";
            // 
            // imageList甜點產品圖檔
            // 
            this.imageList甜點產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList甜點產品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList甜點產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList飲料產品圖檔
            // 
            this.imageList飲料產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList飲料產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList飲料產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl菜單訂購總價
            // 
            this.lbl菜單訂購總價.AutoSize = true;
            this.lbl菜單訂購總價.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl菜單訂購總價.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl菜單訂購總價.Location = new System.Drawing.Point(835, 626);
            this.lbl菜單訂購總價.Name = "lbl菜單訂購總價";
            this.lbl菜單訂購總價.Size = new System.Drawing.Size(198, 29);
            this.lbl菜單訂購總價.TabIndex = 17;
            this.lbl菜單訂購總價.Text = "訂單總價00000元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1065, 675);
            this.Controls.Add(this.btn查看購物車);
            this.Controls.Add(this.lbl菜單訂購總價);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn加入購物車);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "蘇格甜點店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage訂購資料.ResumeLayout(false);
            this.tabPage訂購資料.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage甜點.ResumeLayout(false);
            this.tabPage甜點.PerformLayout();
            this.tabPage飲料.ResumeLayout(false);
            this.tabPage飲料.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage訂購資料;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio外帶;
        private System.Windows.Forms.RadioButton radio內用;
        private System.Windows.Forms.TabPage tabPage甜點;
        private System.Windows.Forms.TabPage tabPage飲料;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn資料送出;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt內用桌號;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView listView甜點;
        private System.Windows.Forms.ComboBox combo甜度;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox combo冰塊;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.ListView listView飲料;
        private System.Windows.Forms.TextBox txt甜點數量;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt飲料數量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList甜點產品圖檔;
        private System.Windows.Forms.ImageList imageList飲料產品圖檔;
        private System.Windows.Forms.Button btn查看購物車;
        public System.Windows.Forms.Label lbl菜單訂購總價;
        public System.Windows.Forms.Label lbl訂購資訊甜點區;
        public System.Windows.Forms.Label lbl訂購資訊飲料區;
    }
}

