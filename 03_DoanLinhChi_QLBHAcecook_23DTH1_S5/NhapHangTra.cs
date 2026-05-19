
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class NhapHangTra : Form
    {
        Ketnoi kn = new Ketnoi();
        DataTable dtHangTra;
        private DataTable dtKhoCache; // Cache dữ liệu Kho

        public NhapHangTra()
        {
            InitializeComponent();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadKhoToCombo();
            TaoMaPhieuNhapTuDong();
            LoadDanhSachPhieuNhap();
            SetInputMode(true); // Bắt đầu ở chế độ Tạo mới

            // Đăng ký sự kiện CellClick cho DGV
            dgvDanhSachPN.CellClick += new DataGridViewCellEventHandler(dgvDanhSachPN_CellClick);
            btnTaoMoi.Click += new EventHandler(btnTaoMoi_Click);
            btnTaiChiTiet.Click += new EventHandler(btnTaiChiTiet_Click);
            btnLuuPhieuNhap.Click += new EventHandler(btnLuuPhieuNhap_Click);
        }

        // --- A. CÁC HÀM HỖ TRỢ ---

        private void SetInputMode(bool isNewEntryMode)
        {
            // true: Tạo mới (cho phép nhập liệu) | false: Xem lịch sử (chỉ xem)
            txtMaPN.ReadOnly = !isNewEntryMode;

            // ĐÃ SỬA LỖI 1: Mở khóa Mã ĐH tham chiếu ở chế độ Tạo mới
            txtMaDHThamChieu.ReadOnly = !isNewEntryMode;

            cboKhoNhap.Enabled = isNewEntryMode;
            txtLyDo.ReadOnly = !isNewEntryMode;
            dtpNgayNhap.Enabled = isNewEntryMode;

            btnTaiChiTiet.Enabled = isNewEntryMode;
            btnLuuPhieuNhap.Enabled = isNewEntryMode;
            btnTaoMoi.Enabled = true; // Nút tạo mới luôn hoạt động

            // Lưới chi tiết
            if (dgvHangTra.Columns.Contains("SL_Tra"))
            {
                dgvHangTra.Columns["SL_Tra"].ReadOnly = !isNewEntryMode;
            }
        }

        private void LoadKhoToCombo()
        {
            try
            {
                dtKhoCache = kn.ExecuteQuery("SELECT MaKho, TenKho FROM KHO");
                cboKhoNhap.DataSource = dtKhoCache; // Gán cache
                cboKhoNhap.DisplayMember = "TenKho";
                cboKhoNhap.ValueMember = "MaKho";
                cboKhoNhap.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách Kho: " + ex.Message); }
        }

        private void TaoMaPhieuNhapTuDong()
        {
            Random rd = new Random();
            txtMaPN.Text = "PN" + rd.Next(100, 999).ToString();
        }

        // --- HÀM TẠO MỚI/RESET (Gắn vào nút TẠO MỚI) ---
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            // Thiết lập lại Form về chế độ nhập liệu
            TaoMaPhieuNhapTuDong();
            txtMaDHThamChieu.Clear();
            txtLyDo.Clear();
            dgvHangTra.DataSource = null; // Xóa lưới chi tiết
            cboKhoNhap.SelectedIndex = -1;
            dtpNgayNhap.Value = DateTime.Now;

            SetInputMode(true);
        }

        // --- B. DANH SÁCH MASTER & DETAIL LỊCH SỬ ---

        private void LoadDanhSachPhieuNhap()
        {
            try
            {
                // TRUY VẤN LẤY MA KHO CÙNG VỚI TÊN KHO
                string sql = @"SELECT p.MaPN, k.TenKho, p.NgayNhap, p.LyDo, p.MaKho
                               FROM PHIEUNHAP p 
                               JOIN KHO k ON p.MaKho = k.MaKho
                               ORDER BY p.NgayNhap DESC";

                DataTable dt = kn.ExecuteQuery(sql);
                dgvDanhSachPN.DataSource = dt;

                // --- ĐỊNH DẠNG DỮ LIỆU: FIREBRICK VÀ IN ĐẬM ---
                System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
                boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
                dgvDanhSachPN.DefaultCellStyle = boldFirebrickStyle;
                // ------------------------------------

                // Formatting
                if (dgvDanhSachPN.Columns.Contains("MaPN")) dgvDanhSachPN.Columns["MaPN"].HeaderText = "Mã Phiếu Nhập";
                if (dgvDanhSachPN.Columns.Contains("TenKho")) dgvDanhSachPN.Columns["TenKho"].HeaderText = "Kho Nhập";
                if (dgvDanhSachPN.Columns.Contains("NgayNhap")) dgvDanhSachPN.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                if (dgvDanhSachPN.Columns.Contains("LyDo")) dgvDanhSachPN.Columns["LyDo"].HeaderText = "Lý Do";
                if (dgvDanhSachPN.Columns.Contains("NgayNhap")) dgvDanhSachPN.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                if (dgvDanhSachPN.Columns.Contains("MaKho")) dgvDanhSachPN.Columns["MaKho"].Visible = false; // Ẩn cột Mã Kho
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách Phiếu Nhập: " + ex.Message, "Lỗi SQL");
            }
        }

        private void LoadChiTietPhieuNhap(string maPN)
        {
            string sql = $@"SELECT c.MaSP, s.TenSP, c.SoLuong AS SL_Tra
                            FROM CHITIETPN c
                            JOIN SANPHAM s ON c.MaSP = s.MaSP
                            WHERE c.MaPN = '{maPN}'";

            DataTable dt = kn.ExecuteQuery(sql);
            dgvHangTra.DataSource = dt;

            // --- ĐỊNH DẠNG DỮ LIỆU: FIREBRICK VÀ IN ĐẬM ---
            System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
            boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgvHangTra.DefaultCellStyle = boldFirebrickStyle;
            // ------------------------------------

            if (dgvHangTra.Columns.Contains("SL_Tra")) dgvHangTra.Columns["SL_Tra"].HeaderText = "SL Thực Nhập";

            // Ẩn cột không cần thiết khi xem lịch sử
            if (dgvHangTra.Columns.Contains("SL_Ban"))
            {
                dgvHangTra.Columns["SL_Ban"].Visible = false;
            }
        }

        // --- SỰ KIỆN CELL CLICK (MASTER-DETAIL) ---
        private void dgvDanhSachPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // SỬA LỖI 2: Đổ dữ liệu lên các ô Master
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPN.Rows.Count)
            {
                DataGridViewRow row = dgvDanhSachPN.Rows[e.RowIndex];

                // Kiểm tra dòng không phải là dòng mới/trống
                if (row.Cells["MaPN"].Value == null || row.IsNewRow) return;

                string maPN = row.Cells["MaPN"].Value.ToString();

                // --- 1. Đổ dữ liệu Master fields ---
                txtMaPN.Text = maPN;

                // Lấy MaKho từ cột MaKho đã load (và ẩn)
                string maKho = row.Cells["MaKho"].Value.ToString();

                // Đổ dữ liệu vào ComboBox (SỬA LỖI POPULATE CUỐI CÙNG)
                if (!string.IsNullOrEmpty(maKho) && dtKhoCache != null)
                {
                    // ÉP BUỘC COMBOBOX CẬP NHẬT GIÁ TRỊ VÀ HIỂN THỊ
                    cboKhoNhap.DataSource = null;
                    cboKhoNhap.DataSource = dtKhoCache;
                    cboKhoNhap.DisplayMember = "TenKho";
                    cboKhoNhap.ValueMember = "MaKho";
                    cboKhoNhap.SelectedValue = maKho;
                }

                // Đổ dữ liệu Master còn lại
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                txtMaDHThamChieu.Clear(); // Luôn xóa trường tham chiếu khi xem lịch sử

                // --- 2. Load Detail và Khóa Input ---
                LoadChiTietPhieuNhap(maPN);
                SetInputMode(false); // Chuyển sang chế độ xem lịch sử (KHÓA INPUT)
            }
        }

        // --- C. TẢI CHI TIẾT ĐƠN HÀNG GỐC ---

        private void btnTaiChiTiet_Click(object sender, EventArgs e)
        {
            string maDH = txtMaDHThamChieu.Text.Trim();
            if (string.IsNullOrEmpty(maDH))
            {
                MessageBox.Show("Vui lòng nhập Mã Đơn hàng gốc!", "Cảnh báo");
                return;
            }

            try
            {
                string sql = $@"SELECT c.MaSP, s.TenSP, s.DonViTinh, c.SoLuong AS SL_Ban, 
                                       0 AS SL_Tra -- Mặc định số lượng trả lại là 0
                                 FROM CHITIETDONHANG c 
                                 JOIN SANPHAM s ON c.MaSP = s.MaSP
                                 WHERE c.MaDH = '{maDH}'";

                dtHangTra = kn.ExecuteQuery(sql);

                if (dtHangTra == null || dtHangTra.Rows.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy chi tiết cho Đơn hàng: {maDH}", "Thông báo");
                    dgvHangTra.DataSource = null;
                    return;
                }

                // 1. Gán DataSource (Bước này tạo ra các cột)
                dgvHangTra.DataSource = dtHangTra;

                // 2. Định dạng Dữ liệu (Sử dụng lại logic Firebrick)
                System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
                boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
                dgvHangTra.DefaultCellStyle = boldFirebrickStyle;

                // 3. THIẾT LẬP CỘT SAU KHI GÁN DATASOURCE
                if (dgvHangTra.Columns.Contains("SL_Ban"))
                {
                    dgvHangTra.Columns["SL_Ban"].ReadOnly = true;
                    dgvHangTra.Columns["SL_Ban"].HeaderText = "SL Đã Bán";
                    dgvHangTra.Columns["SL_Ban"].Visible = true;
                }

                if (dgvHangTra.Columns.Contains("SL_Tra"))
                {
                    dgvHangTra.Columns["SL_Tra"].ReadOnly = false; // Cho phép sửa
                    dgvHangTra.Columns["SL_Tra"].HeaderText = "SL Thực Nhập";
                }

                SetInputMode(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message, "Lỗi SQL");
            }
        }

        // --- D. LƯU PHIẾU NHẬP (TRANSACTION) ---

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            // 1. Validate Input (kiểm tra ở chế độ tạo mới)
            if (!btnLuuPhieuNhap.Enabled) return;
            if (cboKhoNhap.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Kho nhập.", "Cảnh báo"); return; }
            if (string.IsNullOrEmpty(txtLyDo.Text)) { MessageBox.Show("Vui lòng nhập Lý do nhập kho.", "Cảnh báo"); return; }
            if (dgvHangTra.DataSource == null) { MessageBox.Show("Vui lòng tải chi tiết đơn hàng gốc trước.", "Cảnh báo"); return; }


            // Lấy tổng số lượng trả lại
            var totalReturned = dgvHangTra.Rows.Cast<DataGridViewRow>()
                 .Where(row => row.DataBoundItem != null)
                 .Sum(row => Convert.ToInt32(row.Cells["SL_Tra"].Value));

            if (totalReturned <= 0)
            {
                MessageBox.Show("Số lượng nhập kho phải lớn hơn 0.", "Cảnh báo");
                return;
            }

            // Check SL_Tra <= SL_Ban
            if (dgvHangTra.Columns.Contains("SL_Ban"))
            {
                foreach (DataGridViewRow row in dgvHangTra.Rows)
                {
                    if (row.DataBoundItem == null) continue;

                    int slTra = Convert.ToInt32(row.Cells["SL_Tra"].Value);
                    int slBan = Convert.ToInt32(row.Cells["SL_Ban"].Value);
                    if (slTra > slBan)
                    {
                        MessageBox.Show($"Số lượng trả lại ({slTra}) cho SP {row.Cells["TenSP"].Value} không thể lớn hơn số lượng đã bán ({slBan}).", "Lỗi nhập liệu");
                        return;
                    }
                }
            }


            string maPN = txtMaPN.Text.Trim();
            string maKho = cboKhoNhap.SelectedValue.ToString();
            string lyDo = txtLyDo.Text.Trim();

            // 2. Thực hiện Transaction (đảm bảo tính toàn vẹn)
            using (SqlConnection conn = kn.GetConnect())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // B1: INSERT PHIEUNHAP (Master)
                    string sqlPN = "INSERT INTO PHIEUNHAP (MaPN, MaKho, NgayNhap, LyDo, MaPGH) VALUES (@pn, @kho, @ngay, @lydo, NULL)";
                    SqlCommand cmdPN = new SqlCommand(sqlPN, conn, tran);
                    cmdPN.Parameters.AddWithValue("@pn", maPN);
                    cmdPN.Parameters.AddWithValue("@kho", maKho);
                    cmdPN.Parameters.AddWithValue("@ngay", dtpNgayNhap.Value);
                    cmdPN.Parameters.AddWithValue("@lydo", lyDo);
                    cmdPN.ExecuteNonQuery();

                    // B2: LOOP CHITIETPN & UPDATE TONKHO
                    foreach (DataGridViewRow row in dgvHangTra.Rows)
                    {
                        if (row.DataBoundItem == null) continue;

                        int slTra = Convert.ToInt32(row.Cells["SL_Tra"].Value);

                        if (slTra > 0)
                        {
                            string maSP = row.Cells["MaSP"].Value.ToString();

                            // 2.1. INSERT CHITIETPN
                            string sqlCTPN = "INSERT INTO CHITIETPN (MaPN, MaSP, SoLuong) VALUES (@pn, @sp, @sl)";
                            SqlCommand cmdCT = new SqlCommand(sqlCTPN, conn, tran);
                            cmdCT.Parameters.AddWithValue("@pn", maPN);
                            cmdCT.Parameters.AddWithValue("@sp", maSP);
                            cmdCT.Parameters.AddWithValue("@sl", slTra);
                            cmdCT.ExecuteNonQuery();

                            // 2.2. UPDATE CỘNG TỒN KHO 
                            string sqlTonKho = $@"
                                IF EXISTS (SELECT 1 FROM TONKHO WHERE MaKho = @kho AND MaSP = @sp)
                                    UPDATE TONKHO SET SoLuongTonKho = SoLuongTonKho + @sl WHERE MaKho = @kho AND MaSP = @sp
                                ELSE
                                    INSERT INTO TONKHO (MaKho, MaSP, SoLuongTonKho) VALUES (@kho, @sp, @sl)";

                            SqlCommand cmdTon = new SqlCommand(sqlTonKho, conn, tran);
                            cmdTon.Parameters.AddWithValue("@kho", maKho);
                            cmdTon.Parameters.AddWithValue("@sp", maSP);
                            cmdTon.Parameters.AddWithValue("@sl", slTra);
                            cmdTon.ExecuteNonQuery();
                        }
                    }

                    // B3: COMMIT
                    tran.Commit();
                    MessageBox.Show($"Nhập kho thành công! Mã Phiếu: {maPN}", "Thành công");

                    // Reset giao diện và Load lại danh sách Master
                    btnTaoMoi_Click(null, null); // Gọi lại hàm reset
                    LoadDanhSachPhieuNhap();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi lưu phiếu nhập: " + ex.Message, "Lỗi");
                }
            }
        }

        private void gbDieuChinh_Enter(object sender, EventArgs e)
        {
            // Không làm gì
        }
    }
}
