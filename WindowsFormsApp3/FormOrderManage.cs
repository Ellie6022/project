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

namespace WindowsFormsApp3
{
    public partial class FormOrderManage : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        bool is外帶 = false;
        bool 購物袋 = false;

        public FormOrderManage()
        {
            InitializeComponent();
        }

        private void FormOrderManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myproductdb";
            scsb.IntegratedSecurity = true;

            Global.strDBConnectionString = scsb.ConnectionString;
            combo訂購狀況.Items.Add("訂單送出");
            combo訂購狀況.Items.Add("準備中");
            combo訂購狀況.Items.Add("訂單完成");
            radio外帶.Checked = true;

            combo訂購狀況.SelectedIndex = 0;       
            產生訂購資料列表();
        }
        void 產生訂購資料列表()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "select id as 序號,訂購人,外帶,內用桌號,訂購品項,購物袋,訂單總價,訂單狀況 from ordermanage;";   

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)//HasRows代表有無資料，為Boolean值
            {
                DataTable dt = new DataTable(); // DataTable類似hashtable，可以建立不同欄位和值，也可以一筆一筆建立資料，像是dt.Add("內容")。
                dt.Load(reader);    //載入reader到dt(DataTable)。
                dgv訂購單管理.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            if ((txt訂購人.Text != "") && (txt訂購品項.Text != ""))
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "insert into ordermanage values (@NewCustomer,@NewTakeout,@NewTable,@NewItems,@NewBag,@NewTotalprice,@NewConditon);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCustomer", txt訂購人.Text);
                cmd.Parameters.AddWithValue("@NewTakeout", is外帶);
                cmd.Parameters.AddWithValue("@NewTable", txt內用桌號.Text);
                cmd.Parameters.AddWithValue("@NewItems", txt訂購品項.Text);
                cmd.Parameters.AddWithValue("@NewBag", 購物袋);

                cmd.Parameters.AddWithValue("@NewTotalprice", txt訂單總價.Text);
                cmd.Parameters.AddWithValue("@NewConditon", combo訂購狀況.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");

            }
            else
            {
                MessageBox.Show("訂購人及品項必填!!");
            }
        }

        private void btn修改商品_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt訂購人.Text != "") && (txt訂購品項.Text != ""))
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "update ordermanage set 訂購人=@NewCustomer,外帶=@NewTakeout,內用桌號=@NewTable ,訂購品項=@NewItems ,購物袋=@NewBag,訂單總價=@NewTotalprice,訂單狀況=@NewConditon where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewCustomer", txt訂購人.Text);
                cmd.Parameters.AddWithValue("@NewTakeout", is外帶);
                cmd.Parameters.AddWithValue("@NewTable", txt內用桌號.Text);
                cmd.Parameters.AddWithValue("@NewItems", txt訂購品項.Text);
                cmd.Parameters.AddWithValue("@NewBag", 購物袋);
                cmd.Parameters.AddWithValue("@NewTotalprice", txt訂單總價.Text);
                cmd.Parameters.AddWithValue("@NewConditon", combo訂購狀況.Text);

                int rows = cmd.ExecuteNonQuery(); //執行不查詢
                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt訂購人.Clear();
            txt訂購品項.Text = "";
            combo訂購狀況.SelectedIndex = 0;
            txt內用桌號.Clear();
            txt訂單總價.Clear();
            chk購物袋.Checked = false;
            radio內用.Checked = true;            
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);  //若沒有轉換成功，會為0。

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();

                string strSQL = "delete from ordermanage where id =@DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                清空欄位();
                MessageBox.Show($"資料已刪除，{rows}筆資料受影響");
            }
        }

        private void dgv訂購單管理_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //RowIndex(橫向為同一筆)為資料筆，ColumnIndex(縱向)為欄位不能當資料筆 。
            {
                string strSelectID = dgv訂購單管理.Rows[e.RowIndex].Cells[0].Value.ToString();  //cell為儲存格。取得e事件的RowIndex為資料列的索引值，並取得cell儲存格索引值為0的值，就是ID，並儲存為字串。
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "select*from ordermanage where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    txt訂購人.Text = reader["訂購人"].ToString();
                    txt訂購品項.Text = reader["訂購品項"].ToString();
                    combo訂購狀況.Text = reader["訂單狀況"].ToString();
                    txt內用桌號.Text = reader["內用桌號"].ToString();
                    txt訂單總價.Text = reader["訂單總價"].ToString();
                    bool isbag = Convert.ToBoolean(reader["購物袋"]);
                    if (isbag == true)
                    {
                        chk購物袋.Checked = true;
                    }
                    else 
                    {
                        chk購物袋.Checked = false;
                    }
                    bool result = Convert.ToBoolean(reader["外帶"]);
                    if (result == true)
                    {
                        radio外帶.Checked = true;
                    }
                    else 
                    {
                        radio內用.Checked= false;
                    }


                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();


            }
        }

        private void radio內用_CheckedChanged(object sender, EventArgs e)
        {
            is外帶 = false;
        }

        private void radio外帶_CheckedChanged(object sender, EventArgs e)
        {
            is外帶 = true;

        }

        private void chk購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk購物袋.Checked)
            {
                購物袋 = true;
            }
            else 
            {
                購物袋 = false;
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生訂購資料列表();
        }
    }
}
