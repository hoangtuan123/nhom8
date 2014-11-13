using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using WebForm.DonDHServiceReference;
using WebForm.CtDonDHServiceReference;
using WebForm.TonKhoServiceReference;
using WebForm.NguoiDungServiceReference;

namespace WebForm
{
    public partial class DatHang : System.Web.UI.Page
    {
        DonDHServiceClient DonDHClient = new DonDHServiceClient();
        CtDonDHServiceClient CtDonDHClient = new CtDonDHServiceClient();
        TonKhoServiceClient TonKhoClient = new TonKhoServiceClient();

        DonDH ddh = new DonDH();
        CtDonDH ct = new CtDonDH();
        WebForm.TonKhoServiceReference.TonKho tk = new WebForm.TonKhoServiceReference.TonKho();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                GioHang();
                ThongTinDonDH();
                Load_NguoiDung();
                Random rd = new Random();
                txtMa.Text = rd.Next(10000, 99999).ToString();
            }
        }
        // Hàm tự viết
        // Load thông tin người dùng
        public void Load_NguoiDung()
        {
            NguoiDungServiceClient nd = new NguoiDungServiceClient();
            if (Session["ID"]!=null) {
                DataSet data = nd.ThongTinNguoiDung_ID(int.Parse(Session["ID"].ToString()));
                txtHoTen.Text = data.Tables[0].Rows[0]["TenDangNhap"].ToString();
                txtHoTen.Text = data.Tables[0].Rows[0]["Ten"].ToString();
                txtDienThoai.Text = data.Tables[0].Rows[0]["SoDienThoai"].ToString();
                txtDiaChi.Text = data.Tables[0].Rows[0]["DiaChi"].ToString();
                txtEmail.Text = data.Tables[0].Rows[0]["Email"].ToString();
            }
        }
        // Hàm sử dụng lại có chỉnh sửa
        // Hiển thị giỏ hàng lên gird view để xử lý
        public void GioHang()
        {
            DataTable giohang = Session["GioHang"] as DataTable;
            gvGioHang.DataSource = giohang;
            gvGioHang.DataBind();
            gvGioHang.FooterRow.Cells[3].Text = "Tổng tiền";
            if (giohang.Rows.Count > 0)
            {
                decimal t = (decimal)giohang.Compute("Sum(ThanhTien)", "");
                gvGioHang.FooterRow.Cells[4].Text = t.ToString("#,###,###");
            }
            else
            {
                Response.Redirect("TrangChu.aspx");
                Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                lbsoluong.Text = "0";
            }
        }

        string thoigian = DateTime.Now.ToString("yyyyMMddhhmmss");
        // Hàm tự viết
        // Tạo ra mã đơn hàng ngày đặt và tình trạng
        public void ThongTinDonDH()
        {
            lbMaDonDH.Text = "DH" + thoigian;
            txtNgayDat.Text = DateTime.Now.ToShortDateString();
            lbTinhTrang.Text = "Chưa giao hàng";
        }
        // Hàm tự viết
        // Xử lý nút đặt hàng
        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            try
            {
                ddh.MaDonDH = lbMaDonDH.Text;
                ddh.HoTenKH = txtHoTen.Text;
                ddh.DiaChi = txtDiaChi.Text;
                ddh.DienThoai = txtDienThoai.Text;
                ddh.Email = txtEmail.Text;
                ddh.NgayDat = DateTime.Parse(txtNgayDat.Text);
                ddh.NgayGiao = DateTime.Parse(txtNgayGiao.Text);
                ddh.GhiChu = txtGhiChu.Text;
                ddh.TinhTrang = lbTinhTrang.Text;
                ddh.TongTien = 0;
                if (Session["ID"] != null)
                {
                    ddh.ID_NguoiDung = int.Parse(Session["ID"].ToString());
                }
                DonDHClient.Them(ddh);

                DataTable dt_Giohang = Session["GioHang"] as DataTable;

                ct.MaDonDH = lbMaDonDH.Text.Trim();
                foreach (DataRow mathang in dt_Giohang.Rows)
                {
                    ct.SP_ID = (int)mathang["SP_ID"];
                    ct.DonGiaDat = (float)mathang["DonGia"];
                    ct.SoLuongDat = (int)mathang["SoLuong"];
                    CtDonDHClient.Them(ct);

                    // cap nhat ton kho: giam so luong theo so luong dat
                    tk.SP_ID = (int)mathang["SP_ID"];
                    tk.ThoiGian = DateTime.Now;
                    tk.SoLuongTon = (int)mathang["SoLuong"];
                    TonKhoClient.Them_Xuat(tk);
                }
                ddh.TongTien = float.Parse(gvGioHang.FooterRow.Cells[4].Text);
                DonDHClient.SuaTongTien(ddh);

                Session.Remove("GioHang");
                Response.Redirect("DatHangThanhCong.aspx");
            }
            catch (Exception)
            {
                lbThongBaoLoi.Text = "Đặt hàng không thành công";
            }
        }
        // Hàm tự viết
        // Xử lý nút cancel trong girdview đặt hàng
        protected void gvGioHang_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvGioHang.EditIndex = -1;
            GioHang();
        }
        // Hàm tự viết
        // Xử lý nút xóa trong girdview đặt hàng
        protected void gvGioHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int sp_id = int.Parse(gvGioHang.DataKeys[e.RowIndex].Value.ToString());

            DataTable dt = Session["GioHang"] as DataTable;
            DataRow r = dt.Rows.Find(sp_id);
            r.Delete();

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

            gvGioHang.EditIndex = -1;
            GioHang();
        }
        // Hàm tự viết
        // Xử lý nút chỉnh sửa edit trong girdview đặt hàng
        protected void gvGioHang_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvGioHang.EditIndex = e.NewEditIndex;
            GioHang();
        }
        // Hàm tự viết
        // Xử lý nút cập nhật trong girdview đặt hàng
        protected void gvGioHang_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int sp_id = int.Parse(gvGioHang.DataKeys[e.RowIndex].Value.ToString());

            TextBox txtSoLuong = gvGioHang.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtSoLuong") as TextBox;

            int soluongton = TonKhoClient.SoLuongTonKho_SPID(sp_id);
            int soluongnhap = int.Parse(txtSoLuong.Text);

            if (soluongnhap <= soluongton)
            {
                DataTable dt = Session["GioHang"] as DataTable;
                DataRow r = dt.Rows.Find(sp_id);
                r["SoLuong"] = txtSoLuong.Text;

                //Cap nhat lbItemSelected tren MasterPage
                DataTable dt_Giohang = Session["GioHang"] as DataTable;
                if (dt_Giohang.Rows.Count > 0)
                {
                    Label lbsoluong = Page.Master.FindControl("lbSoLuong") as Label;
                    lbsoluong.Text = dt_Giohang.Compute("SUM(SoLuong)", "").ToString();
                }

                gvGioHang.EditIndex = -1;
                GioHang();
            }
            else
            {
                lbThongBaoTon.Text = "Sản phẩm còn lại " + soluongton + " sản phẩm. Số lượng nhập không vượt quá số lượng còn lại";
            }
        }
    }
}