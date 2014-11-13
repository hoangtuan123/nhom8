using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.NhaSXServiceReference;

using WebForm.NguoiDungServiceReference;
namespace WebForm
{
    public partial class New_Master : System.Web.UI.MasterPage
    {
        NhaSXServiceClient NhaSXClient = new NhaSXServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Ten"] != null && Session["SoDienThoai"] != null)
            {
                lblTenDangNhap.Text = Session["TenDangNhap"].ToString();
                 
               
            }
         
            if (!IsPostBack)
            {
               
                Ds_NhaSX();

                DemTruyCap();

                // Gio Hang
                if (Session["GioHang"] != null)
                {
                    //Cap nhat lbItemSelected tren MasterPage
                    DataTable dt_Giohang = Session["GioHang"] as DataTable;
                    if (dt_Giohang.Rows.Count > 0)
                    {
                        Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                        lbsoluong.Text = dt_Giohang.Compute("SUM(SoLuong)", "").ToString();
                    }
                    else if (dt_Giohang.Rows.Count == 0)
                    {
                        Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                        lbsoluong.Text = "0";
                    }
                }
                else if (Session["GioHang"] == null)
                {
                    DataTable dt_giohang = new DataTable();
                    dt_giohang.Columns.Add("SP_ID", typeof(int));
                    dt_giohang.Columns.Add("TenSP", typeof(string));
                    dt_giohang.Columns.Add("DonGia", typeof(float));
                    dt_giohang.Columns.Add("SoLuong", typeof(int));
                    //dt_giohang.Columns.Add("TonKho", typeof(int));
                    dt_giohang.Columns["SoLuong"].DefaultValue = 1;
                    dt_giohang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong*DonGia");
                    dt_giohang.PrimaryKey = new DataColumn[] { dt_giohang.Columns[0] };
                    Session["GioHang"] = dt_giohang;
                    Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                    lbsoluong.Text = "0";
                }
            }
           
        }
        public void Ds_NhaSX()
        {
            dlDsNSX_1.DataSource = NhaSXClient.HienThiNhaSX();
            dlDsNSX_1.DataBind();
            //dlDsNSX.DataSource = NhaSXClient.HienThiNhaSX();
            //dlDsNSX.DataBind();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tensp = txtTenSP.Text;
            Response.Redirect("KetQuaTimKiem.aspx?TenSP=" + tensp);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dt_Giohang = Session["GioHang"] as DataTable;
            if (dt_Giohang.Rows.Count > 0)
            {
                Response.Redirect("DatHang.aspx");
            }
            else
            {
                lbThongBaoLoi.Text = "Giỏ hàng hiện chưa có sản phẩm";
                Response.Redirect(Request.RawUrl);
            }
        }
        public void DemTruyCap()
        {
            Session.Timeout = 1;
            lbTruyCap.Text = Application["SoLuotTruyCap"].ToString();
            lbOnline.Text = Application["SLOnline"].ToString();
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDungServiceClient nd_service = new NguoiDungServiceClient();
                DataSet ds = nd_service.ThongTinNguoiDung(txtTenDangNhap.Text, txtMatKhau.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    Session["ID"] = ds.Tables[0].Rows[0]["ID"].ToString();
                    Session["TenDangNhap"] = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
                    Session["Ten"] = ds.Tables[0].Rows[0]["Ten"].ToString();
                    Session["SoDienThoai"] = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
                    lblTenDangNhap.Text = Session["TenDangNhap"].ToString();
                 
                    string sJavaScript = "<script language=javascript>\n";
                    sJavaScript += "window.location = \"/TrangChu.aspx\";\n";
                    sJavaScript += "</script>";
                    Response.Write(sJavaScript);
                }
                else
                {
                    lblLoiDangNhap.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            catch {
                lblLoiDangNhap.Text = "Lỗi Vui lòng thử lại";
            }
            
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("TrangChu.aspx");
        }
    }
}