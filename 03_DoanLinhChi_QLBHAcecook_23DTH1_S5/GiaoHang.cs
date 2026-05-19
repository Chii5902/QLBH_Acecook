using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class GiaoHang : Form
    {
        Ketnoi kn = new Ketnoi();
        BindingSource bsGiaoHang = new BindingSource();

        public GiaoHang()
        {
            InitializeComponent();
        }

        private void PhieuGiaoHang_Load(object sender, EventArgs e)
        {
            SetupTrangThaiCombo();
            LoadDanhSachGiaoHang();
            BindControls();

            // QUAN TRỌNG: Đăng ký sự kiện kiểm tra trạng thái nút khi dòng được chọn thay đổi
            bsGiaoHang.CurrentItemChanged += BsGiaoHang_CurrentItemChanged;
        }

        // --- A. CÁC HÀM TẢI DỮ LIỆU & BINDING ---

        private void SetupTrangThaiCombo()
        {
            cboTrangThaiGH.Items.Add("Sẵn sàng giao");
            cboTrangThaiGH.Items.Add("Đang giao");
            cboTrangThaiGH.Items.Add("Giao thành công");
            cboTrangThaiGH.Items.Add("Giao thất bại");
        }

        private void LoadDanhSachGiaoHang()
        {
            try
            {
                // SỬA SQL: Tính tổng giá trị đơn hàng trực tiếp từ CHITIETDONHANG
                // (Sử dụng Subquery T để tính tổng, loại bỏ HOADON)
                string sql = @"
                    SELECT TOP 100 PERCENT
                        PGH.MaPGH, PGH.MaDH, PGH.MaHD, PGH.NgayGiao, PGH.TrangThaiGH,
                        DH.MaKH,
                        ISNULL(T.TongGiaTri, 0) AS TongGiaTriDon -- Tổng giá trị đơn hàng
                    FROM PHIEUGIAOHANG PGH
                    LEFT JOIN DONHANG DH ON PGH.MaDH = DH.MaDH
                    LEFT JOIN (
                        SELECT MaDH, SUM(SoLuong * DonGia * (1 - ChietKhau)) AS TongGiaTri
                        FROM CHITIETDONHANG
                        GROUP BY MaDH
                    ) AS T ON PGH.MaDH = T.MaDH
                    ORDER BY PGH.NgayGiao DESC";

                DataTable dt = kn.ExecuteQuery(sql);
                bsGiaoHang.DataSource = dt;
                dgvDSGiaoHang.DataSource = bsGiaoHang;

                // Định dạng cột
                if (dgvDSGiaoHang.Columns.Contains("TrangThaiGH"))
                    dgvDSGiaoHang.Columns["TrangThaiGH"].HeaderText = "Trạng Thái";
                if (dgvDSGiaoHang.Columns.Contains("MaKH"))
                    dgvDSGiaoHang.Columns["MaKH"].HeaderText = "Khách hàng";

                if (dgvDSGiaoHang.Columns.Contains("TongGiaTriDon"))
                {
                    dgvDSGiaoHang.Columns["TongGiaTriDon"].HeaderText = "Tổng Tiền";
                    dgvDSGiaoHang.Columns["TongGiaTriDon"].DefaultCellStyle.Format = "N0";
                    dgvDSGiaoHang.Columns["TongGiaTriDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dgvDSGiaoHang.Columns["MaHD"].Visible = false;

                // Kích hoạt logic disable nút lần đầu tiên
                BsGiaoHang_CurrentItemChanged(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu giao: " + ex.Message, "Lỗi SQL");
            }
        }

        private void BindControls()
        {
            txtMaPGH.DataBindings.Clear();
            txtMaDH.DataBindings.Clear();
            txtMaHD.DataBindings.Clear();
            txtNgayGiao.DataBindings.Clear();
            cboTrangThaiGH.DataBindings.Clear();

            txtMaPGH.DataBindings.Add("Text", bsGiaoHang, "MaPGH", true);
            txtMaDH.DataBindings.Add("Text", bsGiaoHang, "MaDH", true);
            txtMaHD.DataBindings.Add("Text", bsGiaoHang, "MaHD", true);
            txtNgayGiao.DataBindings.Add("Text", bsGiaoHang, "NgayGiao", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy HH:mm");

            cboTrangThaiGH.DataBindings.Add("Text", bsGiaoHang, "TrangThaiGH");
        }

        // --- C. LOGIC KHÓA NÚT (UX) ---

        private void BsGiaoHang_CurrentItemChanged(object sender, EventArgs e)
        {
            // Lấy trạng thái của dòng hiện tại từ BindingSource
            if (bsGiaoHang.Current is DataRowView currentRow)
            {
                string status = currentRow["TrangThaiGH"].ToString();

                // Nếu đã giao thành công, khóa nút lại
                if (status == "Giao thành công" || status == "Giao thất bại")
                {
                    btnCapNhatTrangThai.Enabled = false;
                    btnCapNhatTrangThai.BackColor = Color.Gray;
                }
                else
                {
                    btnCapNhatTrangThai.Enabled = true;
                    btnCapNhatTrangThai.BackColor = Color.ForestGreen;
                }
            }
        }

        private void dgvDSGiaoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bsGiaoHang.Position = e.RowIndex; // Di chuyển BindingSource
            }
        }

        // --- D. ĐIỀU HƯỚNG & CẬP NHẬT TRẠNG THÁI ---

        private void btnDau_Click(object sender, EventArgs e) { bsGiaoHang.MoveFirst(); }
        private void btnTruoc_Click(object sender, EventArgs e) { bsGiaoHang.MovePrevious(); }
        private void btnSau_Click(object sender, EventArgs e) { bsGiaoHang.MoveNext(); }
        private void btnCuoi_Click(object sender, EventArgs e) { bsGiaoHang.MoveLast(); }

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPGH.Text)) return;
            if (cboTrangThaiGH.SelectedItem == null) { MessageBox.Show("Vui lòng chọn trạng thái mới!", "Lỗi"); return; }
            if (btnCapNhatTrangThai.Enabled == false) return; // Bảo vệ nút

            string maPGH = txtMaPGH.Text;
            string maDH = txtMaDH.Text;
            string trangThaiMoi = cboTrangThaiGH.SelectedItem.ToString();

            // --- SỬA LỖI CS1503 (Truy cập dữ liệu an toàn qua DataRowView) ---
            if (bsGiaoHang.Current is DataRowView currentRow)
            {
                string currentStatus = currentRow["TrangThaiGH"].ToString();

                if (trangThaiMoi == currentStatus)
                {
                    MessageBox.Show("Trạng thái hiện tại đã là " + trangThaiMoi, "Thông báo");
                    return; // Dừng nếu trùng
                }
            }
            // -------------------------------------------------------------

            // Bắt đầu giao dịch an toàn
            using (SqlConnection conn = kn.GetConnect())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // B1: UPDATE PHIEUGIAOHANG (Truyền conn và tran)
                    string sql = "UPDATE PHIEUGIAOHANG SET TrangThaiGH = @TrangThai WHERE MaPGH = @MaPGH";
                    SqlCommand cmd = new SqlCommand(sql, conn, tran); // Đảm bảo gán conn và tran
                    cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                    cmd.Parameters.AddWithValue("@MaPGH", maPGH);
                    cmd.ExecuteNonQuery();

                    // B2: Cập nhật Đơn hàng sang 'Hoàn thành' nếu giao thành công
                    if (trangThaiMoi == "Giao thành công")
                    {
                        string sqlDH = "UPDATE DONHANG SET TrangThai = N'Hoàn thành' WHERE MaDH = @MaDH";

                        // Khởi tạo command mới, GÁN conn VÀ tran
                        SqlCommand cmdDH = new SqlCommand(sqlDH, conn, tran);
                        cmdDH.Parameters.AddWithValue("@MaDH", maDH);

                        // Thực thi trực tiếp
                        cmdDH.ExecuteNonQuery();
                    }

                    // B3: Hoàn tất
                    tran.Commit();

                    MessageBox.Show($"Cập nhật thành công trạng thái mới: {trangThaiMoi}", "Thông báo");

                    // Tải lại dữ liệu và giữ vị trí
                    LoadDanhSachGiaoHang();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi cập nhật CSDL. Dữ liệu đã được khôi phục: " + ex.Message, "Lỗi");
                }
            }
        }
        
    }
}