using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btn會員點數.Visible = false;
            btn訂購單.Visible = false;
            btn商品管理.Visible = false;
            btn訂單管理.Visible = false;
            btn會員資料管理.Visible = false;
            btn系統管理.Visible = false;
            if (Global.訂購人輸入完整 == true)
            {
                lbl登入者名稱.Visible = true;
            }
            else 
            {
                lbl登入者名稱.Visible = false;
            }
            btn切換使用者.Visible = false;
        }

        private void btn訂購單_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();  
            myForm1.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            FormOrderManage formordermanage = new FormOrderManage();
            formordermanage.ShowDialog();
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember();
            formMember.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            FormMaintain myForm = new FormMaintain();
            myForm.ShowDialog();
        }

        private void btn系統管理_Click(object sender, EventArgs e)
        {
            FormSystem formSystem = new FormSystem();
            formSystem.ShowDialog();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {//多的
         
        }
        void 登入後調整按鈕() 
        {
            btn切換使用者.Visible = true;
            btn員工登入.Visible = false;
            btn會員登入.Visible = false;
            btn訪客.Visible = false;
        }


        private void btn員工登入_Click(object sender, EventArgs e)
        {
            FormLogin myFormLogin = new FormLogin();
            myFormLogin.ShowDialog();
            if (Global.員工登入成功 ==true) 
            {
                lbl登入者名稱.Text = $"{Global.登入者名稱}，您好 ! ";
                MessageBox.Show("歡迎光臨! 使用身分：員工");
                登入後調整按鈕();

                btn會員點數.Visible = true;
                btn訂購單.Visible = true;
                btn商品管理.Visible = true;
                btn訂單管理.Visible = true;
                btn會員資料管理.Visible = true;
                btn系統管理.Visible = true;
                lbl登入者名稱.Visible = true;
                Global.str登入身分 = "員工";
            }

        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            FormLoginMember myFormLoginMember = new FormLoginMember();
            myFormLoginMember.ShowDialog();
            if (Global.會員登入成功 == true)
            {
                lbl登入者名稱.Text = $"{Global.登入者名稱}，您好 ! ";
                MessageBox.Show("歡迎光臨! 使用身分：會員");
                登入後調整按鈕();
                btn會員點數.Visible = true;
                btn訂購單.Visible = true;
                btn商品管理.Visible = true;
                btn訂單管理.Visible = false;
                btn會員資料管理.Visible = false;
                btn系統管理.Visible = false;
                lbl登入者名稱.Visible = true;
                Global.str登入身分 = "會員";
            }
        }

        private void btn訪客_Click(object sender, EventArgs e)
        {
            MessageBox.Show("歡迎光臨! 使用身分：訪客");
            登入後調整按鈕();
            btn訂購單.Visible = true;
            btn商品管理.Visible = true;
            btn會員點數.Visible = false;
            btn訂單管理.Visible = false;
            btn會員資料管理.Visible = false;
            btn系統管理.Visible = false;
            Global.str登入身分 = "訪客";

        }

        private void btn登出_Click(object sender, EventArgs e)
        {   //多的

        }

        private void btn切換使用者_Click(object sender, EventArgs e)
        {

            btn員工登入.Visible = true;
            btn會員登入.Visible = true;
            btn訪客.Visible = true;
            btn會員點數.Visible = false;
            btn切換使用者.Visible = false;
            lbl登入者名稱.Visible = false;
            btn訂購單.Visible = false;
            btn商品管理.Visible = false;
            btn訂單管理.Visible = false;
            btn會員資料管理.Visible = false;
            btn系統管理.Visible = false;
        }

        private void btn會員點數_Click(object sender, EventArgs e)
        {
            FormPoint formPoint = new FormPoint();
            formPoint.ShowDialog();
        }
    }
}
