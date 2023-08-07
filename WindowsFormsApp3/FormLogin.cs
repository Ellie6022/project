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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp3
{
    public partial class FormLogin : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);

            scsb.DataSource = @".";
            scsb.InitialCatalog = "myproductdb";
            scsb.IntegratedSecurity = true;

            Global.strDBConnectionString = scsb.ConnectionString;
            //驗證登入資料();
        }
        void 驗證登入資料()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "select id,姓名,電話,信箱 from staff;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                Global.員工id = (int)reader["id"];
                string str帳號 = reader["信箱"].ToString();
                string str密碼 = reader["電話"].ToString();
                Global.登入者名稱 = reader["姓名"].ToString() ;
                if (txt帳號.Text == str帳號 && txt密碼.Text == str密碼)
                {
                    MessageBox.Show("登入成功!");
                    Global.員工登入成功 = true;
                    Close();
                    break;
                }  
            }         
            reader.Close();
            con.Close();
            if (Global.員工登入成功 ==false)
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

        private void btn登入_Click(object sender, EventArgs e)
        {
            驗證登入資料();
        }

        private void radio會員_CheckedChanged(object sender, EventArgs e)
        {   //多的

        }

        private void radio員工_CheckedChanged(object sender, EventArgs e)
        {   //多的

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.員工登入成功 == true)
            {
                e.Cancel = false;
            }
            else if(Global.員工登入成功 == false)
            {
                e.Cancel = true;
                MessageBox.Show("請先登入");
            }
        }
    }
}
