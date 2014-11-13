using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WinForm.SanPhamServiceReference;
using WinForm.TonKhoServiceReference;
using WinForm.NhaSXServiceReference;

namespace WinForm
{
    public partial class Frm_QuanLySanPham : Form
    {       
        //
        SanPhamServiceClient SanPhamClient = new SanPhamServiceClient();
        TonKhoServiceClient TonKhoClient = new TonKhoServiceClient();
        NhaSXServiceClient NhaSXClient = new NhaSXServiceClient();
        SanPham sp = new SanPham();
        TonKho tk = new TonKho();        

        //
        string name = "";
        bool them_moi = false;
        //Hàm tự viết
        //Hàm khỏi tạo 
        public Frm_QuanLySanPham()
        {
            InitializeComponent();
            Ds_SanPham();
            Ds_NhaSX();
        }
        //Hàm tự viết
        //Hiển thị danh sách sản phẩm lên datagridview
        public void Ds_SanPham()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = SanPhamClient.HienThiSanPhamFull();
        }
        //Hàm tự viết
        //Hiển thị chi tiết sản phẩm khi chọn sản phẩm ở danh sách
        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            int vitri = dgvSanPham.CurrentRow.Index;
            int sp_id = int.Parse(dgvSanPham.Rows[vitri].Cells[0].Value.ToString());
            sp.SP_ID = sp_id;
            DataSet ds = SanPhamClient.ChiTietSanPham(sp);

            txtTenSP.Text = ds.Tables[0].Rows[0]["TenSP"].ToString();
            cbNhaSX.SelectedValue = int.Parse(ds.Tables[0].Rows[0]["NhaSX_ID"].ToString());
            txtCPU.Text = ds.Tables[0].Rows[0]["CPU"].ToString();
            txtHDD.Text = ds.Tables[0].Rows[0]["HDD"].ToString();
            txtRAM.Text = ds.Tables[0].Rows[0]["RAM"].ToString();
            txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
            txtBaoHanh.Text = ds.Tables[0].Rows[0]["BaoHanh"].ToString();
            txtMoTa.Text = ds.Tables[0].Rows[0]["MoTa"].ToString();
            txtSoLuongTon.Text = ds.Tables[0].Rows[0]["SoLuongTon"].ToString();

            name = ds.Tables[0].Rows[0]["Hinh"].ToString();

            string duongdan = string.Format("../../../Webform/Hinh/Laptop/{0}", name);
            picHinh.Load(duongdan);
        }
        //Hàm tự viết
        //Xử lý ẩn/hiện các control 
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Tên sản phẩm")
            {
                cbTimGia.Visible = false;
                cbTimNhaSX.Visible = false;
                txtTimKiem.Visible = true;
            }
            else
            {
                txtTimKiem.Visible = false;
                cbTimGia.Visible = true;
                cbTimNhaSX.Visible = true;
                cbTimGia.SelectedIndex = -1;
                cbTimNhaSX.SelectedIndex = -1;
            }
        }
        //Hàm tự viết
        //Hiển thị danh sách nhà sản xuất 
        public void Ds_NhaSX()
        {


            List<NhaSX> list = NhaSXClient.HienThiNhaSX().ToList();


            cbNhaSX.ValueMember = "NhaSX_ID";
            cbNhaSX.DisplayMember = "TenNhaSX";
            cbNhaSX.DataSource = list;

            cbTimNhaSX.ValueMember = "NhaSX_ID";
            cbTimNhaSX.DisplayMember = "TenNhaSX";
            cbTimNhaSX.DataSource = list;
        }
        //Hàm tự viết
        //làm mới các control
        public void LamMoi()
        {
            txtTenSP.Text = "";
            cbNhaSX.SelectedIndex = 0;
            txtBaoHanh.Text = "";
            txtCPU.Text = "";
            txtRAM.Text = "";
            txtHDD.Text = "";
            txtDonGia.Text = "0";
            txtSoLuongTon.Text = "0";
            txtMoTa.Text = "";
        }
        //Hàm tự viết
        //Xử lý các control khi bấm nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            CheMo(true);
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThemHinh.Enabled = true;
            LamMoi();
            them_moi = true;
        }
        //Hàm tự viết
        //Xử lý các control khi bấm nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "")
            {
                CheMo(true);
                if (txtDonGia.Text != "0")
                    txtDonGia.Enabled = true;

                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnThemHinh.Enabled = true;
                them_moi = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo");
            }
        }
        //Hàm tự viết
        //Xóa sản phẩm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ xóa sản phẩm ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int sp_id = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
                    sp.SP_ID = sp_id;

                    tk.SP_ID = sp_id;
                    TonKhoClient.Xoa(tk);

                    SanPhamClient.Xoa(sp);
                    MessageBox.Show("Xóa thành công", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
            }
            Ds_SanPham();
            LamMoi();
        }
        //Hàm tự viết
        //Xử lý các control khi bấm nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Ds_SanPham();
            LamMoi();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtDonGia.Enabled = false;
            btnThemHinh.Enabled = false;

            CheMo(false);
        }
        //Hàm tự viết
        //làm mờ các control
        public void CheMo(bool trangthai)
        {
            txtTenSP.Enabled = trangthai;
            cbNhaSX.Enabled = trangthai;
            txtBaoHanh.Enabled = trangthai;
            txtCPU.Enabled = trangthai;
            txtRAM.Enabled = trangthai;
            txtHDD.Enabled = trangthai;
            txtMoTa.Enabled = trangthai;
        }
        //Hàm tự viết
        //Kiểm tra xem các textbox đã nhập chưa
        bool KiemTra()
        {
            if (txtTenSP.Text == "" || txtBaoHanh.Text == "" || txtCPU.Text == "" || txtHDD.Text == "" || txtRAM.Text == ""
                || txtMoTa.Text == "" || txtDonGia.Text == "")
                return false;
            return true;
        }

        //Hàm tự viết
        //Lưu thông tin xuống csdl
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sp.TenSP = txtTenSP.Text;
            sp.NhaSX_ID = int.Parse(cbNhaSX.SelectedValue.ToString());
            sp.BaoHanh = txtBaoHanh.Text;
            sp.CPU = txtCPU.Text;
            sp.HDD = txtHDD.Text;
            sp.RAM = txtRAM.Text;
            sp.MoTa = txtMoTa.Text;
            sp.DonGia = float.Parse(txtDonGia.Text);
            sp.Hinh = name;
            if (KiemTra() == true)
            {

                if (them_moi == false)
                {
                    try
                    {
                        SanPhamClient.Sua(sp);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công\n" + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    try
                    {
                        SanPhamClient.Them(sp);

                        // them 1 dong vao ton kho voi so luong ton =0
                        int spid = int.Parse(SanPhamClient.LaySP_ID().Tables[0].Rows[0][0].ToString());
                        tk.SP_ID = spid;
                        tk.ThoiGian = DateTime.Now;
                        tk.SoLuongTon = 0;
                        TonKhoClient.Them_Moi(tk);

                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công\n" + ex.Message, "Thông báo");
                    }
                }
                Ds_SanPham();
                LamMoi();
                CheMo(false);
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnThemHinh.Enabled = false;
                txtDonGia.Enabled = false;

                // cap nhat hinh anh
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }
        //Hàm tự viết
        //Control xử lý tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (type.Text == "Tên sản phẩm")
            {
                if (txtTimKiem.Text != "")
                {
                    if (SanPhamClient.TimKiemSanPham(txtTimKiem.Text, 0, 0, 0).Count() > 0)
                    {
                        dgvSanPham.AutoGenerateColumns = false;
                        dgvSanPham.DataSource = SanPhamClient.TimKiemSanPham(txtTimKiem.Text, 0, 0, 0);
                    }
                    else
                    {
                        dgvSanPham.DataSource = null;
                        MessageBox.Show("Không có sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập tên sản phẩm", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    int nhasxid = int.Parse(cbTimNhaSX.SelectedValue.ToString());
                    string dongia = cbTimGia.SelectedItem.ToString();
                    string[] gia = dongia.Split('-');
                    decimal dongiatu = decimal.Parse(gia[0].ToString());
                    decimal dongiaden = decimal.Parse(gia[1].ToString());

                    dgvSanPham.AutoGenerateColumns = false;
                    if (SanPhamClient.TimKiemSanPham("", nhasxid, dongiatu, dongiaden).Count() > 0)
                    {
                        dgvSanPham.AutoGenerateColumns = false;
                        dgvSanPham.DataSource = SanPhamClient.TimKiemSanPham("", nhasxid, dongiatu, dongiaden);
                    }
                    else
                    {
                        dgvSanPham.DataSource = null;
                        MessageBox.Show("Không có sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn nhà sản xuất và khoảng giá", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Hàm tự viết
        //Chọn hình ảnh cho sản phẩm
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                picHinh.Load(f.FileName);
                name = f.SafeFileName;
                string duongdanmoi = "../../../Webform/Hinh/Laptop/" + name;
                File.Copy(f.FileName, duongdanmoi);
                MessageBox.Show(name);
            }
        }
        //Hàm tự viết
        //Hiển thị danh sách sản phẩm
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Ds_SanPham();
        }

        
    }
}
