using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebForm.SanPhamServiceReference;

namespace WebForm
{
    public partial class KetQuaTimKiem : System.Web.UI.Page
    {
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        WebForm.SanPhamServiceReference.SanPham sp = new WebForm.SanPhamServiceReference.SanPham();

        //Hàm tự viết
        //Hiển thị khi load trang
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string tensp = Request.QueryString["TenSP"];
                if (tensp != null)
                {
                    KetQua(tensp, 0, 0, 0);
                }
                else
                {
                    int nhasxid = int.Parse(Request.QueryString["NhaSX_ID"]);
                    decimal dongiatu = decimal.Parse(Request.QueryString["DonGiaTu"]);
                    decimal dongiaden = decimal.Parse(Request.QueryString["DonGiaDen"]);
                    KetQua("", nhasxid, dongiatu, dongiaden);
                }
            }
        }
        //Hàm tự viết
        //Kết quả tìm kiếm
        public void KetQua(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden)
        {
            List<WebForm.SanPhamServiceReference.SanPham> kq = SanPhamClient.TimKiemSanPham(tensp, nhasxid, dongiatu, dongiaden).ToList();

            if (kq.Count > 0)
            {
                dlKetQua.DataSource = SanPhamClient.TimKiemSanPham(tensp, nhasxid, dongiatu, dongiaden);
                dlKetQua.DataBind();

                CollectionPager1.PageSize = 5;
                CollectionPager1.DataSource = SanPhamClient.TimKiemSanPham(tensp, nhasxid, dongiatu, dongiaden);
                CollectionPager1.BindToControl = dlKetQua;
                dlKetQua.DataSource = CollectionPager1.DataSourcePaged;
            }
            else
            {
                lbThongBaoLoi.Text = "Không có sản phẩm cần tìm";
            }
        }
        //Hàm tự viết
        //Xem chi tiết sản phẩm tìm được
        protected void dlKetQua_ItemCommand(object source, DataListCommandEventArgs e)
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