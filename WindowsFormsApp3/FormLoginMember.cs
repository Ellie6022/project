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
    public partial class FormLoginMember : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormLoginMember()
        {
            InitializeComponent();
        }

        private void FormLoginMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);

            scsb.DataSource = @".";
            scsb.InitialCatalog = "myproductdb";
            scsb.IntegratedSecurity = true;

            Global.strDBConnectionString = scsb.ConnectionString;
        }
        void 驗證登入資料()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "select id,姓名,電話,email from members;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read() == true)
            {
                Global.會員id = (int)reader["id"];
                string str帳號 = reader["email"].ToString();
                string str密碼 = reader["電話"].ToString();
                Global.登入者名稱 = reader["姓名"].ToString();
                if (txt帳號.Text == str帳號 && txt密碼.Text == str密碼)
                {

                    MessageBox.Show("登入成功!");
                    Global.會員登入成功 = true;
                    Close();
                    break;
                }
            }
            reader.Close();
            con.Close();
            if (Global.會員登入成功 == false)
            {
                MessageBox.Show("登入失敗，請檢查帳號密碼是否正確");
                清空欄位();
            }

        }
        void 清空欄位()
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            驗證登入資料();
        }

        private void FormLoginMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.會員登入成功 == true)
            {
                e.Cancel = false;
            }
            else if(Global.會員登入成功 == false)
            {
                e.Cancel =true;
                MessageBox.Show("請先登入");

            }
        }
    }
}
