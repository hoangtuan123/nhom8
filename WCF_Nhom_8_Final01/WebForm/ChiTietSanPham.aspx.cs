using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using WebForm.SanPhamServiceReference;

namespace WebForm
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        WebForm.SanPhamServiceReference.SanPham sp = new WebForm.SanPhamServiceReference.SanPham();
        //Hàm tự viết
        //Load các thông tin khi trang chạy
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int sp_id = int.Parse(Request.QueryString["SP_ID"]);
                int nsx_id = int.Parse(Request.QueryString["NhaSX_ID"]);

                ChiTiet(sp_id);
                SanPhamCungLoai(nsx_id,sp_id);

                Label soluongton = dlChiTietSP.Controls[0].FindControl("label3") as Label;
                Label thongbao = dlChiTietSP.Controls[0].FindControl("lbThongBao") as Label;
                ImageButton dathang = dlChiTietSP.Controls[0].FindControl("ImageButton2") as ImageButton;
                if (soluongton.Text == "0")
                {
                    dathang.Visible = false;
                    thongbao.Text = "Sản phẩm đã hết, quý khách vui lòng quay lại sau. Xin cám ơn";
                }
            }
        }
        //Hàm tự viết
        //Chi tiết sản phẩm
        public void ChiTiet(int sp_id)
        {
            sp.SP_ID = sp_id;
            dlChiTietSP.DataSource = SanPhamClient.ChiTietSanPham(sp);
            dlChiTietSP.DataBind();

            DataTable dt_Giohang = Session["GioHang"] as DataTable;
            if (dt_Giohang.Rows.Count > 0)
            {
                Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                lbsoluong.Text = dt_Giohang.Compute("SUM(SoLuong)", "").ToString();
            }
        }
        //Hàm tự viết
        //Sản phẩm cùng loại
        public void SanPhamCungLoai(int nsx_id,int sp_id)
        {
            sp.NhaSX_ID = nsx_id;
            sp.SP_ID = sp_id;
            dlSanPhamCungLoai.DataSource = SanPhamClient.HienThiSanPhamCungLoai(sp);
            dlSanPhamCungLoai.DataBind();

            CollectionPager1.PageSize = 5;
            CollectionPager1.DataSource = SanPhamClient.HienThiSanPhamCungLoai(sp);
            CollectionPager1.BindToControl = dlSanPhamCungLoai;
            dlSanPhamCungLoai.DataSource = CollectionPager1.DataSourcePaged;
        }
        
        protected void dlChiTietSP_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("ThemGioHang"))
            {
                Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                Label lbLoi = Page.Master.FindControl("lbThongBaoLoi") as Label;

                string data = e.CommandArgument.ToString();
                string[] danhsachThamSo = data.Split(';');
                string SP_ID = danhsachThamSo[0];
                string TenSP = danhsachThamSo[1];
                float DonGia = float.Parse(danhsachThamSo[2]);
                //int TonKho = int.Parse(danhsachThamSo[3]);

                DataTable dt_Giohang = Session["GioHang"] as DataTable;

                DataRow r_MatHang = dt_Giohang.Rows.Find(SP_ID);
                if (r_MatHang == null)
                {
                    dt_Giohang.Rows.Add(SP_ID, TenSP, DonGia);
                }
                else
                {
                    if ((int)r_MatHang["SoLuong"] < 3)
                    {
                        r_MatHang["SoLuong"] = (int)r_MatHang["SoLuong"] + 1;
                    }
                    else
                    {
                        lbLoi.Text = "Số sản phẩm chọn không vượt quá 3";
                    }
                }
                lbsoluong.Text = dt_Giohang.Compute("SUM(SoLuong)", "").ToString();
                Response.Redirect(Request.RawUrl);
            }
            if (e.CommandName.Equals("TiepTucMuaHang"))
            {
                Response.Redirect("TrangChu.aspx");
            }
        }
        //Hàm tự viết
        //Xem chi tiết sản phẩm cùng loại
        protected void dlSanPhamCungLoai_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("XemChiTiet"))
            {
                string data = e.CommandArgument.ToString();
                string[] danhsachThamSo = data.Split(';');
                int SP_ID = int.Parse(danhsachThamSo[0]);
                int NhaSX_ID = int.Parse(danhsachThamSo[1]);

                Response.Redirect("ChiTietSanPham.aspx?SP_ID=" + SP_ID + "&NhaSX_ID=" + NhaSX_ID);
            }
        }
    }
}