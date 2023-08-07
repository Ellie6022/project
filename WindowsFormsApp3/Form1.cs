using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();

        int 菜單所選品項總價 = 0;

        int 所選甜點數量 = 0;
        int 所選甜點單價 = 0;
        string 所選甜點品項 = "";
         int 所選飲料數量 = 0;
        int 所選飲料單價 = 0;
        int 所選甜點總價 = 0;
        int 所選飲料總價 = 0;
        string 所選飲料品項 = "";
        string 所選飲料甜度 = "";
        string 所選飲料冰塊 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";  
            scsb.InitialCatalog = "myproductdb";   //資料庫名稱
            scsb.IntegratedSecurity = true;     
            strDBConnectionString = scsb.ConnectionString;

            讀取甜點商品資料庫();
            讀取飲料商品資料庫();
            顯示list甜點圖片();
            顯示list飲料圖片();

            //糖度
            list甜度.Add("正常糖");
            list甜度.Add("半糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");
            //冰塊
            list冰塊.Add("正常冰");
            list冰塊.Add("少冰");
            list冰塊.Add("去冰");

            foreach (string item in list甜度)
            {
                combo甜度.Items.Add(item);
            }

            foreach (string item in list冰塊)
            {
                combo冰塊.Items.Add(item);
            }
            txt甜點數量.Text = 1.ToString();
            所選甜點數量 =Convert.ToInt32( txt甜點數量.Text);
            combo甜度.SelectedIndex = 0;  //所選索引值
            所選飲料甜度 = list甜度[combo甜度.SelectedIndex];
            combo冰塊.SelectedIndex = 0;
            所選飲料冰塊 = list冰塊[combo冰塊.SelectedIndex];
            txt飲料數量.Text = 1.ToString();
            所選飲料數量 = Convert.ToInt32(txt飲料數量.Text); ;
            radio外帶.Checked = true;
            Global.is外帶 = true;
            Global.is購物袋 = false;
            btn加入購物車.Visible = false;
            btn查看購物車.Visible = false;
            if (Global.str登入身分 == "會員")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select 姓名,email from members where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", Global.會員id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    Global.會員姓名 = reader["姓名"].ToString();
                    txt訂購人.Text = Global.會員姓名;
                    Global.會員信箱 = reader["email"].ToString();
                }
            } 
            else if (Global.str登入身分 == "員工") 
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select 姓名 from staff where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", Global.員工id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    Global.員工姓名 = reader["姓名"].ToString();
                    txt訂購人.Text = Global.員工姓名;
                    //Global.員工信箱 = reader["信箱"].ToString();

                }
            }
        }
        void 讀取甜點商品資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from dessertshop where catalog='甜點';";  
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read() == true)
            {
                Global.list甜點Pid.Add((int)reader["id"]);
                Global.list甜點Name.Add((string)reader["pname"]);
                Global.list甜點Price.Add((int)reader["price"]);

                string image_name = (string)reader["pimage"];
                string 甜點圖檔路徑 = $"{Global.image_dir甜點飲料}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(甜點圖檔路徑);   //Image為圖片物件。FromFile:建立image，從路徑中的位置。
                imageList甜點產品圖檔.Images.Add(img產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 讀取飲料商品資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from dessertshop where catalog='飲料';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read() == true)
            {
                Global.list飲料Pid.Add((int)reader["id"]);
                Global.list飲料Name.Add((string)reader["pname"]);
                Global.list飲料Price.Add((int)reader["price"]);

                string image_name = (string)reader["pimage"];
                //string 飲料圖檔路徑 = $"{Global.image_dir飲料}\\{image_name}";
                string 飲料圖檔路徑 = $"{Global.image_dir甜點飲料}\\{image_name}";
                Image img飲料產品圖檔 = Image.FromFile(飲料圖檔路徑);     //Image為圖片物件。FromFile:建立image，從路徑中的位置。

                imageList飲料產品圖檔.Images.Add(img飲料產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示list甜點圖片()
        {   //因為上面的"讀取商品資料庫()"方法已經將圖檔傳送進來，所以這裡就不用連接資料庫。
            listView甜點.Clear();
            listView甜點.View = View.LargeIcon; //view可以種元件的顯示方式，可以顯示圖示和文字，有LargeIcon,SmallIcon,List,Tile等不同顯示方式。
            imageList甜點產品圖檔.ImageSize = new Size(150, 150);
            listView甜點.LargeImageList = imageList甜點產品圖檔;    //LargeIcon,Tile
            listView甜點.SmallImageList = imageList甜點產品圖檔;    //必須是小圖。SmallIcon,List

            for (int i = 0; i < imageList甜點產品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); //ListViewItem為一種容器。
                item.ImageIndex = i;
                item.Text = $"{Global.list甜點Name[i]}{Global.list甜點Price[i]}元";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = Global.list甜點Pid[i];  //Tag放id，後面會使用點擊項目item，會跳出此item的細項。
                listView甜點.Items.Add(item);
            }

        }
        void 顯示list飲料圖片()
        { 
            listView飲料.Clear();
            listView飲料.View = View.LargeIcon;
            imageList飲料產品圖檔.ImageSize = new Size(150, 150);
            listView飲料.LargeImageList = imageList飲料產品圖檔;  
            listView飲料.SmallImageList = imageList飲料產品圖檔;   

            for (int i = 0; i < imageList飲料產品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); 
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = $"{Global.list飲料Name[i]}{Global.list飲料Price[i ]}元";
                item.Tag = Global.list飲料Pid[i];  
                listView飲料.Items.Add(item);
            }

        }
        private void radio內用_CheckedChanged(object sender, EventArgs e)
        {
            txt內用桌號.Enabled = true;
            txt內用桌號.Text = "";
            Global.is外帶 = false;

        }
        private void radio外帶_CheckedChanged(object sender, EventArgs e)
        {
            txt內用桌號.Enabled = false;
            txt內用桌號.Text = "外帶不用輸入";
            Global.is外帶 = true;

        }
        private void btn資料送出_Click(object sender, EventArgs e)
        {
            if (txt訂購人.Text != "" && ((radio內用.Checked == true&& txt內用桌號.Text != "") || radio外帶.Checked == true))
            {
                Global.訂購人資訊 = txt訂購人.Text;
                if (radio內用.Checked == true)
                {
                    Global.內用桌號 = txt內用桌號.Text;
                      lbl訂購資訊甜點區.Text = $"{Global.訂購人資訊} 您好！  內用：{Global.內用桌號}桌";
                      lbl訂購資訊飲料區.Text = $"{Global.訂購人資訊} 您好！  內用：{Global.內用桌號}桌";         
                      Global.is外帶=false;
                }
                else
                {                 
                    lbl訂購資訊甜點區.Text = $"{Global.訂購人資訊} 您好！  外帶";
                    lbl訂購資訊飲料區.Text = $"{Global.訂購人資訊} 您好！ 外帶";
                    Global.is外帶 = true;

                }
                Global.訂購人輸入完整 = true;
                MessageBox.Show("填寫完成，請至下一頁開始點餐!!");
                tabControl1.SelectedTab = tabPage甜點;
            }
            else 
            {
                if (radio內用.Checked == true && txt內用桌號.Text == "")
                {
                    MessageBox.Show("請輸入內用桌號!!");
                }
                else if ((radio內用.Checked == true|| radio外帶.Checked == true )&& txt訂購人.Text == "")
                {
                    MessageBox.Show("請輸入訂購人姓名!!");

                }             
                else
                {
                    MessageBox.Show("請輸入訂購資訊!!");

                }
                Global.訂購人輸入完整 = false;

            }
        }
        private void btn甜點確認送出_Click(object sender, EventArgs e)
        {   //多的
        }
        private void btn飲料確認送出_Click(object sender, EventArgs e)
        {//多的
        }

        private void txt甜點數量_TextChanged(object sender, EventArgs e)
        {
            if (txt甜點數量.Text != "")
            {
                bool is甜點數量輸入正確 = Int32.TryParse(txt甜點數量.Text, out 所選甜點數量);
                if ((is甜點數量輸入正確 == false) || (所選甜點數量 <= 0))
                {
                    MessageBox.Show("杯數輸入不正確,至少一杯");
                    所選甜點數量 = 1;
                    txt甜點數量.Text = 所選甜點數量.ToString();
                }               
            }
        }

        private void txt飲料數量_TextChanged(object sender, EventArgs e)
        {
            if (txt飲料數量.Text != "")
            {
                bool is杯數輸入正確 = Int32.TryParse(txt飲料數量.Text, out 所選飲料數量);
                if ((is杯數輸入正確 == false) || (所選飲料數量 <= 0))
                {
                    MessageBox.Show("杯數輸入不正確,至少一杯");
                    所選飲料數量 = 1;
                    txt飲料數量.Text = 所選飲料數量.ToString();
                }
            }
        }

        private void combo冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選飲料冰塊 = list冰塊[combo冰塊.SelectedIndex];

        }

        private void combo甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選飲料甜度 = list甜度[combo甜度.SelectedIndex];

        }

        private void btn甜點加入購物車_Click(object sender, EventArgs e)
        {//多的   
        }     
        private void btn查看購物車甜點區_Click(object sender, EventArgs e)
        {      //多的   
        }
        private void btn飲料加入購物車_Click(object sender, EventArgs e)
        {   //多的        
        }  
        private void btn查看購物車飲料區_Click(object sender, EventArgs e)
        {   //多的      
        }

        void 計算甜點總價() 
        {
           
            foreach (ListViewItem item in listView甜點.SelectedItems)
            {
                //int select甜點ID = item.Index;
                //所選甜點品項 =list甜點品項[select甜點ID];                
                //所選甜點單價 = list甜點價格[select甜點ID];

                int select甜點ID = item.Index;
                所選甜點品項 = Global.list甜點Name[select甜點ID];
                所選甜點單價 = Global.list甜點Price[select甜點ID];

                所選甜點數量 = Convert.ToInt32(txt甜點數量.Text);
                所選甜點總價 = 所選甜點單價 * 所選甜點數量;
                菜單所選品項總價 += 所選甜點總價;


                string 甜點訂購列表 = $"{所選甜點品項} {所選甜點單價}元 {所選甜點數量}個 所選甜點總價: {所選甜點總價} 元";
                Global.list訂購甜點品項資料.Add(甜點訂購列表);
            }
        }
        void 計算飲料總價()
        {
            foreach (ListViewItem item in listView飲料.SelectedItems)
            {
                int select飲料ID = item.Index;
                所選飲料品項 = Global.list飲料Name[select飲料ID];
                所選飲料單價 = Global.list飲料Price[select飲料ID];

                所選飲料數量 = Convert.ToInt32(txt飲料數量.Text);
                所選飲料總價 = 所選飲料單價 * 所選飲料數量;
                菜單所選品項總價 += 所選飲料總價;

                string 飲料訂購列表 = $"{所選飲料品項} {所選飲料單價} 元 {所選飲料數量}個 {所選飲料甜度} {所選飲料冰塊} 所選飲料總價: {所選飲料總價} 元";
                Global.list訂購飲料品項資料.Add(飲料訂購列表);
            }
        }

        private void listView甜點_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView飲料.SelectedIndices.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {   //多的

        }
        
        private void listView飲料_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView甜點.SelectedIndices.Clear();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if (listView甜點.SelectedItems.Count != 0 || listView飲料.SelectedItems.Count != 0)
            {
                計算飲料總價();
                計算甜點總價();
                
                lbl菜單訂購總價.Text = $"所選品項總價：{菜單所選品項總價}元";


                Global.訂購人資訊 = txt訂購人.Text;
                MessageBox.Show("所選品項已加入購物車");

            }
            else 
            {
                MessageBox.Show("請點選品項和輸入數量!!");
            }
        }

        private void btn查看購物車_Click(object sender, EventArgs e)
        {
            FormOrderList myOrderListForm = new FormOrderList();
            myOrderListForm.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage訂購資料) 
            {
                btn加入購物車.Visible = false;
                btn查看購物車.Visible = false;
            }
            
            if (tabControl1.SelectedTab == tabPage甜點|| tabControl1.SelectedTab == tabPage飲料)
            {
                btn加入購物車.Visible= true;
                btn查看購物車.Visible= true;

                if (txt訂購人.Text == "" )
                {
                    MessageBox.Show("請輸入訂購人資訊並送出!!");
                }
            }          
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage甜點 || e.TabPage == tabPage飲料)
            {
                if (Global.訂購人輸入完整==false)
                {
                    // 如果輸入不完整，則取消切換 TabPage
                    e.Cancel = true;
                    MessageBox.Show("訂購人資訊輸入不完整，請檢查後再繼續。");
                }
            }
        }
    }
}
