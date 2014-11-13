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
    public partial class TrangChu : System.Web.UI.Page
    {
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        SanPham sp = new SanPham();    

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SanPhamFull();
                SanPhamMoi();
            }

            CollectionPager1.PageSize = 10;
            CollectionPager1.DataSource = SanPhamClient.HienThiSanPhamFull();
            CollectionPager1.BindToControl = dlSanPhamFull;
            dlSanPhamFull.DataSource = CollectionPager1.DataSourcePaged;
          
        }
        // Hàm sử dụng lại có chỉnh sửa
        // Hiển thị sản phẩm đầy đủ + phân trang
        public void SanPhamFull()
        {
            dlSanPhamFull.DataSource = SanPhamClient.HienThiSanPhamFull();
            dlSanPhamFull.DataBind();

            CollectionPager1.PageSize = 10;
            CollectionPager1.DataSource = SanPhamClient.HienThiSanPhamFull();
            CollectionPager1.BindToControl = dlSanPhamFull;
            dlSanPhamFull.DataSource = CollectionPager1.DataSourcePaged;
        }
        // Hàm tự viết
        // Hiển thị sản phẩm mới
        public void SanPhamMoi()
        {
            dlSanPhamMoi.DataSource = SanPhamClient.HienThiSanPhamMoi();
            dlSanPhamMoi.DataBind();
        }
        // Hàm sử dụng lại có chỉnh sửa
        // Xử lý nút xem chi tiết sản phẩm của danh sách sản phẩm mới
        protected void dlSanPhamMoi_ItemCommand(object source, DataListCommandEventArgs e)
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
        // Hàm sử dụng lại có chỉnh sửa
        // Xử lý nút xem chi tiết sản phẩm của danh sách sản phẩm đầy đủ
        protected void dlSanPhamFull_ItemCommand(object source, DataListCommandEventArgs e)
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