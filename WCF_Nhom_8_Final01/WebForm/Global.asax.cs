using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.Data;
using System.Data.SqlClient;

namespace WebForm
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Application.Lock();

            //Kiểm tra xem có file Dem.txt
            //Nếu chưa có, tạo file
            if (!System.IO.File.Exists(Server.MapPath("Dem.txt")))
                System.IO.File.WriteAllText(Server.MapPath("Dem.txt"), "0");

            //Nếu đã có file Dem.txt, đọc số liệu người truy cập
            Application["SoLuotTruyCap"] = int.Parse(System.IO.File.ReadAllText(Server.MapPath("Dem.txt")));

            Application.UnLock();   
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // 1. Khai bao va tao gio hang
            DataTable dt_giohang = new DataTable();
            dt_giohang.Columns.Add("SP_ID", typeof(int));
            dt_giohang.Columns.Add("TenSP", typeof(string));
            dt_giohang.Columns.Add("DonGia", typeof(float));
            dt_giohang.Columns.Add("SoLuong", typeof(int));
            //dt_giohang.Columns.Add("TonKho", typeof(int));
            dt_giohang.Columns["SoLuong"].DefaultValue = 1;
            dt_giohang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong*DonGia");

            //2. Dat Khoa chinh cho gio hang
            dt_giohang.PrimaryKey = new DataColumn[] { dt_giohang.Columns[0] };

            //3. Tao session de luu du lieu
            Session["GioHang"] = dt_giohang;

            // Dem so luong truy cap
            //Tăng số lượt truy cập lên 1
            Application["SoLuotTruyCap"] = (int)Application["SoLuotTruyCap"] + 1;
            //Ghi xuống file
            System.IO.File.WriteAllText(Server.MapPath("Dem.txt"), Application["SoLuotTruyCap"].ToString());

            //Xử lý số người online
            //Nếu chưa có thì gán là 1, có rồi thì tăng 1
            if (Application["SLOnline"] == null)//chưa có
                Application["SLOnline"] = 1;
            else
                Application["SLOnline"] = (int)Application["SLOnline"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["SLOnline"] = (int)Application["SLOnline"] - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}