namespace WinForm
{
    partial class Frm_QuanLyTonKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.SP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnNgayThang = new System.Windows.Forms.Panel();
            this.dtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayTu = new System.Windows.Forms.DateTimePicker();
            this.pnThangNam = new System.Windows.Forms.Panel();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocTonKho = new System.Windows.Forms.ComboBox();
            this.cbSoLuongTon = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtSP_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInBCChung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnNgayThang.SuspendLayout();
            this.pnThangNam.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTonKho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tồn kho";
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.AllowUserToResizeColumns = false;
            this.dgvTonKho.AllowUserToResizeRows = false;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SP_ID,
            this.TenSP,
            this.ThoiGian,
            this.SoLuongTon});
            this.dgvTonKho.Location = new System.Drawing.Point(6, 22);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.Size = new System.Drawing.Size(572, 260);
            this.dgvTonKho.TabIndex = 0;
            // 
            // SP_ID
            // 
            this.SP_ID.DataPropertyName = "SP_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SP_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SP_ID.HeaderText = "Sản phẩm ID";
            this.SP_ID.Name = "SP_ID";
            this.SP_ID.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.ThoiGian.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuongTon.DefaultCellStyle = dataGridViewCellStyle4;
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnNgayThang);
            this.groupBox2.Controls.Add(this.pnThangNam);
            this.groupBox2.Controls.Add(this.cbLocTonKho);
            this.groupBox2.Controls.Add(this.cbSoLuongTon);
            this.groupBox2.Controls.Add(this.btnInBCChung);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnInBaoCao);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.txtSP_ID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc tồn kho ";
            // 
            // pnNgayThang
            // 
            this.pnNgayThang.Controls.Add(this.dtNgayDen);
            this.pnNgayThang.Controls.Add(this.label3);
            this.pnNgayThang.Controls.Add(this.label4);
            this.pnNgayThang.Controls.Add(this.dtNgayTu);
            this.pnNgayThang.Enabled = false;
            this.pnNgayThang.Location = new System.Drawing.Point(7, 183);
            this.pnNgayThang.Name = "pnNgayThang";
            this.pnNgayThang.Size = new System.Drawing.Size(571, 61);
            this.pnNgayThang.TabIndex = 8;
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDen.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDen.Location = new System.Drawing.Point(293, 19);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(123, 23);
            this.dtNgayDen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đến ngày";
            // 
            // dtNgayTu
            // 
            this.dtNgayTu.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTu.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtNgayTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTu.Location = new System.Drawing.Point(77, 17);
            this.dtNgayTu.Name = "dtNgayTu";
            this.dtNgayTu.Size = new System.Drawing.Size(123, 23);
            this.dtNgayTu.TabIndex = 14;
            // 
            // pnThangNam
            // 
            this.pnThangNam.Controls.Add(this.cbNam);
            this.pnThangNam.Controls.Add(this.cbThang);
            this.pnThangNam.Controls.Add(this.label7);
            this.pnThangNam.Controls.Add(this.label6);
            this.pnThangNam.Enabled = false;
            this.pnThangNam.Location = new System.Drawing.Point(6, 114);
            this.pnThangNam.Name = "pnThangNam";
            this.pnThangNam.Size = new System.Drawing.Size(572, 63);
            this.pnThangNam.TabIndex = 7;
            // 
            // cbNam
            // 
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(294, 22);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(73, 24);
            this.cbNam.TabIndex = 8;
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(105, 22);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(73, 24);
            this.cbThang.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chọn năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chọn tháng";
            // 
            // cbLocTonKho
            // 
            this.cbLocTonKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocTonKho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLocTonKho.FormattingEnabled = true;
            this.cbLocTonKho.Items.AddRange(new object[] {
            "Sản phẩm ID",
            "Số lượng tồn",
            "Tháng năm",
            "Ngày tháng"});
            this.cbLocTonKho.Location = new System.Drawing.Point(235, 31);
            this.cbLocTonKho.Name = "cbLocTonKho";
            this.cbLocTonKho.Size = new System.Drawing.Size(164, 24);
            this.cbLocTonKho.TabIndex = 6;
            this.cbLocTonKho.SelectedIndexChanged += new System.EventHandler(this.cbLocTonKho_SelectedIndexChanged);
            // 
            // cbSoLuongTon
            // 
            this.cbSoLuongTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoLuongTon.Enabled = false;
            this.cbSoLuongTon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSoLuongTon.FormattingEnabled = true;
            this.cbSoLuongTon.Location = new System.Drawing.Point(405, 77);
            this.cbSoLuongTon.Name = "cbSoLuongTon";
            this.cbSoLuongTon.Size = new System.Drawing.Size(146, 24);
            this.cbSoLuongTon.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(449, 260);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 27);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật lại";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(123, 260);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(183, 27);
            this.btnInBaoCao.TabIndex = 4;
            this.btnInBaoCao.Text = "In báo cáo theo điều kiện";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(7, 260);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(110, 27);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc tồn kho";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtSP_ID
            // 
            this.txtSP_ID.Enabled = false;
            this.txtSP_ID.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtSP_ID.Location = new System.Drawing.Point(111, 78);
            this.txtSP_ID.Name = "txtSP_ID";
            this.txtSP_ID.Size = new System.Drawing.Size(146, 23);
            this.txtSP_ID.TabIndex = 1;
            this.txtSP_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSP_ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lọc tồn kho theo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm ID";
            // 
            // btnInBCChung
            // 
            this.btnInBCChung.Location = new System.Drawing.Point(312, 260);
            this.btnInBCChung.Name = "btnInBCChung";
            this.btnInBCChung.Size = new System.Drawing.Size(131, 27);
            this.btnInBCChung.TabIndex = 4;
            this.btnInBCChung.Text = "In báo cáo chung";
            this.btnInBCChung.UseVisualStyleBackColor = true;
            this.btnInBCChung.Click += new System.EventHandler(this.btnInBCChung_Click);
            // 
            // Frm_QuanLyTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_QuanLyTonKho";
            this.Text = "Quản lý tồn kho";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnNgayThang.ResumeLayout(false);
            this.pnNgayThang.PerformLayout();
            this.pnThangNam.ResumeLayout(false);
            this.pnThangNam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtSP_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbLocTonKho;
        private System.Windows.Forms.ComboBox cbSoLuongTon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnNgayThang;
        private System.Windows.Forms.DateTimePicker dtNgayDen;
        private System.Windows.Forms.DateTimePicker dtNgayTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInBCChung;
    }
}