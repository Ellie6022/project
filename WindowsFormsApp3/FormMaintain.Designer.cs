namespace WindowsFormsApp3
{
    partial class FormMaintain
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage甜點 = new System.Windows.Forms.TabPage();
            this.listView甜點 = new System.Windows.Forms.ListView();
            this.tabPage飲料 = new System.Windows.Forms.TabPage();
            this.listView飲料 = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.imageList甜點維護 = new System.Windows.Forms.ImageList(this.components);
            this.imageList飲料維護 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage甜點.SuspendLayout();
            this.tabPage飲料.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage甜點);
            this.tabControl1.Controls.Add(this.tabPage飲料);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(33, 109);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 548);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage甜點
            // 
            this.tabPage甜點.BackColor = System.Drawing.Color.Bisque;
            this.tabPage甜點.Controls.Add(this.listView甜點);
            this.tabPage甜點.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage甜點.Location = new System.Drawing.Point(4, 34);
            this.tabPage甜點.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage甜點.Name = "tabPage甜點";
            this.tabPage甜點.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage甜點.Size = new System.Drawing.Size(1045, 510);
            this.tabPage甜點.TabIndex = 1;
            this.tabPage甜點.Text = "甜點";
            // 
            // listView甜點
            // 
            this.listView甜點.BackColor = System.Drawing.Color.Bisque;
            this.listView甜點.HideSelection = false;
            this.listView甜點.Location = new System.Drawing.Point(24, 30);
            this.listView甜點.Name = "listView甜點";
            this.listView甜點.Size = new System.Drawing.Size(995, 452);
            this.listView甜點.TabIndex = 0;
            this.listView甜點.UseCompatibleStateImageBehavior = false;
            this.listView甜點.ItemActivate += new System.EventHandler(this.listView甜點_ItemActivate);
            // 
            // tabPage飲料
            // 
            this.tabPage飲料.BackColor = System.Drawing.Color.Bisque;
            this.tabPage飲料.Controls.Add(this.listView飲料);
            this.tabPage飲料.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage飲料.Location = new System.Drawing.Point(4, 34);
            this.tabPage飲料.Name = "tabPage飲料";
            this.tabPage飲料.Size = new System.Drawing.Size(1045, 510);
            this.tabPage飲料.TabIndex = 2;
            this.tabPage飲料.Text = "飲料";
            // 
            // listView飲料
            // 
            this.listView飲料.BackColor = System.Drawing.Color.Bisque;
            this.listView飲料.HideSelection = false;
            this.listView飲料.Location = new System.Drawing.Point(20, 22);
            this.listView飲料.Name = "listView飲料";
            this.listView飲料.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView飲料.Size = new System.Drawing.Size(1006, 464);
            this.listView飲料.TabIndex = 5;
            this.listView飲料.UseCompatibleStateImageBehavior = false;
            this.listView飲料.ItemActivate += new System.EventHandler(this.listView飲料_ItemActivate);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Bisque;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label19.Location = new System.Drawing.Point(434, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(22, 8, 22, 8);
            this.label19.Size = new System.Drawing.Size(227, 52);
            this.label19.TabIndex = 9;
            this.label19.Text = "蘇格商品列表";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.BackColor = System.Drawing.Color.RosyBrown;
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.ForeColor = System.Drawing.Color.White;
            this.btn圖片模式.Location = new System.Drawing.Point(751, 61);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(138, 40);
            this.btn圖片模式.TabIndex = 1;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = false;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.BackColor = System.Drawing.Color.RosyBrown;
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.ForeColor = System.Drawing.Color.White;
            this.btn列表模式.Location = new System.Drawing.Point(919, 61);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(138, 40);
            this.btn列表模式.TabIndex = 10;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = false;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.Peru;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.ForeColor = System.Drawing.Color.White;
            this.btn新增商品.Location = new System.Drawing.Point(354, 683);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(172, 46);
            this.btn新增商品.TabIndex = 11;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn重新整理
            // 
            this.btn重新整理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.Location = new System.Drawing.Point(640, 683);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(172, 46);
            this.btn重新整理.TabIndex = 12;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = false;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // imageList甜點維護
            // 
            this.imageList甜點維護.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList甜點維護.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList甜點維護.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList飲料維護
            // 
            this.imageList飲料維護.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList飲料維護.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList飲料維護.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1120, 756);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMaintain";
            this.Text = "FormMaintain";
            this.Load += new System.EventHandler(this.FormMaintain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage甜點.ResumeLayout(false);
            this.tabPage飲料.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage甜點;
        private System.Windows.Forms.ListView listView甜點;
        private System.Windows.Forms.TabPage tabPage飲料;
        private System.Windows.Forms.ListView listView飲料;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.ImageList imageList甜點維護;
        private System.Windows.Forms.ImageList imageList飲料維護;
    }
}