using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Global
    {
        //-----------------------------------------------------訂購單區-------------------------------------------------------

        public static bool 訂購人輸入完整=false;
        public static string 訂購人資訊 = "";
        public static List<string> list訂購甜點品項資料 = new List<string>();
        public static List<string> list訂購飲料品項資料 = new List<string>();

        public static List<string> list甜點Name = new List<string>();
        public static List<int> list甜點Price = new List<int>();
        public static List<int> list甜點Pid = new List<int>();

        public static List<string> list飲料Name = new List<string>();
        public static List<int> list飲料Price = new List<int>();
        public static List<int> list飲料Pid = new List<int>();

        public static string 內用桌號 = "外帶不用輸入";
        public static bool is外帶 = false;
        public static bool is購物袋 = false;
        //-----------------------------------------------------商品維護區-----------------------------------------------------------
        public static string image_dir甜點飲料 = @"D:\Users\azx87\Desktop\全端課程\期中專題圖片\甜點飲料";
        public static string strDBConnectionString = "";    //資料庫連線字串使用全域
        //public static int 權限 = 0;   //一般會員:10000以上，特殊會員:5000-9999，店員:1000-4999，店長:100-999，Sys:10-99。
        //-----------------------------------------------------------------------------------------------------------------------
        public static bool 員工登入成功 = false;
        public static bool 會員登入成功= false;
        public static string 登入者名稱 = "";
        public static string str登入身分 = "";

        public static string 會員姓名 = "";
        public static int 會員id = 0;
        public static int 會員點數 =0;
        public static int 會員新增點數 = 0;
        public static string 會員信箱 = "";

        public static string 員工姓名 = "";
        public static int 員工id = 0;
        public static string 員工信箱 = "";
        public static int 訂單總價 = 0;
        public static bool 切換使用者 = false;



    }
}
