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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;


namespace WindowsFormsApp3
{
    public partial class FormDetail : Form
    {
        public int selectID = 0;  //這裡設定成public，是為了來進到欄位裡面。  
        string image_modify_name = "";
        bool is修改圖檔 = false;
        //string 所選類別 = "";
        List<string> list類別= new List<string>();

        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            list類別.Add("甜點");
            list類別.Add("飲料");
            comboBox類別.Items.Add("甜點");
            comboBox類別.Items.Add("飲料");
            comboBox類別.SelectedIndex = 0;
            //所選類別 = list類別[comboBox類別.SelectedIndex];

            lblID.Text = selectID.ToString();
            顯示商品項目();

            if (selectID > 0)
            {
                btn刪除商品.Visible = true;
            }
            else 
            {
                btn刪除商品.Visible = false;
            }

            if (Global.str登入身分 == "會員" || Global.str登入身分 == "訪客") 
            {
                comboBox類別.DropDownStyle = ComboBoxStyle.DropDownList;
                txt商品名稱.ReadOnly = true;
                txt商品價格.ReadOnly= true;
                txt商品描述.ReadOnly = true;
                btn儲存變更.Visible= false;
                btn刪除商品.Visible = false;
                btn取消.Visible=false;
                btn移除圖片.Visible = false;
                btn選取圖片.Visible = false;
                btn清空欄位.Visible = false;
            }
        }
        void 顯示商品項目()
        {
            if (selectID > 0) //代表有指定 
            {
                SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                con.Open();
                string strSQL = "select*from dessertshop where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    comboBox類別.Text = reader["catalog"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt商品價格.Text = reader["price"].ToString();
                    txt商品描述.Text = reader["pdesc"].ToString();
                    image_modify_name = reader["pimage"].ToString();
                    string 圖檔完整路徑 = Global.image_dir甜點飲料 + @"\" + image_modify_name;  //  " \\"可以改成@" \"。
                    pictureBox商品圖檔.Image = Image.FromFile(圖檔完整路徑);  // pictureBox在UI屬性SizeMode，可以調整成Zoom。

                }
                reader.Close();
                con.Close();
            }
        }



        private void btn選取圖片_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }
        void 選取商品圖片()
        {
            OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "檔案類型(*.jpg,*.jpeg,*.png) | *.jpeg; *.jpg; *.png ";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);    //FileName為完整路徑
                string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName); //SafeFileName為檔案名稱
                Random myRnd = new Random();
                //image_modify_name =myRnd.Next(1000, 10000).ToString() + 檔案副檔名;
                image_modify_name = DateTime.Now.ToString("yymmddHHmmss") + myRnd.Next(1000, 10000).ToString() + 檔案副檔名;
                is修改圖檔 = true;  //選取商品圖片代表要修改圖檔
                Console.WriteLine(image_modify_name); //image_name要改成類別變數image_modify_name

            }
        }

        private void btn移除圖片_Click(object sender, EventArgs e)
        {
            pictureBox商品圖檔.Image = null;

        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("確定要取消變更嗎?", "標題", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result== DialogResult.OK) 
            {
                Close();
            }
        }

        private void btn儲存變更_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (comboBox類別.Text != "") && (pictureBox商品圖檔.Image != null))   //null代表沒有物件 
            {
                if (is修改圖檔 == true)
                {

                    string filename = Path.Combine(Global.image_dir甜點飲料, image_modify_name);
                    using (var ms = new MemoryStream())
                    {
                        pictureBox商品圖檔.Image.Save(ms, pictureBox商品圖檔.Image.RawFormat);
                        using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                        {
                            ms.WriteTo(fs);
                        }
                    }
                    //pictureBox商品圖檔.Image.Save(Global.image_dir甜點飲料 + @" \" + image_modify_name);// pictureBox有Save儲存功能
                    is修改圖檔 = false;

                }
                if (selectID > 0)
                {
                    SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                    con.Open();
                    string strSQL = "Update dessertshop set catalog=@NewCatalog, pname=@NewName,price=@NewPrice,pdesc=@NewDesc,pimage=@NewImage where id=@SearchId";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchId", selectID);
                    cmd.Parameters.AddWithValue("@NewCatalog", comboBox類別.Text);
                    cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                    int intPrice = 0;
                    Int32.TryParse(txt商品價格.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                    cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"資料異動成功，影響{rows}筆資料!");
                }
                else 
                {
                    SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                    con.Open();
                    string strSQL = "insert into dessertshop values(@NewCatalog,@NewName,@NewPrice,@NewDesc,@NewImage);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewCatalog", comboBox類別.Text);
                    cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                    int intPrice = 0;
                    Int32.TryParse(txt商品價格.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                    cmd.Parameters.AddWithValue("@NewImage", image_modify_name);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"資料新增成功，影響{rows}筆資料!");

                }
                Close();
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            

            
            if (selectID > 0)
            {
                DialogResult result = MessageBox.Show("確定要刪除此商品嗎?", "刪除商品", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(Global.strDBConnectionString);
                    con.Open();

                    string strSQL = "delete from dessertshop where id =@DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", selectID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show($"資料已刪除，{rows}筆資料受影響");
                    Close();
                }
            }            
            else
            {
                MessageBox.Show("請選取要刪除的商品!");
            }

        }
    }
}
