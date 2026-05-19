using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class XuatKho : Form
    {
        Ketnoi kn = new Ketnoi();
        // Cờ kiểm tra xem đơn hàng có đủ hàng để xuất không
        bool _duHang = false;

        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            LoadKhoToCombo();
            LoadDonHangChoXuat();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                LoadDonHangChoXuat();
            else
                LoadLichSuXuatKho();
        }

        private void LoadKhoToCombo()
        {
            DataTable dt = kn.ExecuteQuery("SELECT MaKho, TenKho FROM KHO");
            cboKho.DataSource = dt;
            cboKho.DisplayMember = "TenKho";
            cboKho.ValueMember = "MaKho";
        }

        // ===================== LOGIC TAB 1: TẠO PHIẾU =====================

        private void ResetActionPanel()
        {
            lblStatusCreate.Text = "Trạng thái: Vui lòng chọn đơn hàng.";
            lblStatusCreate.ForeColor = Color.Gray;
            btnTaoPhieu.Enabled = false;
            btnTaoPhieu.BackColor = Color.Gray; // Màu xám khi disabled
        }

        private void LoadDonHangChoXuat()
        {
            try
            {
                // Lấy đơn hàng ĐÃ DUYỆT hoặc CHỜ DUYỆT
                string sql = @"SELECT MaDH, MaKH, NgayDat, TrangThai FROM DONHANG 
                               WHERE TrangThai = N'Đã duyệt' OR TrangThai = N'Chờ duyệt'
                               ORDER BY NgayDat DESC";
                dgvDonChoXuat.DataSource = kn.ExecuteQuery(sql);

                // Reset UI
                dgvChiTietDon.DataSource = null;
                ResetActionPanel();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải đơn hàng chờ: " + ex.Message); }
        }

        private void dgvDonChoXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDH = dgvDonChoXuat.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();

                // 1. Auto-fill Info
                txtMaDH_Input.Text = maDH;
                txtMaPX_Input.Text = "PX" + new Random().Next(100, 999).ToString();
                dtpNgayXuat.Value = DateTime.Now;

                // 2. Load Grid Chi tiết ĐH
                string sql = $@"SELECT c.MaSP, s.TenSP, c.SoLuong AS SL_Dat, 0 AS Ton_Kho, N'Chưa kiểm tra' AS TrangThai
                                FROM CHITIETDONHANG c 
                                JOIN SANPHAM s ON c.MaSP = s.MaSP
                                WHERE c.MaDH = '{maDH}'";

                dgvChiTietDon.DataSource = kn.ExecuteQuery(sql);

                // 3. Tính tổng SL
                int total = 0;
                if (dgvChiTietDon.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvChiTietDon.Rows)
                    {
                        if (row.Cells["SL_Dat"].Value != null)
                        {
                            total += Convert.ToInt32(row.Cells["SL_Dat"].Value);
                        }
                    }
                }
                txtTongSL.Text = total.ToString();

                // 4. Reset Action Panel và nhắc nhở
                cboKho.SelectedValue = "K01"; // Chọn Kho Mặc định
                lblStatusCreate.Text = "Đã chọn đơn. Nhấn [KIỂM TRA TỒN] để xác nhận đủ hàng.";
                lblStatusCreate.ForeColor = Color.DarkOrange;
                btnTaoPhieu.Enabled = false;
                btnTaoPhieu.BackColor = Color.Gray;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDH_Input.Text) || cboKho.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Đơn hàng và Kho xuất.", "Lỗi");
                return;
            }

            string maKho = cboKho.SelectedValue.ToString();
            string maDH = txtMaDH_Input.Text;

            string sqlCheck = $@"
                SELECT c.MaSP, s.TenSP, c.SoLuong AS SL_Dat, 
                       ISNULL(t.SoLuongTonKho, 0) AS Ton_Kho,
                       CASE WHEN ISNULL(t.SoLuongTonKho, 0) >= c.SoLuong THEN N'OK' ELSE N'Thiếu' END AS TrangThai
                FROM CHITIETDONHANG c
                JOIN SANPHAM s ON c.MaSP = s.MaSP
                LEFT JOIN TONKHO t ON c.MaSP = t.MaSP AND t.MaKho = '{maKho}'
                WHERE c.MaDH = '{maDH}'";

            DataTable dt = kn.ExecuteQuery(sqlCheck);
            dgvChiTietDon.DataSource = dt;

            _duHang = true;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TrangThai"].ToString() == "Thiếu")
                {
                    _duHang = false;
                    break;
                }
            }

            if (_duHang)
            {
                lblStatusCreate.Text = "ĐỦ HÀNG! Sẵn sàng xuất kho.";
                lblStatusCreate.ForeColor = Color.Green;
                btnTaoPhieu.Enabled = true;
                btnTaoPhieu.BackColor = Color.ForestGreen; // Xanh lá khi đủ
            }
            else
            {
                lblStatusCreate.Text = "KHÔNG ĐỦ HÀNG! Vui lòng kiểm tra lại.";
                lblStatusCreate.ForeColor = Color.Red;
                btnTaoPhieu.Enabled = false;
                btnTaoPhieu.BackColor = Color.Gray; // Xám khi thiếu
            }
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            if (!_duHang || !btnTaoPhieu.Enabled) return; // Bảo vệ lần nữa

            string maKho = cboKho.SelectedValue.ToString();
            string maPX = txtMaPX_Input.Text.Trim();
            string maDH = txtMaDH_Input.Text;
            DateTime ngayXuat = dtpNgayXuat.Value;

            DataTable dtChiTiet = (DataTable)dgvChiTietDon.DataSource;

            if (MessageBox.Show($"Xác nhận Xuất kho Đơn hàng [{maDH}]?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LuuPhieuXuatVaCapNhatTon(maDH, maPX, maKho, ngayXuat, dtChiTiet);
            }
        }

        private void LuuPhieuXuatVaCapNhatTon(string maDH, string maPX, string maKho, DateTime ngayXuat, DataTable dtChiTiet)
        {
            using (SqlConnection conn = kn.GetConnect())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // B1: INSERT PHIEUXUAT (Master)
                    string sqlPX = "INSERT INTO PHIEUXUAT (MaPX, MaDH, MaKho, NgayXuat) VALUES (@px, @dh, @kho, @ngay)";
                    SqlCommand cmdPX = new SqlCommand(sqlPX, conn, tran);
                    cmdPX.Parameters.AddWithValue("@px", maPX);
                    cmdPX.Parameters.AddWithValue("@dh", maDH);
                    cmdPX.Parameters.AddWithValue("@kho", maKho);
                    cmdPX.Parameters.AddWithValue("@ngay", ngayXuat);
                    cmdPX.ExecuteNonQuery();

                    // B2 & B3: LOOP CHI TIẾT -> INSERT XUATKHO & TRỪ TỒN KHO
                    foreach (DataRow row in dtChiTiet.Rows)
                    {
                        string maSP = row["MaSP"].ToString();
                        int slXuat = Convert.ToInt32(row["SL_Dat"]);

                        // 2.1. Insert Chi tiết Xuất kho
                        string sqlXK = "INSERT INTO XUATKHO (MaPX, MaSP, SoLuong) VALUES (@px, @sp, @sl)";
                        SqlCommand cmdXK = new SqlCommand(sqlXK, conn, tran);
                        cmdXK.Parameters.AddWithValue("@px", maPX);
                        cmdXK.Parameters.AddWithValue("@sp", maSP);
                        cmdXK.Parameters.AddWithValue("@sl", slXuat);
                        cmdXK.ExecuteNonQuery();

                        // 2.2. Trừ Tồn Kho (Update TONKHO)
                        string sqlTru = "UPDATE TONKHO SET SoLuongTonKho = SoLuongTonKho - @sl WHERE MaKho = @kho AND MaSP = @sp";
                        SqlCommand cmdTru = new SqlCommand(sqlTru, conn, tran);
                        cmdTru.Parameters.AddWithValue("@sl", slXuat);
                        cmdTru.Parameters.AddWithValue("@kho", maKho);
                        cmdTru.Parameters.AddWithValue("@sp", maSP);
                        cmdTru.ExecuteNonQuery();
                    }

                    // B4: Cập nhật trạng thái Đơn hàng -> Sẵn sàng giao
                    string sqlDH = "UPDATE DONHANG SET TrangThai = N'Sẵn sàng giao' WHERE MaDH = @dh";
                    SqlCommand cmdDH = new SqlCommand(sqlDH, conn, tran);
                    cmdDH.Parameters.AddWithValue("@dh", maDH);
                    cmdDH.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Xuất kho thành công! Đơn hàng chuyển sang trạng thái: Sẵn sàng giao.", "Thông báo");

                    LoadDonHangChoXuat();
                    tabControl1.SelectedIndex = 1;
                    LoadLichSuXuatKho();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===================== LOGIC TAB 2: LỊCH SỬ =====================

        private void LoadLichSuXuatKho()
        {
            try
            {
                string sql = @"SELECT PX.MaPX, PX.MaDH, PX.NgayXuat, K.TenKho
                               FROM PHIEUXUAT PX JOIN KHO K ON PX.MaKho = K.MaKho
                               ORDER BY PX.NgayXuat DESC";

                dgvDSPhieu.DataSource = kn.ExecuteQuery(sql);
                // Đặt tên cột
                if (dgvDSPhieu.Columns["MaPX"] != null) dgvDSPhieu.Columns["MaPX"].HeaderText = "Mã Phiếu";
                if (dgvDSPhieu.Columns["MaDH"] != null) dgvDSPhieu.Columns["MaDH"].HeaderText = "Mã Đơn Hàng";
                if (dgvDSPhieu.Columns["NgayXuat"] != null) dgvDSPhieu.Columns["NgayXuat"].HeaderText = "Ngày Xuất";
                if (dgvDSPhieu.Columns["TenKho"] != null) dgvDSPhieu.Columns["TenKho"].HeaderText = "Kho Xuất";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải lịch sử xuất: " + ex.Message); }
        }

        private void dgvDSPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPX = dgvDSPhieu.Rows[e.RowIndex].Cells["MaPX"].Value.ToString();

                string sql = $@"SELECT X.MaSP, S.TenSP, X.SoLuong, K.TenKho
                                 FROM XUATKHO X
                                 JOIN SANPHAM S ON X.MaSP = S.MaSP
                                 JOIN PHIEUXUAT P ON X.MaPX = P.MaPX
                                 JOIN KHO K ON P.MaKho = K.MaKho
                                 WHERE X.MaPX = '{maPX}'";

                dgvChiTietPhieu.DataSource = kn.ExecuteQuery(sql);
            }
        }
    }
}