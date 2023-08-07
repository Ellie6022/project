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
    public partial class FormMember : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();  
        List<int> searchIDs = new List<int>();  //進階搜尋結果，要用來存ID資料。
        int int搜尋婚姻狀態 = 0;  //0代表全部，1代表已婚，2代表單身。
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";  
            scsb.InitialCatalog = "myproductdb";   
            scsb.IntegratedSecurity = true;    

            Global.strDBConnectionString = scsb.ConnectionString;

            combo資料欄位.Items.Add("姓名");
            combo資料欄位.Items.Add("電話");
            combo資料欄位.Items.Add("地址");
            combo資料欄位.Items.Add("email");
            combo資料欄位.SelectedIndex = 0;

            radio全部.Checked = true;
            int搜尋婚姻狀態 = 0;
            產生會員資料列表();
        }
        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();           
            string strSQL = "select id as 序號,電話,姓名,地址,email as 電子郵件,生日,婚姻狀態,點數 from members;";   //id一定要放在第一個位置，其餘順序可以變動，因為下面要存取Cells[0]的值，就是要取得id的值。

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)//HasRows代表有無資料，為Boolean值
            {
                DataTable dt = new DataTable(); // DataTable類似hashtable，可以建立不同欄位和值，也可以一筆一筆建立資料，像是dt.Add("內容")。
                dt.Load(reader);    //載入reader到dt(DataTable)。
                dgv會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位搜尋關鍵字.Text != "")
            {
                listBox搜尋結果.Items.Clear();
                searchIDs.Clear();
                string str欄位名稱 = combo資料欄位.SelectedItem.ToString();
                string sql婚姻狀態查詢語法 = "";

                if (int搜尋婚姻狀態 == 0)
                {//全部
                    sql婚姻狀態查詢語法 = "";
                }
                else if (int搜尋婚姻狀態 == 1)
                {//已婚
                    sql婚姻狀態查詢語法 = "and 婚姻狀態=1";
                }
                else if (int搜尋婚姻狀態 == 2)
                {//單身
                    sql婚姻狀態查詢語法 = "and 婚姻狀態=0";
                }

                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = $"select * from members where 生日>=@BirthdayStart and  生日<=@BirthdayEnd  and {str欄位名稱} like @SearchKeyWord {sql婚姻狀態查詢語法};";  
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@BirthdayStart", dtp起始時間.Value);
                cmd.Parameters.AddWithValue("@BirthdayEnd", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyWord", $"%{txt欄位搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["id"]);  
                    listBox搜尋結果.Items.Add($"{reader["id"]}{reader["權限"]}{reader["姓名"]}{reader["電話"]}");  
                    count += 1;
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();

            }
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }
        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            //也可以將所有欄位設定為使用者必須輸入。
            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "update members set 權限=@NewPermission,姓名=@NewName,電話=@NewPhone ,地址=@NewAddress ,email=@NewEmail,生日=@NewBirthday,婚姻狀態=@NewMarriage,點數=@NewPoints where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewPermission", "會員");
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int intPoints = 0;
                Int32.TryParse(txt點數.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int rows = cmd.ExecuteNonQuery(); //執行不查詢
                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "insert into members values (@NewPermission,@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage,@NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPermission", "會員");
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int intPoints = 0;
                Int32.TryParse(txt點數.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int rows = cmd.ExecuteNonQuery(); 
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");

            }
            else
            {
                MessageBox.Show("姓名電話必填!!");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);  //若沒有轉換成功，會為0。

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                
                string strSQL = "delete from members where id =@DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                清空欄位();
                MessageBox.Show($"資料已刪除，{rows}筆資料受影響");
            }
        }

        private void dgv會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //RowIndex(橫向為同一筆)為資料筆，ColumnIndex(縱向)為欄位不能當資料筆 。
            {
                string strSelectID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();  //cell為儲存格。取得e事件的RowIndex為資料列的索引值，並取得cell儲存格索引值為0的值，就是ID，並儲存為字串。
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "select*from members where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
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

        private void radio全部_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 0;
        }

        private void radio單身_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 2;
        }

        private void radio已婚_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 1;
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生會員資料列表(); 
        }
    }
}
