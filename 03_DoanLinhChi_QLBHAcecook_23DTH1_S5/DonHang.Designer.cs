namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class DonHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.lstDonHang = new System.Windows.Forms.ListBox();
            this.grpChiTietSP = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.txtHanMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoHienTai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.grpChiTietSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            this.grpThongTinChung.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(467, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(184, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ĐƠN HÀNG";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.grpDanhSach);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Ivory;
            this.splitContainer1.Panel2.Controls.Add(this.grpChiTietSP);
            this.splitContainer1.Panel2.Controls.Add(this.grpThongTinChung);
            this.splitContainer1.Panel2.Controls.Add(this.grpChucNang);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 640);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTaoMoi);
            this.grpDanhSach.Controls.Add(this.lstDonHang);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.Firebrick;
            this.grpDanhSach.Location = new System.Drawing.Point(5, 5);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(310, 630);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách đơn hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTimKiem.Location = new System.Drawing.Point(10, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(210, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập mã đơn...";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Firebrick;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(230, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 32);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoMoi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Location = new System.Drawing.Point(10, 70);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(290, 40);
            this.btnTaoMoi.TabIndex = 2;
            this.btnTaoMoi.Text = "+ TẠO ĐƠN HÀNG MỚI";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // lstDonHang
            // 
            this.lstDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDonHang.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lstDonHang.FormattingEnabled = true;
            this.lstDonHang.ItemHeight = 23;
            this.lstDonHang.Location = new System.Drawing.Point(10, 120);
            this.lstDonHang.Name = "lstDonHang";
            this.lstDonHang.Size = new System.Drawing.Size(290, 487);
            this.lstDonHang.TabIndex = 3;
            this.lstDonHang.SelectedIndexChanged += new System.EventHandler(this.lstDonHang_SelectedIndexChanged);
            // 
            // grpChiTietSP
            // 
            this.grpChiTietSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChiTietSP.BackColor = System.Drawing.Color.White;
            this.grpChiTietSP.Controls.Add(this.dgvChiTietDonHang);
            this.grpChiTietSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpChiTietSP.ForeColor = System.Drawing.Color.Firebrick;
            this.grpChiTietSP.Location = new System.Drawing.Point(5, 190);
            this.grpChiTietSP.Name = "grpChiTietSP";
            this.grpChiTietSP.Size = new System.Drawing.Size(766, 350);
            this.grpChiTietSP.TabIndex = 1;
            this.grpChiTietSP.TabStop = false;
            this.grpChiTietSP.Text = "Chi tiết sản phẩm đặt mua";
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvChiTietDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietDonHang.ColumnHeadersHeight = 29;
            this.dgvChiTietDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietDonHang.EnableHeadersVisualStyles = false;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(3, 26);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.RowHeadersVisible = false;
            this.dgvChiTietDonHang.RowHeadersWidth = 51;
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(760, 321);
            this.dgvChiTietDonHang.TabIndex = 0;
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.BackColor = System.Drawing.Color.White;
            this.grpThongTinChung.Controls.Add(this.txtHanMuc);
            this.grpThongTinChung.Controls.Add(this.label7);
            this.grpThongTinChung.Controls.Add(this.txtNoHienTai);
            this.grpThongTinChung.Controls.Add(this.label6);
            this.grpThongTinChung.Controls.Add(this.txtTongTien);
            this.grpThongTinChung.Controls.Add(this.label5);
            this.grpThongTinChung.Controls.Add(this.txtTrangThai);
            this.grpThongTinChung.Controls.Add(this.label4);
            this.grpThongTinChung.Controls.Add(this.txtNgayDat);
            this.grpThongTinChung.Controls.Add(this.label3);
            this.grpThongTinChung.Controls.Add(this.txtKhachHang);
            this.grpThongTinChung.Controls.Add(this.label2);
            this.grpThongTinChung.Controls.Add(this.txtMaDH);
            this.grpThongTinChung.Controls.Add(this.label1);
            this.grpThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinChung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpThongTinChung.ForeColor = System.Drawing.Color.Firebrick;
            this.grpThongTinChung.Location = new System.Drawing.Point(5, 5);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(766, 180);
            this.grpThongTinChung.TabIndex = 0;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin chung _Tình trạng công nợ";
            // 
            // txtHanMuc
            // 
            this.txtHanMuc.Location = new System.Drawing.Point(538, 103);
            this.txtHanMuc.Name = "txtHanMuc";
            this.txtHanMuc.ReadOnly = true;
            this.txtHanMuc.Size = new System.Drawing.Size(210, 30);
            this.txtHanMuc.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(413, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hạn mức:";
            // 
            // txtNoHienTai
            // 
            this.txtNoHienTai.Location = new System.Drawing.Point(145, 120);
            this.txtNoHienTai.Name = "txtNoHienTai";
            this.txtNoHienTai.ReadOnly = true;
            this.txtNoHienTai.Size = new System.Drawing.Size(234, 30);
            this.txtNoHienTai.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nợ hiện tại:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(538, 143);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(210, 30);
            this.txtTongTien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(413, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(538, 63);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(210, 30);
            this.txtTrangThai.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(413, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái:";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(538, 23);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.ReadOnly = true;
            this.txtNgayDat.Size = new System.Drawing.Size(210, 30);
            this.txtNgayDat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(413, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày đặt:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(145, 80);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(234, 30);
            this.txtKhachHang.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khách hàng:";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(145, 40);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(234, 30);
            this.txtMaDH.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã ĐH:";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.btnDuyet);
            this.grpChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.ForeColor = System.Drawing.Color.Firebrick;
            this.grpChucNang.Location = new System.Drawing.Point(5, 555);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(766, 80);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Phê duyệt / Từ chối";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(447, 29);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy đơn";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.Firebrick;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(105, 29);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(184, 40);
            this.btnDuyet.TabIndex = 0;
            this.btnDuyet.Text = "Duyệt đơn";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "DonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Đơn hàng Acecook";
            this.Load += new System.EventHandler(this.DonHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            this.grpChiTietSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;

        // TRÁI
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListBox lstDonHang;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;

        // PHẢI
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHanMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoHienTai;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.GroupBox grpChiTietSP;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDuyet;
    }
}