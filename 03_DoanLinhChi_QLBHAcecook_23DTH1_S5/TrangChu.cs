using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.PhanQuyen;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class TrangChu : Form
    {
        Ketnoi kn = new Ketnoi(); // Khởi tạo lớp kết nối

        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // 1. Cập nhật thông tin người dùng lên lblUser (Sử dụng Tên NV)
            UpdateUserInfo();

            // 2. Thực hiện phân quyền
            ApplyPermissions();
        }

        private void UpdateUserInfo()
        {
            // Lấy tên nhân viên từ CSDL
            string tenNV = GetTenNhanVien(SessionManager.MaNV);

            // CHỈ HIỂN THỊ TÊN NHÂN VIÊN
            if (!string.IsNullOrEmpty(tenNV))
            {
                lblUser.Text = tenNV;
            }
            else
            {
                lblUser.Text = SessionManager.TenDangNhap;
            }
        }

        // Hàm mới: Truy vấn tên nhân viên từ CSDL
        private string GetTenNhanVien(string maNV)
        {
            // Đảm bảo MaNV không rỗng để tránh lỗi SQL
            if (string.IsNullOrEmpty(maNV)) return null;

            string sql = $"SELECT TenNV FROM NHANVIEN WHERE MaNV = '{maNV}'";
            // Giả định ExecuteScalar trả về object, cần chuyển sang string và kiểm tra DBNull
            object result = kn.ExecuteScalar(sql);
            return (result != null && result != DBNull.Value) ? result.ToString() : null;
        }

        // ========================================================
        // I. LOGIC PHÂN QUYỀN
        // ========================================================

        private void ApplyPermissions()
        {
            string vaiTro = SessionManager.VaiTro;

            // --- ẨN MẶC ĐỊNH TẤT CẢ CÁC NÚT CHỨC NĂNG ---
            btnBanHang.Visible = false;
            btnSanPham.Visible = false;
            btnKhachHang.Visible = false;
            btnDonHang.Visible = false;
            btnHoaDon.Visible = false;
            btnKho.Visible = false;
            btnNhapHangTra.Visible = false;
            btnXuatKho.Visible = false;
            btnGiaoHang.Visible = false;
            btnThongKe.Visible = false;

            // --- PHÂN QUYỀN DỰA TRÊN VAI TRÒ ---
            switch (vaiTro)
            {
                case "Bán hàng":
                    btnBanHang.Visible = true;
                    btnDonHang.Visible = true;
                    btnKhachHang.Visible = true;
                    btnSanPham.Visible = true;
                    break;

                case "Kho":
                    btnKho.Visible = true;
                    btnNhapHangTra.Visible = true;
                    btnXuatKho.Visible = true;
                    btnSanPham.Visible = true;
                    break;

                case "Giao hàng":
                    btnGiaoHang.Visible = true;
                    btnDonHang.Visible = true;
                    break;

                case "Kế toán":
                    // CHỨC NĂNG KẾ TOÁN: Khách hàng, Sản phẩm, Đơn hàng, Hóa đơn
                    btnKhachHang.Visible = true;
                    btnSanPham.Visible = true;
                    btnDonHang.Visible = true;
                    btnHoaDon.Visible = true;
                    // Kế toán KHÔNG CÓ Thống kê theo yêu cầu mới này
                    break;

                case "Quản lý":
                case "Admin":
                    // Quản lý/Admin thấy TẤT CẢ
                    btnBanHang.Visible = true;
                    btnKhachHang.Visible = true;
                    btnSanPham.Visible = true;
                    btnDonHang.Visible = true;
                    btnHoaDon.Visible = true;
                    btnKho.Visible = true;
                    btnNhapHangTra.Visible = true;
                    btnXuatKho.Visible = true;
                    btnGiaoHang.Visible = true;
                    btnThongKe.Visible = true;
                    break;

                default:
                    // Vai trò không xác định
                    break;
            }
        }

        // ========================================================
        // II. LOGIC HIỂN THỊ FORM CON (OpenChildForm)
        // ========================================================

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            // 1. Đóng/Dispose form đang hoạt động (nếu có)
            if (activeForm != null)
                activeForm.Close();

            // 2. Thiết lập form con mới
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. Thêm form con vào Panel Body
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;

            // 4. Hiển thị form con
            childForm.BringToFront();
            childForm.Show();
        }


        // ========================================================
        // III. XỬ LÝ SỰ KIỆN CLICK MENU (MỞ FORM CON TRÊN PNLEBODY)
        // ========================================================

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Banhang());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HDon()); // Mở Form Hóa Đơn
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kho());
        }

        private void btnNhapHangTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapHangTra());
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XuatKho());
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiaoHang());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.Logout();
                DangNhap loginForm = new DangNhap();
                loginForm.Show();
                this.Close();
            }
        }
    }
}