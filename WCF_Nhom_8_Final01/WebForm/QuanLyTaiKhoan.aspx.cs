using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.NguoiDungServiceReference;

namespace WebForm
{
    public partial class QuanLyTaiKhoan : System.Web.UI.Page
    {
        NguoiDungServiceClient nd = new NguoiDungServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load();
            }
        }
        // Hàm tự viết
        // lấy thông tin của người dùng load lên form quản lý người dùng
        private void Load() {
            if (Session["ID"] != null)
            {
                DataSet data = nd.ThongTinNguoiDung_ID(int.Parse(Session["ID"].ToString()));
                lblTenDangNhap.Text = data.Tables[0].Rows[0]["TenDangNhap"].ToString();
                txtHoTen.Text = data.Tables[0].Rows[0]["Ten"].ToString();
                txtSoDienThoai.Text = data.Tables[0].Rows[0]["SoDienThoai"].ToString();
                txtDiaChi.Text = data.Tables[0].Rows[0]["DiaChi"].ToString();
                txtEmail.Text = data.Tables[0].Rows[0]["Email"].ToString();
            }
            else
            {
                Response.Redirect("TrangChu.aspx");
            }
        }
        // Hàm tự viết
        // Cập nhật lại thông tin người dùng nếu người dùng muốn thay đổi thông tin
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text!=null && txtSoDienThoai!=null && txtDiaChi!=null && txtEmail!=null)
            {
                WebForm.NguoiDungServiceReference.NguoiDung nguoidung = new WebForm.NguoiDungServiceReference.NguoiDung();
                int id = int.Parse(Session["ID"].ToString());
                nguoidung.ID = id;
                nguoidung.Ten = txtHoTen.Text;
                nguoidung.SoDienThoai = txtSoDienThoai.Text;
                nguoidung.Email = txtEmail.Text;
                nguoidung.DiaChi = txtDiaChi.Text;
                //ShowMessageBox();

                Boolean flag = nd.CapNhatThongTin(nguoidung,int.Parse(Session["ID"].ToString()));
                if (flag == true)
                {
                    lblLoi.Text = "Cập nhật thành công";
                }
                else
                {
                    lblLoi.Text = "Có lỗi vui Lòng thử lại";
                }
                
                
            }
            else
            {
                lblLoi.Text = "Vui lòng nhập đủ các thông tin trước khi cập nhật";
            }

        }
        // Hàm sử dụng lại có chỉnh sửa
        // xuất ra javascript hỏi khách hàng có muốn cập nhật lại tài khoản không
        private void ShowMessageBox()
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "var agree;\n";
            sJavaScript += "agree = confirm('Bạn có muốn cập nhật lại thông tin tài khoản không?.');\n";
            sJavaScript += "if(agree)\n";
            sJavaScript += "window.location = \"/QuanLyTaiKhoan.aspx\";\n";
            sJavaScript += "</script>";
            Response.Write(sJavaScript);
        }  
    }
}