namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnGiaoHang = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapHangTra = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button(); // Nút Hóa Đơn MỚI
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.pnlLogoInfo = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnGiaoHang);
            this.pnlMenu.Controls.Add(this.btnXuatKho);
            this.pnlMenu.Controls.Add(this.btnNhapHangTra);
            this.pnlMenu.Controls.Add(this.btnKho);
            this.pnlMenu.Controls.Add(this.btnHoaDon); // THÊM NÚT HÓA ĐƠN
            this.pnlMenu.Controls.Add(this.btnDonHang);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.btnBanHang);
            this.pnlMenu.Controls.Add(this.pnlLogoInfo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 800);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 750);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(250, 50);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoHang.FlatAppearance.BorderSize = 0;
            this.btnGiaoHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiaoHang.ForeColor = System.Drawing.Color.White;
            this.btnGiaoHang.Location = new System.Drawing.Point(0, 580);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGiaoHang.Size = new System.Drawing.Size(250, 60);
            this.btnGiaoHang.TabIndex = 13;
            this.btnGiaoHang.Text = "🏍️ GIAO HÀNG";
            this.btnGiaoHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoHang.UseVisualStyleBackColor = true;
            this.btnGiaoHang.Click += new System.EventHandler(this.btnGiaoHang_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatKho.FlatAppearance.BorderSize = 0;
            this.btnXuatKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXuatKho.ForeColor = System.Drawing.Color.White;
            this.btnXuatKho.Location = new System.Drawing.Point(0, 520);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnXuatKho.Size = new System.Drawing.Size(250, 60);
            this.btnXuatKho.TabIndex = 12;
            this.btnXuatKho.Text = "🚚 XUẤT KHO";
            this.btnXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapHangTra
            // 
            this.btnNhapHangTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHangTra.FlatAppearance.BorderSize = 0;
            this.btnNhapHangTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNhapHangTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHangTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhapHangTra.ForeColor = System.Drawing.Color.White;
            this.btnNhapHangTra.Location = new System.Drawing.Point(0, 460);
            this.btnNhapHangTra.Name = "btnNhapHangTra";
            this.btnNhapHangTra.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNhapHangTra.Size = new System.Drawing.Size(250, 60);
            this.btnNhapHangTra.TabIndex = 11;
            this.btnNhapHangTra.Text = "🔙 NHẬP HÀNG TRẢ";
            this.btnNhapHangTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHangTra.UseVisualStyleBackColor = true;
            this.btnNhapHangTra.Click += new System.EventHandler(this.btnNhapHangTra_Click);
            // 
            // btnKho
            // 
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Location = new System.Drawing.Point(0, 400);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKho.Size = new System.Drawing.Size(250, 60);
            this.btnKho.TabIndex = 10;
            this.btnKho.Text = "🏠 QUẢN LÝ KHO";
            this.btnKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 340);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(250, 60);
            this.btnHoaDon.TabIndex = 9;
            this.btnHoaDon.Text = "💵 HÓA ĐƠN";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click); // Đăng ký sự kiện
            // 
            // btnDonHang
            // 
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDonHang.ForeColor = System.Drawing.Color.White;
            this.btnDonHang.Location = new System.Drawing.Point(0, 280);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDonHang.Size = new System.Drawing.Size(250, 60);
            this.btnDonHang.TabIndex = 8;
            this.btnDonHang.Text = "📝 ĐƠN HÀNG";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 220);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 60);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "📊 THỐNG KÊ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 160);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 60);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Text = "👥 KHÁCH HÀNG";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(0, 100);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(250, 60);
            this.btnSanPham.TabIndex = 5;
            this.btnSanPham.Text = "🍜 SẢN PHẨM";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(0, 40);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(250, 60);
            this.btnBanHang.TabIndex = 4;
            this.btnBanHang.Text = "📦 BÁN HÀNG";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // pnlLogoInfo
            // 
            this.pnlLogoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogoInfo.Controls.Add(this.lblUser);
            this.pnlLogoInfo.Controls.Add(this.label1);
            this.pnlLogoInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoInfo.Name = "pnlLogoInfo";
            this.pnlLogoInfo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogoInfo.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblUser.Location = new System.Drawing.Point(12, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(147, 28);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Nguyễn Văn A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào,";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBody.BackgroundImage")));
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(250, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(950, 800);
            this.pnlBody.TabIndex = 2;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.Name = "TrangChu";
            this.Text = "Hệ thống Quản lý Bán hàng Acecook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogoInfo.ResumeLayout(false);
            this.pnlLogoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Panel pnlLogoInfo;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;

        // Các nút mới đã thêm
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnNhapHangTra;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnGiaoHang;
        private System.Windows.Forms.Button btnHoaDon; // Khai báo nút Hóa Đơn MỚI
    }
}