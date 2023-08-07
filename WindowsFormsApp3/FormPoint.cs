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
    public partial class FormPoint : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormPoint()
        {
            InitializeComponent();
        }

        private void FormPoint_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";  //伺服器名稱; . 代表本機。
            scsb.InitialCatalog = "myproductdb";   //資料庫名稱
            scsb.IntegratedSecurity = true;     //Windows驗證
            Global.strDBConnectionString = scsb.ConnectionString;
            讀取會員點數資料();
        }
        void 讀取會員點數資料() 
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();

            if (Global.str登入身分 == "員工")
            {
                string strSQL = "select id as 序號,會員姓名,會員信箱,時間,新增點數,累積點數 from MemberPoints;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)//HasRows代表有無資料，為Boolean值
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);    //載入reader到dt(DataTable)。
                    dgv會員點數.DataSource = dt;
                }
                reader.Close();
            }
            else if (Global.str登入身分 == "會員")
            {
                string strSQL = "select id as 序號,會員姓名,會員信箱,時間,新增點數,累積點數 from MemberPoints where 會員信箱=@NewEmail;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewEmail", Global.會員信箱);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)//HasRows代表有無資料，為Boolean值
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);    //載入reader到dt(DataTable)。
                    dgv會員點數.DataSource = dt;
                }
                reader.Close();
            }
            con.Close();
        }
        void 清空欄位() 
        {
            txt會員姓名.Clear();
            txt累積點數.Clear();
        
        }

        private void dgv會員點數_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string strSelectID = dgv會員點數.Rows[e.RowIndex].Cells[0].Value.ToString();  //cell為儲存格。取得e事件的RowIndex為資料列的索引值，並取得cell儲存格索引值為0的值，就是ID，並儲存為字串。
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "select*from MemberPoints where id =@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txt會員姓名.Text = reader["會員姓名"].ToString();
                    txt會員信箱.Text = reader["會員信箱"].ToString();
                    dtp購物時間.Value = DateTime.Parse(reader["時間"].ToString());
                    txt新增點數.Text = reader["新增點數"].ToString();
                    txt累積點數.Text = reader["累積點數"].ToString();
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

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            讀取會員點數資料();

        }
    }
}
