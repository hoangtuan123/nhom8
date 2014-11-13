using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebForm.NguoiDungServiceReference;

namespace WebForm
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        NguoiDungServiceClient nd = new NguoiDungServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                Response.Redirect("TrangChu.aspx");
            }
        }
        // Hàm tự viết
        // Cập nhật lại mật khẩu
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMK_Cu.Text == "" || txtMK_Moi.Text == "" || txtMK_Moi_1.Text == "")
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ thông tin";
                return;
            }
            else if (txtMK_Moi.Text != txtMK_Moi_1.Text)
            {
                lblLoi.Text = "Mật khẩu mới và mật khẩu mới nhập lại không trùng nhau";
                return;
            }
            else
            {
                if (nd.KT_MatKhau(txtMK_Cu.Text, int.Parse(Session["ID"].ToString())) == true)
                {
                    Boolean bit=nd.DoiMatKhau(txtMK_Moi.Text,int.Parse(Session["ID"].ToString()));
                    if (bit == true)
                    {
                        lblLoi.Text = "Đổi Mật Khẩu Thành Công";
                    }
                    else
                    {
                        lblLoi.Text = "Đổi mật khẩu thất bại";
                    }
                    
                }
            }
        }
    }
}