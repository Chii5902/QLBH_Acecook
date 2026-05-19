using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.PhanQuyen;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class DangNhap : Form
    {
        // Khởi tạo lớp kết nối (Giả định Ketnoi.cs đã được sửa lỗi kết nối)
        Ketnoi kn = new Ketnoi();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định khi form load (nếu cần)
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu
            if (chkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Hiện ký tự
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ẩn bằng dấu sao
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát khỏi chương trình?",
        "Xác nhận Thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            // Nếu người dùng chọn 'Có' (Yes), thoát ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Không làm gì, hoặc có thể thêm chức năng reset/link
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Truy vấn kiểm tra thông tin đăng nhập và lấy VaiTro/MaNV
            string sql = $@"
                SELECT TK.MaNV, TK.VaiTro, TK.TenDN
                FROM TAIKHOAN TK
                WHERE TK.TenDN = N'{username}' AND TK.MatKhau = N'{password}'";

            DataTable dt = kn.ExecuteQuery(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Đăng nhập thành công
                DataRow user = dt.Rows[0];
                string maNV = user["MaNV"].ToString();
                string vaiTro = user["VaiTro"].ToString();

                // 1. Lưu thông tin Session
                SessionManager.MaNV = maNV;
                SessionManager.VaiTro = vaiTro;
                SessionManager.TenDangNhap = username;

                MessageBox.Show($"Đăng nhập thành công! Vai trò: {vaiTro}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. Phân quyền và mở Trang Chủ
                TrangChu mainForm = new TrangChu();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}