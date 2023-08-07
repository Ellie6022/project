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

    public partial class FormSystem : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string 請假日期 = "";
        int 請假時數 = 0;
        DateTime selectedDate = DateTime.Now;

        public FormSystem()
        {
            InitializeComponent();
        }

        private void FormSystem_Load(object sender, EventArgs e)
        {
            btn確認送出.Enabled = false;
            讀取員工姓名();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myproductdb";
            scsb.IntegratedSecurity = true;
            Global.strDBConnectionString = scsb.ConnectionString;

            combo部門.Items.Add("飲料部");
            combo部門.Items.Add("甜點部");
            combo部門.Items.Add("送餐部");
            combo部門.Items.Add("櫃台部");
            combo部門.Items.Add("主管");
            combo部門.SelectedIndex = 0;
            
            dtp起始時間.Value = DateTime.Now;
            dtp結束時間.Value = DateTime.Now;
            DateTime selectedDate = dtp起始時間.Value;
            請假日期 = selectedDate.ToString("d");
            //請假時間長度();
            產生請假資料列表();

        }
        void 讀取員工姓名()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "select*from staff where id =@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", Global.員工id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                txt員工姓名.Text = reader["姓名"].ToString();
                combo部門.Text = reader["部門"].ToString();
            }
            reader.Close();
            con.Close();
        }
        void 產生請假資料列表()
        {
            SqlConnection con = new SqlConnection(Global.strDBConnectionString);
            con.Open();
            string strSQL = "select id as 序號,員工姓名,部門,請假時數,請假時間,假別,請假事由 from leave;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@NewEmail", Global.員工信箱);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable(); 
                dt.Load(reader); 
                dgv請假紀錄.DataSource = dt;
            }
            reader.Close();
            con.Close();

        }



    void 請假時間長度() 
        {
            DateTime start = dtp起始時間.Value;
            DateTime end = dtp結束時間.Value;
            TimeSpan duration = end.Subtract(start);

            Double hours = duration.TotalHours;
            lbl請假時數.Text ="總共請假時數： "+ (int)hours+" 小時";
            if ((int)hours > 0)
            {
                btn確認送出.Enabled = true;
                請假時數 = (int)hours;     
                //lbl請假時數.Text =$"總共請假時數： {請假時數} 小時";
            }
            else 
            {
                btn確認送出.Enabled = false;
                MessageBox.Show("請重新輸入時間");
            }

        }

        private void dtp起始時間_ValueChanged(object sender, EventArgs e)
        {
            請假時間長度();
            dtp起始時間.Value = DateTime.Now;

            DateTime selectedDate = dtp起始時間.Value;
            請假日期 = selectedDate.ToString("d");
        }

        private void dtp結束時間_ValueChanged(object sender, EventArgs e)
        {
            dtp結束時間.Value = DateTime.Now;
            請假時間長度();

        }

        private void btn確認送出_Click(object sender, EventArgs e)
        {   //多的
          
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生請假資料列表();
        }

        private void btn轉換時數_Click(object sender, EventArgs e)
        {
            請假時間長度();
        }

        private void btn確認送出_Click_1(object sender, EventArgs e)
        {
            if ((txt員工姓名.Text != "") && (txt請假事由.Text != ""))
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "insert into leave values (@NewStaff,@Newdepartment,@NewHours,@NewDate,@NewLeave,@NewReason);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewStaff", txt員工姓名.Text);
                cmd.Parameters.AddWithValue("@Newdepartment", combo部門.SelectedItem);
                cmd.Parameters.AddWithValue("@NewDate", 請假日期);
                cmd.Parameters.AddWithValue("@NewHours", 請假時數);
                if (radio事假.Checked)
                {
                    cmd.Parameters.AddWithValue("@NewLeave", "事假");
                }
                else if (radio病假.Checked)
                {
                    cmd.Parameters.AddWithValue("@NewLeave", "病假");
                }
                else if (radio公假.Checked)
                {
                    cmd.Parameters.AddWithValue("@NewLeave", "公假");
                }
                cmd.Parameters.AddWithValue("@NewReason", txt請假事由.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("姓名及事由必填!!");
            }
            產生請假資料列表();
        }

        private void txt員工姓名_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtp結束時間_Enter(object sender, EventArgs e)
        {
        }

        private void dtp結束時間_Leave(object sender, EventArgs e)
        {
        }
    }
}
