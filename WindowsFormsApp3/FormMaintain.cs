using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class FormMaintain : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormMaintain()
        {
            InitializeComponent();
        }

        private void FormMaintain_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "myproductdb"; 
            scsb.IntegratedSecurity = true;  
            Global.strDBConnectionString = scsb.ConnectionString;

            讀取甜點商品資料庫();
            讀取飲料商品資料庫();
            顯示list甜點圖片();
            顯示list飲料圖片();
            if (Global.str登入身分=="會員" || Global.str登入身分 =="訪客") 
            {
                btn新增商品.Visible = false;
                btn重新整理.Visible=false;
            }
        }
        void 讀取甜點商品資料庫()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
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
                imageList甜點維護.Images.Add(img產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 讀取飲料商品資料庫()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
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
                string 飲料圖檔路徑 = $"{Global.image_dir甜點飲料}\\{image_name}";
                Image img飲料產品圖檔 = Image.FromFile(飲料圖檔路徑);     //Image為圖片物件。FromFile:建立image，從路徑中的位置。

                imageList飲料維護.Images.Add(img飲料產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示list甜點圖片()
        {  
            listView甜點.Clear();
            listView甜點.View = View.LargeIcon; //view可以種元件的顯示方式，可以顯示圖示和文字，有LargeIcon,SmallIcon,List,Tile等不同顯示方式。
            imageList甜點維護.ImageSize = new Size(150, 150);
            listView甜點.LargeImageList = imageList甜點維護;    
            listView甜點.SmallImageList = imageList甜點維護;   

            for (int i = 0; i < imageList甜點維護.Images.Count; i++)
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
            imageList飲料維護.ImageSize = new Size(150, 150);
            listView飲料.LargeImageList = imageList飲料維護;
            listView飲料.SmallImageList = imageList飲料維護;

            for (int i = 0; i < imageList飲料維護.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{Global.list飲料Name[i]}{Global.list飲料Price[i]}元";
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = Global.list飲料Pid[i];
                listView飲料.Items.Add(item);
            }

        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {

                顯示list甜點圖片();
                顯示list飲料圖片();
            
        }


        void 顯示甜點listView_列表模式()
        {
            listView甜點.Clear();
            listView甜點.LargeImageList = null; //null會將listview商品展示指向LargeImageList記憶體位置斷開。
            listView甜點.SmallImageList = null;
            listView甜點.View = View.Details;   //列表模式可以使用Details。
            listView甜點.Columns.Add("id", 100); //Columns需要新增兩個參數，欄位名稱以及欄位寬度。
            listView甜點.Columns.Add("商品名稱", 200);
            listView甜點.Columns.Add("商品價格", 100);
            listView甜點.GridLines = true;  //GridLines:製作格線
            listView甜點.FullRowSelect = true;  //FullRowSelect :在選擇其中一個欄位時，可以整列都被選取。

            for (int i = 0; i < Global.list甜點Pid.Count; i += 1)
            {
                ListViewItem listItem甜點 = new ListViewItem();
                listItem甜點.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem甜點.Text = Global.list甜點Pid[i].ToString();  //第一個欄位用Text，第二個欄位用SubItem。
                listItem甜點.SubItems.Add(Global.list甜點Name[i]);  //如果有兩個欄位以上用SubItem。
                listItem甜點.SubItems.Add(Global.list甜點Price[i].ToString());
                listItem甜點.Tag = Global.list甜點Pid[i];
                listView甜點.Items.Add(listItem甜點);

            }
        }
        void 顯示飲料listView_列表模式()
        {
            listView飲料.Clear();
            listView飲料.LargeImageList = null; 
            listView飲料.SmallImageList = null;
            listView飲料.View = View.Details; 
            listView飲料.Columns.Add("id", 100); 
            listView飲料.Columns.Add("商品名稱", 200);
            listView飲料.Columns.Add("商品價格", 100);
            listView飲料.GridLines = true;  
            listView飲料.FullRowSelect = true; 

            for (int i = 0; i < Global.list飲料Pid.Count; i += 1)
            {
                ListViewItem listItem飲料 = new ListViewItem();
                listItem飲料.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem飲料.Text = Global.list飲料Pid[i].ToString();
                listItem飲料.SubItems.Add(Global.list飲料Name[i]);
                listItem飲料.SubItems.Add(Global.list飲料Price[i].ToString());
                listItem飲料.Tag = Global.list飲料Pid[i];
                listView飲料.Items.Add(listItem飲料);

            }
        }
        private void btn列表模式_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage甜點)
            {
                顯示甜點listView_列表模式();
            }
            else 
            {
                顯示飲料listView_列表模式();
            }
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            FormDetail myDetailForm = new FormDetail();  //FormDetail為自創的表單名稱。
            myDetailForm.ShowDialog();

        }
        void 重新載入資料()
        {
            Global.list甜點Pid.Clear();
            Global.list甜點Name.Clear();
            Global.list甜點Price.Clear();

            Global.list飲料Pid.Clear();
            Global.list飲料Name.Clear();
            Global.list飲料Price.Clear();

            imageList甜點維護.Images.Clear();
            imageList飲料維護.Images.Clear();

            讀取甜點商品資料庫();
            讀取飲料商品資料庫();

            //使用原來顯示的模式，在列表模式就留在列表模式，不切換。
            if (listView飲料.View == View.Details|| listView甜點.View == View.Details)
            {
                顯示甜點listView_列表模式();
                顯示飲料listView_列表模式();

            }
            else
            {
                顯示list甜點圖片();
                顯示list飲料圖片();

            }
        }
        private void btn重新整理_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void listView甜點_ItemActivate(object sender, EventArgs e)
        { 
                FormDetail myDetailForm = new FormDetail();
                myDetailForm.selectID = (int)listView甜點.SelectedItems[0].Tag; //這裡Tag存的為id
                myDetailForm.ShowDialog();
        }

        private void listView飲料_ItemActivate(object sender, EventArgs e)
        {
            FormDetail myDetailForm = new FormDetail();
            myDetailForm.selectID = (int)listView飲料.SelectedItems[0].Tag; //這裡Tag存的為id
            myDetailForm.ShowDialog();
        }

        private void btn下架商品_Click(object sender, EventArgs e)
        {   //多的          
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
