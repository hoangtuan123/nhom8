using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Admin đang sử dụng chương trình";
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            toolStripStatusLabel2.Text = "Chương trình quản lý bán hàng";

            var gioithieu = new GioiThieu();
            openform(gioithieu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                toolStripStatusLabel2.Text = "Màn hình đang chạy: " + this.ActiveMdiChild.Text;
            }
            else
            {
                toolStripStatusLabel2.Text = "Chương trình quản lý bán hàng";
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình ?", "Thông báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        void openform(Form frm)
        {
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            var SanPham = new Frm_QuanLySanPham();
            openform(SanPham);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            var TonKho = new Frm_QuanLyTonKho();
            openform(TonKho);
        }

        private void btnNhaSX_Click(object sender, EventArgs e)
        {
            var NhaSX = new Frm_QuanLyNhaSX();
            openform(NhaSX);
        }

        private void btnDonDH_Click(object sender, EventArgs e)
        {
            var dondh = new Frm_QuanLyDonDH_CtDonDH();
            openform(dondh);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            var phieunhap = new Frm_QuanLyPhieuNhap_CtPhieuNhap();
            openform(phieunhap);
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            var gioithieu = new GioiThieu();
            openform(gioithieu);
        }
    }
}
