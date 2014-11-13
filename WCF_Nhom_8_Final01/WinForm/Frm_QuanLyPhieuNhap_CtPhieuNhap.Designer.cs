namespace WinForm
{
    partial class Frm_QuanLyPhieuNhap_CtPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpTim_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbTim_NSX = new System.Windows.Forms.ComboBox();
            this.txtTim_MaPN = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbNhaSX = new System.Windows.Forms.ComboBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.PhieuNhapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupNhap = new System.Windows.Forms.GroupBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnLuuSanPham = new System.Windows.Forms.Button();
            this.dgvBangNhap = new System.Windows.Forms.DataGridView();
            this.SP_ID_Nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP_Nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhap)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(793, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhatLai);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.dtpTim_NgayNhap);
            this.groupBox3.Controls.Add(this.cbTim_NSX);
            this.groupBox3.Controls.Add(this.txtTim_MaPN);
            this.groupBox3.Controls.Add(this.cbTimKiem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm phiếu nhập";
            // 
            // btnCapNhatLai
            // 
            this.btnCapNhatLai.Location = new System.Drawing.Point(392, 73);
            this.btnCapNhatLai.Name = "btnCapNhatLai";
            this.btnCapNhatLai.Size = new System.Drawing.Size(111, 23);
            this.btnCapNhatLai.TabIndex = 5;
            this.btnCapNhatLai.Text = "Cập nhật lại";
            this.btnCapNhatLai.UseVisualStyleBackColor = true;
            this.btnCapNhatLai.Click += new System.EventHandler(this.btnCapNhatLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(265, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpTim_NgayNhap
            // 
            this.dtpTim_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpTim_NgayNhap.Enabled = false;
            this.dtpTim_NgayNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpTim_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTim_NgayNhap.Location = new System.Drawing.Point(570, 35);
            this.dtpTim_NgayNhap.Name = "dtpTim_NgayNhap";
            this.dtpTim_NgayNhap.Size = new System.Drawing.Size(136, 23);
            this.dtpTim_NgayNhap.TabIndex = 4;
            // 
            // cbTim_NSX
            // 
            this.cbTim_NSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTim_NSX.Enabled = false;
            this.cbTim_NSX.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTim_NSX.FormattingEnabled = true;
            this.cbTim_NSX.Items.AddRange(new object[] {
            "Chọn nhà sản xuất"});
            this.cbTim_NSX.Location = new System.Drawing.Point(423, 34);
            this.cbTim_NSX.Name = "cbTim_NSX";
            this.cbTim_NSX.Size = new System.Drawing.Size(124, 24);
            this.cbTim_NSX.TabIndex = 3;
            // 
            // txtTim_MaPN
            // 
            this.txtTim_MaPN.Enabled = false;
            this.txtTim_MaPN.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTim_MaPN.Location = new System.Drawing.Point(241, 34);
            this.txtTim_MaPN.MaxLength = 18;
            this.txtTim_MaPN.Name = "txtTim_MaPN";
            this.txtTim_MaPN.Size = new System.Drawing.Size(156, 23);
            this.txtTim_MaPN.TabIndex = 2;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã phiếu nhập",
            "Nhà sản xuất",
            "Ngày nhập hàng"});
            this.cbTimKiem.Location = new System.Drawing.Point(85, 34);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(138, 24);
            this.cbTimKiem.TabIndex = 1;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.dtpNgayNhap);
            this.groupBox2.Controls.Add(this.cbNhaSX);
            this.groupBox2.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm phiếu nhập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTongTien.Location = new System.Drawing.Point(442, 102);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(153, 23);
            this.txtTongTien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(365, 150);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(182, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu - Cập nhật chi tiết";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(209, 150);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 34);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm phiếu nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(442, 39);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(141, 23);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaSX.Enabled = false;
            this.cbNhaSX.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbNhaSX.FormattingEnabled = true;
            this.cbNhaSX.Items.AddRange(new object[] {
            "Chọn nhà sản xuất"});
            this.cbNhaSX.Location = new System.Drawing.Point(123, 101);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(153, 24);
            this.cbNhaSX.TabIndex = 2;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(123, 39);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(153, 23);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhập hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhieuNhapID,
            this.MaPhieuNhap,
            this.NhaSX_ID,
            this.TenNhaSX,
            this.NgayNhap,
            this.TongTien});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(6, 22);
            this.dgvPhieuNhap.MultiSelect = false;
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(761, 190);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.Click += new System.EventHandler(this.dgvPhieuNhap_Click);
            // 
            // PhieuNhapID
            // 
            this.PhieuNhapID.DataPropertyName = "PhieuNhap_ID";
            this.PhieuNhapID.HeaderText = "Phiếu nhập ID";
            this.PhieuNhapID.Name = "PhieuNhapID";
            this.PhieuNhapID.ReadOnly = true;
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.ReadOnly = true;
            // 
            // NhaSX_ID
            // 
            this.NhaSX_ID.DataPropertyName = "NhaSX_ID";
            this.NhaSX_ID.HeaderText = "Nhà sản xuất ID";
            this.NhaSX_ID.Name = "NhaSX_ID";
            this.NhaSX_ID.ReadOnly = true;
            this.NhaSX_ID.Visible = false;
            // 
            // TenNhaSX
            // 
            this.TenNhaSX.DataPropertyName = "TenNhaSX";
            this.TenNhaSX.HeaderText = "Tên nhà sản xuất";
            this.TenNhaSX.Name = "TenNhaSX";
            this.TenNhaSX.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Format = "#,##0";
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupNhap);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(793, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupNhap
            // 
            this.groupNhap.Controls.Add(this.btnHoanTat);
            this.groupNhap.Controls.Add(this.btnLuuSanPham);
            this.groupNhap.Controls.Add(this.dgvBangNhap);
            this.groupNhap.Location = new System.Drawing.Point(7, 231);
            this.groupNhap.Name = "groupNhap";
            this.groupNhap.Size = new System.Drawing.Size(773, 242);
            this.groupNhap.TabIndex = 1;
            this.groupNhap.TabStop = false;
            this.groupNhap.Text = "Thông tin nhập hàng";
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Location = new System.Drawing.Point(398, 188);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(173, 32);
            this.btnHoanTat.TabIndex = 1;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnLuuSanPham
            // 
            this.btnLuuSanPham.Enabled = false;
            this.btnLuuSanPham.Location = new System.Drawing.Point(219, 188);
            this.btnLuuSanPham.Name = "btnLuuSanPham";
            this.btnLuuSanPham.Size = new System.Drawing.Size(173, 32);
            this.btnLuuSanPham.TabIndex = 1;
            this.btnLuuSanPham.Text = "Lưu sản phẩm";
            this.btnLuuSanPham.UseVisualStyleBackColor = true;
            this.btnLuuSanPham.Click += new System.EventHandler(this.btnLuuSanPham_Click);
            // 
            // dgvBangNhap
            // 
            this.dgvBangNhap.AllowUserToAddRows = false;
            this.dgvBangNhap.AllowUserToDeleteRows = false;
            this.dgvBangNhap.AllowUserToOrderColumns = true;
            this.dgvBangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SP_ID_Nhap,
            this.TenSP_Nhap,
            this.SLNhap,
            this.DGNhap});
            this.dgvBangNhap.Location = new System.Drawing.Point(6, 22);
            this.dgvBangNhap.Name = "dgvBangNhap";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvBangNhap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBangNhap.Size = new System.Drawing.Size(761, 150);
            this.dgvBangNhap.TabIndex = 0;
            // 
            // SP_ID_Nhap
            // 
            this.SP_ID_Nhap.DataPropertyName = "SP_ID";
            this.SP_ID_Nhap.HeaderText = "Sản phẩm ID";
            this.SP_ID_Nhap.Name = "SP_ID_Nhap";
            this.SP_ID_Nhap.ReadOnly = true;
            // 
            // TenSP_Nhap
            // 
            this.TenSP_Nhap.DataPropertyName = "TenSP";
            this.TenSP_Nhap.HeaderText = "Tên sản phẩm";
            this.TenSP_Nhap.Name = "TenSP_Nhap";
            this.TenSP_Nhap.ReadOnly = true;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SoLuongNhap";
            this.SLNhap.HeaderText = "Số lượng nhập";
            this.SLNhap.Name = "SLNhap";
            // 
            // DGNhap
            // 
            this.DGNhap.DataPropertyName = "DonGiaNhap";
            this.DGNhap.HeaderText = "Đơn giá nhập";
            this.DGNhap.Name = "DGNhap";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(773, 218);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu nhập";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.SP_ID,
            this.TenSP,
            this.SoLuongNhap,
            this.DonGiaNhap});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(6, 22);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvChiTietPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(761, 190);
            this.dgvChiTietPhieuNhap.TabIndex = 1;
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPhieuNhap";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            // 
            // SP_ID
            // 
            this.SP_ID.DataPropertyName = "SP_ID";
            this.SP_ID.HeaderText = "SP_ID";
            this.SP_ID.Name = "SP_ID";
            this.SP_ID.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle5.Format = "#,##0";
            this.DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            // 
            // Frm_QuanLyPhieuNhap_CtPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 606);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_QuanLyPhieuNhap_CtPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phiếu nhập - Chi tiết phiếu nhập";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpTim_NgayNhap;
        private System.Windows.Forms.ComboBox cbTim_NSX;
        private System.Windows.Forms.TextBox txtTim_MaPN;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbNhaSX;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.GroupBox groupNhap;
        private System.Windows.Forms.Button btnLuuSanPham;
        private System.Windows.Forms.DataGridView dgvBangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_ID_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuNhapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnCapNhatLai;
    }
}