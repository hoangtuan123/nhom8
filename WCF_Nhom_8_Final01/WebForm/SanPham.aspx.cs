using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebForm.SanPhamServiceReference;

namespace WebForm
{
    public partial class SanPham : System.Web.UI.Page
    {
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        WebForm.SanPhamServiceReference.SanPham sp = new WebForm.SanPhamServiceReference.SanPham();

        //Hàm tự viết
        //Hiển thị danh sách sản phẩm khi load trang
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nhasxid = Request.QueryString["NhaSX_ID"];
                if (nhasxid !=null)
                {
                    Ds_SanPham(int.Parse(nhasxid));
                }
                else
                {
                    Ds_SanPham();
                }
            }
        }
        //Hàm tự viết
        //Đổ danh sách sản phẩm datalist theo nhà sản xuất
        public void Ds_SanPham(int nhasxid)
        {
                sp.NhaSX_ID = nhasxid;
                dlSanPham.DataSource = SanPhamClient.HienThiSanPhamNhaSX(sp);
                dlSanPham.DataBind();

                CollectionPager1.PageSize = 10;
                CollectionPager1.DataSource = SanPhamClient.HienThiSanPhamNhaSX(sp);
                CollectionPager1.BindToControl = dlSanPham;
                dlSanPham.DataSource = CollectionPager1.DataSourcePaged;
        }
        //Hàm tự viết
        //Đổ danh sách sản phẩm datalist 
        public void Ds_SanPham()
        {
            dlSanPham.DataSource = SanPhamClient.HienThiSanPhamFull();
            dlSanPham.DataBind();

            CollectionPager1.PageSize = 10;
            CollectionPager1.DataSource = SanPhamClient.HienThiSanPhamFull();
            CollectionPager1.BindToControl = dlSanPham;
            dlSanPham.DataSource = CollectionPager1.DataSourcePaged;
        }
        //Hàm tự viết
        //Đưa đến trang chi tiết sản phẩm
        protected void dlSanPham_ItemCommand(object source, DataListCommandEventArgs e)
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