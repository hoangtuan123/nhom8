using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Thoat : System.Web.UI.Page
    {
        //Hàm tự viết
        //Xóa session chuyển về trang chủ
        protected void Page_Load(object sender, EventArgs e)
        {
       
                Session["ID"] = null;
                Session["TenDangNhap"] = null;
                Session["Ten"] = null;
                Session["SoDienThoai"] = null;
      
            Response.Redirect("TrangChu.aspx");
        }
    }
}