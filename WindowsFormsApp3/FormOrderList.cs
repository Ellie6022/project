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

namespace WindowsFormsApp3
{
    public partial class FormOrderList : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";  //伺服器名稱; . 代表本機。
            scsb.InitialCatalog = "myproductdb";   //資料庫名稱
            scsb.IntegratedSecurity = true;     //Windows驗證
            Global.strDBConnectionString = scsb.ConnectionString;

            if (Global.is外帶 == true)
            {
                lbl訂購資訊購物車區.Text = $"{Global.訂購人資訊} 您好!  外帶";
            }
            else
            {
                lbl訂購資訊購物車區.Text = $"{Global.訂購人資訊} 您好!  內用：{Global.內用桌號} 桌";
            }


            for (int i = 0; i < Global.list訂購甜點品項資料.Count; i++)
            {
                listBox訂購甜點品項列表.Items.Add(Global.list訂購甜點品項資料[i]);
            }
            for (int i = 0; i < Global.list訂購飲料品項資料.Count; i++)
            {
                listBox訂購飲料品項列表.Items.Add(Global.list訂購飲料品項資料[i]);
            }
            計算訂單總價();
            
        }

        void 計算訂單總價()
        {
            //int 訂單總價 = 0;
            int 訂單甜點總價 = 0;
            int 訂單飲料總價 = 0;

            foreach (string 訂購單品 in Global.list訂購甜點品項資料)
            {
                string[] 甜點資訊 = 訂購單品.Split(' ');
                int 甜點總價 = Convert.ToInt32(甜點資訊[甜點資訊.Length - 2]);
                訂單甜點總價 += 甜點總價;
            }
            foreach (string 訂購單品 in Global.list訂購飲料品項資料)
            {
                string[] 飲料資訊 = 訂購單品.Split(' ');
                int 飲料總價 = Convert.ToInt32(飲料資訊[飲料資訊.Length - 2]);
                訂單飲料總價 += 飲料總價;
            }
            Global.訂單總價 = 訂單甜點總價 + 訂單飲料總價;

            if ((Global.is購物袋 == true) && ((Global.list訂購甜點品項資料.Count > 0) || (Global.list訂購飲料品項資料.Count > 0)))
            {
                Global.訂單總價 += 2;
            }
            lbl訂購總價.Text = $"訂單總價： {Global.訂單總價} 元";
        }
        private void chk購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk購物袋.Checked == true)
            {
                Global.is購物袋 = true;
                Console.WriteLine(Global.is購物袋);
            }
            else
            {
                Global.is購物袋 = false;
            }
            計算訂單總價();
        }
        private void btn清除所有品項_Click(object sender, EventArgs e)
        {   //多的
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {   //多的
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn輸出訂購單_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"D:\Users\azx87\Desktop";  //路徑前面要加上@
            Random myRnd = new Random();
            int rndNum = myRnd.Next(1000, 10000);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + rndNum + "訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();   //建立檔案儲存對話框
            sfd.InitialDirectory = str檔案路徑;//InitialDirectory初始目錄
            sfd.FileName = str檔名;   //檔案名稱
            sfd.Filter = "文字檔|*.txt";  //存檔類型。Filter為檔案過濾器:只能儲存指定的檔案格式。|左邊為檔案的描述(自己設計)，右邊為固定寫法*.附檔名

            DialogResult R = sfd.ShowDialog();       //DialogResult為對話方塊，有回傳值。

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;

            }
            else
            {
                return; //結束方法
            }

            //訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            //每Add就是新增一列(行)。
            list訂單資訊.Add("*****************冷飲訂購單******************");
            list訂單資訊.Add("-------------------------------------------------");
            list訂單資訊.Add($"訂購時間:{DateTime.Now} \n訂購人:{Global.訂購人資訊}");
            list訂單資訊.Add("==========<<訂購品項>>==========");

            for (int i = 0; i < Global.list訂購甜點品項資料.Count; i++)
            {
                list訂單資訊.Add(Global.list訂購甜點品項資料[i]);
            }
            for (int i = 0; i < Global.list訂購飲料品項資料.Count; i++)
            {
                list訂單資訊.Add(Global.list訂購飲料品項資料[i]);
            }

            list訂單資訊.Add("-------------------------------------------------");
            //list訂單資訊.Add($"{lbl外帶.Text}{lbl買購物袋.Text}");
            list訂單資訊.Add("-------------------------------------------------");
            list訂單資訊.Add($"{lbl訂購總價.Text}元");
            list訂單資訊.Add("==============================");
            list訂單資訊.Add("*********************謝謝光臨********************");
            // System.IO為命名空間，若有頭部有加上using System.IO，這邊就不用加。
            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            //File.WriteAllLines使用指定編碼方式建立新檔案，並將字串的集合寫入檔案，然後關閉檔案。
            //Encoding.UTF8字元編碼的萬國碼
            MessageBox.Show("訂購單存檔成功!!");
        
    

        }

        private void btn移除甜點所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購甜點品項列表.SelectedIndex >= 0 || listBox訂購飲料品項列表.SelectedIndex >= 0)
            {
                int 甜點Index = listBox訂購甜點品項列表.SelectedIndex;
                Global.list訂購甜點品項資料.RemoveAt(甜點Index);
                listBox訂購甜點品項列表.Items.RemoveAt(甜點Index);

                計算訂單總價();

            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }       
        }

        private void btn清除甜點所有品項_Click(object sender, EventArgs e)
        {
            listBox訂購甜點品項列表.Items.Clear();
            Global.list訂購甜點品項資料.Clear();
            計算訂單總價();
        }

        private void btn訂單送出_Click(object sender, EventArgs e)
        {
            string[] 甜點資訊 = lbl訂購總價.Text.Split(' ');
            int 送出訂單總價 = Convert.ToInt32(甜點資訊[甜點資訊.Length - 2]);

            string str所有品項訂購單 = string.Join("\n", listBox訂購甜點品項列表.Items.Cast<string>()) + string.Join("\n", listBox訂購飲料品項列表.Items.Cast<string>()); ;

            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "insert into ordermanage values (@NewCustomer,@NewTakeout,@NewTable,@NewItems,@NewBag,@NewTotalprice,@NewConditon);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewCustomer", Global.訂購人資訊);
            cmd.Parameters.AddWithValue("@NewTakeout",Global.is外帶 );
            cmd.Parameters.AddWithValue("@NewTable",Global.內用桌號 );
            cmd.Parameters.AddWithValue("@NewItems", str所有品項訂購單);
            cmd.Parameters.AddWithValue("@NewBag", Global.is購物袋);

            cmd.Parameters.AddWithValue("@NewTotalprice", 送出訂單總價);
            cmd.Parameters.AddWithValue("@NewConditon", "訂單送出");

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"訂單送出成功,{rows}筆資料受影響!");
            Close();

            //會員點數
            if (Global.str登入身分=="會員") 
            {
                //讀取會員姓名、會員點數
                con.Open();
                string strSQL會員 = "select 姓名,點數 from members where id=@SearchID;";
                SqlCommand cmd會員 = new SqlCommand(strSQL會員, con);
                cmd會員.Parameters.AddWithValue("@SearchID", Global.會員id);
                SqlDataReader reader = cmd會員.ExecuteReader();
                if (reader.Read() == true)
                {
                    int 點數 = Convert.ToInt32(reader["點數"]);
                    
                    if (送出訂單總價 > 100)
                    {
                        Global.會員新增點數 = (int)(送出訂單總價 / 100); // 取整數部分
                        Global.會員點數 =點數 + Global.會員新增點數; // 取整數部分
                    }
                }
                reader.Close();

                //更新會員點數
                string strSQL更新會員點數 = "update members set 點數=@NewPoints where id=@SearchID;";
                SqlCommand cmd更新會員點數 = new SqlCommand(strSQL更新會員點數, con);
                cmd更新會員點數.Parameters.AddWithValue("@SearchID", Global.會員id);
                cmd更新會員點數.Parameters.AddWithValue("@NewPoints", (int)Global.會員點數);
                int Rows = cmd更新會員點數.ExecuteNonQuery(); //執行不查詢
                MessageBox.Show($"會員資料修改成功,{Rows}筆資料受影響");
                //con.Close();

                //新增會員點數至MemberPoints資料表
                string strSQL會員點數 = "insert into MemberPoints values (@NewName,@NewEmail,@NewTime,@NewCreatePoint,@NewPoint);";
                SqlCommand cmd會員點數 = new SqlCommand(strSQL會員點數, con);
                cmd會員點數.Parameters.AddWithValue("@NewName", Global.會員姓名);
                cmd會員點數.Parameters.AddWithValue("@NewEmail", Global.會員信箱);
                cmd會員點數.Parameters.AddWithValue("@NewTime", DateTime.Now);
                cmd會員點數.Parameters.AddWithValue("@NewCreatePoint", Global.會員新增點數);
                cmd會員點數.Parameters.AddWithValue("@NewPoint", Global.會員點數);
                int Row = cmd會員點數.ExecuteNonQuery(); //執行不查詢
                con.Close();
            }
        }

        private void btn移除飲料所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購飲料品項列表.SelectedIndex >= 0 || listBox訂購甜點品項列表.SelectedIndex >= 0)
            {
                int 飲料Index = listBox訂購飲料品項列表.SelectedIndex;
                Global.list訂購飲料品項資料.RemoveAt(飲料Index);
                listBox訂購飲料品項列表.Items.RemoveAt(飲料Index);
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        private void btn清除飲料所有品項_Click(object sender, EventArgs e)
        {
            listBox訂購飲料品項列表.Items.Clear();
            Global.list訂購飲料品項資料.Clear();
            計算訂單總價();

        }

        private void listBox訂購甜點品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox訂購飲料品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }
