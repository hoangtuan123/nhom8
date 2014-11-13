using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using WebForm.NguoiDungServiceReference;



namespace WebForm
{
    public partial class DangKy : System.Web.UI.Page
    {
        NguoiDungServiceClient nd_service = new NguoiDungServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Hàm tự viết
        // Đăng ký một người dùng mới
        protected void btnDangky_Click(object sender, EventArgs e)
            {
            if (Ten.Text == "" || TenDangNhap.Text == "" || MatKhau.Text == "" || MatKhau2.Text == "" || Email.Text == "" || DiaChi.Text == "" || SoDienThoai.Text == "")
            {
                lblLoi.Text = "Vui lòng nhập đủ thông tin các trường";
                return;
            }
            if (MatKhau.Text != MatKhau2.Text)
            {
                lblLoi.Text = "2 Mật khẩu không trùng nhau";
                return;
            }
            Boolean email=nd_service.IsEmail(Email.Text);
            Boolean tendangnhap=nd_service.IsTenDangNhap(TenDangNhap.Text);
            if (email == true)
            {
                lblLoi.Text = "Email đã tồn tại";
                return;
            }
            if (tendangnhap == true)
            {
                lblLoi.Text = "Tên đăng nhập đã tồn tại";
                return;
            }
            try
            {
                WebForm.NguoiDungServiceReference.NguoiDung ng = new WebForm.NguoiDungServiceReference.NguoiDung();
                ng.Ten = Ten.Text;
                ng.TenDangNhap = TenDangNhap.Text;
                ng.MatKhau = MatKhau.Text;
                ng.DiaChi = DiaChi.Text;
                ng.Email = Email.Text;
                ng.SoDienThoai = SoDienThoai.Text;


                
                nd_service.Them(ng);
                
                lblLoi.Text = "Đăng ký thành công";
                string sJavaScript = "<script language=javascript>\n";
                sJavaScript += "aler('Đăng ký thành công')";
                sJavaScript += "window.location = \"/TrangChu.aspx\";\n";
                sJavaScript += "</script>";
                Response.Write(sJavaScript);
            }
            catch {
                lblLoi.Text = "Đăng ký không thành công";
            }
        }
    }
}