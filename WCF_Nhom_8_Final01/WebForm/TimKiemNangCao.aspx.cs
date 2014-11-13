using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebForm.SanPhamServiceReference;
using WebForm.NhaSXServiceReference;

namespace WebForm
{
    public partial class TimKiemNangCao : System.Web.UI.Page
    {
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        WebForm.SanPhamServiceReference.SanPham sp = new WebForm.SanPhamServiceReference.SanPham();

        NhaSXServiceClient NhaSXClient = new NhaSXServiceClient();
        NhaSX nsx = new NhaSX();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNhaSX.SelectedIndex = -1;
                HienThiNhaSX();

                ddlMucGia.SelectedIndex = -1;
            }
        }
        public void HienThiNhaSX()
        {
            ddlNhaSX.DataSource = NhaSXClient.HienThiNhaSX();
            ddlNhaSX.DataTextField = "TenNhaSX";
            ddlNhaSX.DataValueField = "NhaSX_ID";
            ddlNhaSX.DataBind();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            if ((ddlNhaSX.SelectedValue == "-1") || (ddlMucGia.SelectedValue == "-1"))
            {
                lbThongBaoLoi.Text = "Vui lòng chọn nhà sản xuất và chọn giá";
            }
            else
            {
                int nsx_id = int.Parse(ddlNhaSX.SelectedValue.Trim());
                string dongia = ddlMucGia.SelectedValue.ToString();
                string[] gia = dongia.Split('-');
                decimal dongiatu = decimal.Parse(gia[0].ToString());
                decimal dongiaden = decimal.Parse(gia[1].ToString());
                Response.Redirect("KetQuaTimKiem.aspx?NhaSX_ID=" + nsx_id + "&DonGiaTu=" + dongiatu + "&DonGiaDen=" + dongiaden);
            }
        }

    }
}