using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WinForm.TonKhoServiceReference;

namespace WinForm
{
    public partial class Frm_QuanLyTonKho : Form
    {
        // ton kho      
        TonKhoServiceClient TonKhoClient = new TonKhoServiceClient();
        TonKho tk = new TonKho();

        public Frm_QuanLyTonKho()
        {
            InitializeComponent();
            Ds_TonKho();
            LocSoLuongTon();
            NamThang();
        }

        // Hàm tự viết
        // Load ds tồn kho
        public void Ds_TonKho()
        {
            dgvTonKho.AutoGenerateColumns = false;
            dgvTonKho.DataSource = TonKhoClient.HienThiTonKho();
        }

        // Hàm tự viết
        // 
        public void NamThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(string.Format("{0}",i));
            }
            cbThang.SelectedIndex = 0;
            for (int j = 2011; j <= 2015; j++)
            {
                cbNam.Items.Add(string.Format("{0}", j));
            }
            cbNam.SelectedIndex = 0;
        }

        // Hàm tự viết
        // Cập nhật ds Tồn kho
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Ds_TonKho();
            txtSP_ID.Text = "";
        }

        // Hàm tự viết
        // Lọc tồn kho theo điều kiện
        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvTonKho.AutoGenerateColumns = false;
            if (cbLocTonKho.Text == "Sản phẩm ID")
            {
                int sp_id = int.Parse(txtSP_ID.Text);
                tk.SP_ID = sp_id;

                if (TonKhoClient.TimKiemTonKho_SPID(tk).Count() > 0)
                {
                    dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_SPID(tk);
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm này", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTonKho.DataSource = null;
                }
            }
            else if (cbLocTonKho.Text == "Số lượng tồn")
            {
                int k = int.Parse(cbSoLuongTon.SelectedIndex.ToString());

                if (TonKhoClient.TimKiemTonKho_SoLuongTon(k).Count() > 0)
                {
                    dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_SoLuongTon(k);
                }
            }
            else if (cbLocTonKho.Text == "Tháng năm")
            {
                int thang = int.Parse(cbThang.SelectedItem.ToString());
                int nam = int.Parse(cbNam.SelectedItem.ToString());

                if (TonKhoClient.TimKiemTonKho_ThoiGian(thang, nam).Count() > 0)
                {
                    dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_ThoiGian(thang, nam);
                }
                else
                {
                    MessageBox.Show("Không có tồn kho trong thời gian này", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTonKho.DataSource = null;
                }
            }
            else
            {
                dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_Ngay(dtNgayTu.Value, dtNgayDen.Value);
            }
        }

        // Hàm tự viết
        // cbx Lọc số lượng tồn
        public void LocSoLuongTon()
        {
            cbSoLuongTon.Items.Insert(0, "Giảm dần");
            cbSoLuongTon.Items.Insert(1, "Tăng dần");
            cbSoLuongTon.SelectedIndex = 0;
        }

        // Hàm tự viết
        // HIển thị điều kiện lọc
        private void cbLocTonKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocTonKho.Text == "Sản phẩm ID")
            {
                txtSP_ID.Enabled = true;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = false;
            }
            else if (cbLocTonKho.Text == "Số lượng tồn")
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = true;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = false;
            }
            else if (cbLocTonKho.Text == "Tháng năm")
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = true;
                pnNgayThang.Enabled = false;
            }
            else
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = true;
            }
        }

        // Hàm tự viết
        // Chỉ nhập số
        private void txtSP_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        // Hàm tự viết
        // In báo cáo theo điều kiện
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            var frm = new Frm_baocao();
            var bc = new BaoCao.BaoCao();

            string loc = "";
            if (cbLocTonKho.Text == "Sản phẩm ID")
            {
                if (txtSP_ID.Text != "")
                {
                    frm.Crv.SelectionFormula = "{view_TonKho.SP_ID}=" + txtSP_ID.Text;
                }
                else
                {
                    MessageBox.Show("Nhập sản phẩm ID");
                }
            }
            else if (cbLocTonKho.Text == "Số lượng tồn")
            {
                MessageBox.Show("Không báo cáo theo số lượng tồn");
            }
            else if (cbLocTonKho.Text == "Tháng năm")
            {
                int thang = int.Parse(cbThang.SelectedItem.ToString());
                int nam = int.Parse(cbNam.SelectedItem.ToString());
                loc = "Month({view_TonKho.ThoiGian})=" + thang + " and Year({view_TonKho.ThoiGian})=" + nam + "";
                frm.Crv.SelectionFormula = loc;
            }
            else
            {
                DateTime tungay = dtNgayTu.Value;
                DateTime denngay = dtNgayDen.Value.AddDays(1);
                loc = "{view_TonKho.ThoiGian}>=#" + tungay + "# and {view_TonKho.ThoiGian}<=#" + denngay + "#";
                frm.Crv.SelectionFormula = loc;
            }

            CrystalDecisions.Shared.TableLogOnInfo thongtin;
            thongtin = bc.Database.Tables[0].LogOnInfo;
            thongtin.ConnectionInfo.ServerName = ".";
            thongtin.ConnectionInfo.DatabaseName = "XDPM_Website";
            thongtin.ConnectionInfo.IntegratedSecurity = true;

            bc.Database.Tables[0].ApplyLogOnInfo(thongtin);

            frm.Crv.ReportSource = bc;
            frm.Text = "Báo cáo tồn kho theo điều kiện";
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTonKho.AutoGenerateColumns = false;
            dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_Ngay(dtNgayTu.Value, dtNgayDen.Value);
        }

        // Hàm tự viết
        // In báo cáo chung
        private void btnInBCChung_Click(object sender, EventArgs e)
        {
            var frm = new Frm_baocao();
            var bc = new BaoCao.BaoCao();
            CrystalDecisions.Shared.TableLogOnInfo thongtin;
            thongtin = bc.Database.Tables[0].LogOnInfo;
            thongtin.ConnectionInfo.ServerName = ".";
            thongtin.ConnectionInfo.DatabaseName = "XDPM_Website";
            thongtin.ConnectionInfo.IntegratedSecurity = true;

            bc.Database.Tables[0].ApplyLogOnInfo(thongtin);

            frm.Crv.ReportSource = bc;
            frm.Text = "Báo cáo tất cả tồn kho";
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
