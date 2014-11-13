using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WinForm.NhaSXServiceReference;

namespace WinForm
{
    public partial class Frm_QuanLyNhaSX : Form
    {
        NhaSXServiceClient NhaSXClient = new NhaSXServiceClient();
        NhaSX nsx = new NhaSX();       
  
        bool them_moi = false;

        public Frm_QuanLyNhaSX()
        {
            InitializeComponent();
        }
        //Hàm tự viết
        //Hiển thị danh sách sản phẩm
        private void Frm_QuanLyNhaSX_Load(object sender, EventArgs e)
        {
            Ds_NhaSX();
        }
        //Hàm tự viết
        //Đổ ds sản phẩm vào datagridview
        public void Ds_NhaSX()
        {
            dgvNhaSX.AutoGenerateColumns = false;
            dgvNhaSX.DataSource = NhaSXClient.HienThiNhaSX();
        }
        //Hàm tự viết
        //Hiển thị chi tiết nhà sản xuất khi chọn nhàn sản xuất
        private void dgvNhaSX_Click(object sender, EventArgs e)
        {
            int vitri = dgvNhaSX.CurrentRow.Index;
            List<NhaSX> list = NhaSXClient.HienThiNhaSX().ToList();
            nsx = list[vitri];
            txtNhaSXID.Text = nsx.NhaSX_ID.ToString();
            txtTenNhaSX.Text = nsx.TenNhaSX.ToString();
        }
        //Hàm tự viết
        //Thêm nhà sản xuất mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenNhaSX.Enabled = true;
            LamMoi();
            them_moi = true;
            CheMo(true);
        }
        //Hàm tự viết
        //làm mới control
        private void LamMoi()
        {
            txtTenNhaSX.Text = "";
            txtNhaSXID.Text = "";
        }
        //Hàm tự viết
        //làm mờ các control
        void CheMo(bool trangthai)
        {
            btnThem.Enabled = !trangthai;
            btnSua.Enabled = !trangthai;
            btnXoa.Enabled = !trangthai;
            btnLuu.Enabled = trangthai;
            btnHuy.Enabled = trangthai;

            txtTenNhaSX.Enabled = trangthai;
        }
        //Hàm tự viết
        //Lưu thông tin xuống csdl
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them_moi == true)
            {
                if (txtTenNhaSX.Text != "")
                {
                    try
                    {
                        nsx.TenNhaSX = txtTenNhaSX.Text.Trim();
                        NhaSXClient.Them(nsx);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            else
            {
                if (txtTenNhaSX.Text != "")
                {
                    try
                    {
                        nsx.TenNhaSX = txtTenNhaSX.Text.Trim();
                        NhaSXClient.Sua(nsx);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            CheMo(false);

            Ds_NhaSX();
        }
        //Hàm tự viết
        //Xử lý control khi bấm vào nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenNhaSX.Enabled = true;
            them_moi = false;
            CheMo(true);
        }
        //Hàm tự viết
        //Hủy thao tác hiện tại
        private void btnHuy_Click(object sender, EventArgs e)
        {
            CheMo(false);
            LamMoi();
        }
        //Xóa nhà cũng cấp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhà cung cấp", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    nsx.NhaSX_ID = int.Parse(txtNhaSXID.Text);
                    NhaSXClient.Xoa(nsx);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
                Ds_NhaSX();
            }
        }
    }
}
