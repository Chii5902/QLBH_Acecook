using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing; // Thêm namespace Drawing để sử dụng Color và Font

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class KhachHang : Form
    {
        Ketnoi kn = new Ketnoi();
        BindingSource bs = new BindingSource();

        public KhachHang()
        {
            InitializeComponent();
        }

        // --- 1. SỰ KIỆN LOAD FORM ---
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            radTenKH.Checked = true; // Mặc định tìm theo tên
        }

        // --- 2. HÀM LOAD DỮ LIỆU CHUNG (CHỈNH SỬA ĐỊNH DẠNG) ---
        private void LoadDuLieu(string dieuKien = "")
        {
            try
            {
                string sql = "SELECT * FROM KHACHHANG";

                // Nếu có điều kiện tìm kiếm
                if (!string.IsNullOrEmpty(dieuKien))
                {
                    sql += " WHERE " + dieuKien;
                }

                DataTable dt = kn.ExecuteQuery(sql);

                // Gán dữ liệu vào BindingSource
                bs.DataSource = dt;
                dgvKH.DataSource = bs;

                // --- BỔ SUNG ĐỊNH DẠNG DỮ LIỆU: FIREBRICK VÀ IN ĐẬM ---
                System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
                // Đặt màu Firebrick
                boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
                // Đặt Font Segoe UI, In đậm (Bold)
                boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);

                // Áp dụng style cho toàn bộ dữ liệu (DefaultCellStyle)
                dgvKH.DefaultCellStyle = boldFirebrickStyle;
                // ------------------------------------

                // BINDING (Liên kết dữ liệu vào TextBox)
                txtMaKH.DataBindings.Clear();
                txtTenKH.DataBindings.Clear();
                txtSDT.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtNhomKH.DataBindings.Clear();
                txtCongNo.DataBindings.Clear();
                txtHanMucNo.DataBindings.Clear();

                txtMaKH.DataBindings.Add("Text", bs, "MaKH");
                txtTenKH.DataBindings.Add("Text", bs, "TenKH");
                txtSDT.DataBindings.Add("Text", bs, "SDT");
                txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
                txtNhomKH.DataBindings.Add("Text", bs, "LoaiKH");

                // Format số tiền (N0: 1,000,000)
                txtCongNo.DataBindings.Add("Text", bs, "TongNo", true, DataSourceUpdateMode.OnValidation, "", "N0");
                txtHanMucNo.DataBindings.Add("Text", bs, "HanMucNo", true, DataSourceUpdateMode.OnValidation, "", "N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ============================================================
        // CÁC NÚT ĐIỀU HƯỚNG
        // ============================================================
        private void btnDau_Click(object sender, EventArgs e) => bs.MoveFirst();
        private void btnTruoc_Click(object sender, EventArgs e) => bs.MovePrevious();
        private void btnSau_Click(object sender, EventArgs e) => bs.MoveNext();
        private void btnCuoi_Click(object sender, EventArgs e) => bs.MoveLast();

        // ============================================================
        // CÁC NÚT CHỨC NĂNG (CRUD)
        // ============================================================

        // --- THÊM KHÁCH HÀNG ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên khách hàng!");
                return;
            }

            try
            {
                // Xử lý số tiền (bỏ dấu phẩy nếu có)
                string hanMuc = txtHanMucNo.Text.Replace(",", "").Replace(".", "");
                if (string.IsNullOrEmpty(hanMuc)) hanMuc = "0";

                string sql = string.Format("INSERT INTO KHACHHANG (MaKH, TenKH, DiaChi, SDT, LoaiKH, TongNo, HanMucNo) VALUES ('{0}', N'{1}', N'{2}', '{3}', N'{4}', 0, {5})",
                    txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtNhomKH.Text, hanMuc);

                if (kn.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDuLieu(); // Tải lại danh sách
                }
                else MessageBox.Show("Thêm thất bại! Trùng mã khách hàng.");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- SỬA KHÁCH HÀNG ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;

            try
            {
                string hanMuc = txtHanMucNo.Text.Replace(",", "").Replace(".", "");
                if (string.IsNullOrEmpty(hanMuc)) hanMuc = "0";

                string sql = string.Format("UPDATE KHACHHANG SET TenKH = N'{1}', DiaChi = N'{2}', SDT = '{3}', LoaiKH = N'{4}', HanMucNo = {5} WHERE MaKH = '{0}'",
                    txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtNhomKH.Text, hanMuc);

                if (kn.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDuLieu();
                }
                else MessageBox.Show("Cập nhật thất bại!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- XÓA KHÁCH HÀNG ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;

            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng [" + txtTenKH.Text + "] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DELETE FROM KHACHHANG WHERE MaKH = '{txtMaKH.Text}'";
                    if (kn.ExecuteNonQuery(sql) > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDuLieu();
                    }
                    else MessageBox.Show("Xóa thất bại! Khách hàng này đang có Đơn hàng.");
                }
                catch (Exception ex) { MessageBox.Show("Không thể xóa. Lỗi: " + ex.Message); }
            }
        }

        // --- TẢI LẠI (RESET) ---
        private void btnXem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtNhomKH.Clear();
            txtCongNo.Text = "0";
            txtHanMucNo.Text = "0";
            txtMaKH.Focus();
            LoadDuLieu();
        }

        // --- TÌM KIẾM ---
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (tuKhoa == "")
            {
                LoadDuLieu();
                return;
            }

            string dieuKien = "";
            if (radMaKH.Checked)
                dieuKien = $"MaKH LIKE '%{tuKhoa}%'";
            else
                dieuKien = $"TenKH LIKE N'%{tuKhoa}%'";

            LoadDuLieu(dieuKien);
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BindingSource tự xử lý
        }
    }
}