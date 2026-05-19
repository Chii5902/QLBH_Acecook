using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class ThongKe : Form
    {
        // Khởi tạo lớp kết nối
        Ketnoi kn = new Ketnoi();

        public ThongKe()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += new EventHandler(ThongKe_Load);
            tabControlThongKe.SelectedIndexChanged += new EventHandler(tabControlThongKe_SelectedIndexChanged);
            btnLocDoanhSo.Click += new EventHandler(btnLocDoanhSo_Click);
            btnLocCongNo.Click += new EventHandler(btnLocCongNo_Click);
            cboLocKho.SelectedIndexChanged += new EventHandler(cboLocKho_SelectedIndexChanged);

            // Đã đăng ký sự kiện cho ComboBox Lọc Loại KH
            cboLocLoaiKH.SelectedIndexChanged += new EventHandler(cboLocLoaiKH_SelectedIndexChanged);

            // Thiết lập DataGridView mặc định
            SetupDataGridView(dgvDoanhSoChiTiet);
            SetupDataGridView(dgvTonKhoChiTiet);
            SetupDataGridView(dgvCongNoChiTiet);
        }

        // Thiết lập chung cho DataGridView
        private void SetupDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;

            // Áp dụng định dạng Header CellStyle đã thiết lập trong designer cho tất cả dgv
            if (dgv.Name != "dgvDoanhSoChiTiet" && dgvDoanhSoChiTiet.ColumnHeadersDefaultCellStyle != null)
            {
                dgv.ColumnHeadersDefaultCellStyle = dgvDoanhSoChiTiet.ColumnHeadersDefaultCellStyle;
                dgv.ColumnHeadersHeight = 35;
                dgv.EnableHeadersVisualStyles = false;
            }

            // --- THIẾT LẬP DEFAULT CELL STYLE: FIREBRICK & BOLD ---
            System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
            boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgv.DefaultCellStyle = boldFirebrickStyle;
            // --------------------------------------------------------
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mặc định cho báo cáo Doanh số (30 ngày gần nhất)
            dtpEnd.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddDays(-30);

            // Khởi tạo ComboBox Lọc Kho
            LoadKhoToCombo();

            // Khởi tạo ComboBox Lọc Loại KH
            LoadLoaiKHToCombo();

            // Load dữ liệu tab đầu tiên (Doanh số)
            LoadDoanhSo();
        }

        private void tabControlThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tải dữ liệu khi chuyển tab
            if (tabControlThongKe.SelectedTab == tabDoanhSo)
                LoadDoanhSo();
            else if (tabControlThongKe.SelectedTab == tabTonKho)
                LoadTonKho();
            else if (tabControlThongKe.SelectedTab == tabCongNo)
                LoadCongNo();
        }

        // ===================== A. TAB 1: DOANH SỐ =====================

        private void LoadDoanhSo()
        {
            // Lấy ngày bắt đầu chỉ lấy phần Date
            DateTime ngayBatDau = dtpStart.Value.Date;
            // Lấy đến cuối ngày kết thúc (23:59:59.997)
            DateTime ngayKetThuc = dtpEnd.Value.Date.AddDays(1).AddMilliseconds(-3);

            try
            {
                // 1. Tải KPI (Tổng doanh số) - Dùng String Interpolation cho Date
                string sqlTongDoanhSo = $@"SELECT ISNULL(SUM(TongThanhToan), 0)
                                         FROM HOADON
                                         WHERE NgayBan BETWEEN '{ngayBatDau:yyyy-MM-dd HH:mm:ss}' AND '{ngayKetThuc:yyyy-MM-dd HH:mm:ss}'";

                decimal tongDoanhSo = kn.ExecuteScalar<decimal>(sqlTongDoanhSo);

                lblTongDoanhSo.Text = string.Format("{0:N0} VNĐ", tongDoanhSo);
                lblTongDoanhSo.ForeColor = (tongDoanhSo > 0) ? Color.Red : Color.Gray;


                // 2. Tải chi tiết (Doanh số theo Hóa đơn)
                string sqlChiTiet = $@"
                    SELECT 
                        HD.MaHD, N.TenNV, K.TenKH, HD.NgayBan, HD.TongThanhToan
                    FROM HOADON HD
                    JOIN DONHANG DH ON HD.MaDH = DH.MaDH
                    JOIN NHANVIEN N ON DH.MaNV = N.MaNV
                    JOIN KHACHHANG K ON DH.MaKH = K.MaKH
                    WHERE HD.NgayBan BETWEEN '{ngayBatDau:yyyy-MM-dd HH:mm:ss}' AND '{ngayKetThuc:yyyy-MM-dd HH:mm:ss}'
                    ORDER BY HD.TongThanhToan DESC";

                DataTable dt = kn.ExecuteQuery(sqlChiTiet);

                dgvDoanhSoChiTiet.DataSource = dt;

                // Định dạng cột và đặt tên tiêu đề
                if (dgvDoanhSoChiTiet.Columns.Contains("MaHD")) dgvDoanhSoChiTiet.Columns["MaHD"].HeaderText = "Mã HĐ";
                if (dgvDoanhSoChiTiet.Columns.Contains("TenNV")) dgvDoanhSoChiTiet.Columns["TenNV"].HeaderText = "Nhân viên";
                if (dgvDoanhSoChiTiet.Columns.Contains("TenKH")) dgvDoanhSoChiTiet.Columns["TenKH"].HeaderText = "Khách hàng";
                if (dgvDoanhSoChiTiet.Columns.Contains("NgayBan"))
                {
                    dgvDoanhSoChiTiet.Columns["NgayBan"].HeaderText = "Ngày bán";
                    dgvDoanhSoChiTiet.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
                if (dgvDoanhSoChiTiet.Columns.Contains("TongThanhToan"))
                {
                    dgvDoanhSoChiTiet.Columns["TongThanhToan"].HeaderText = "Doanh số (VNĐ)";
                    dgvDoanhSoChiTiet.Columns["TongThanhToan"].DefaultCellStyle.Format = "N0";
                    dgvDoanhSoChiTiet.Columns["TongThanhToan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải Doanh số: " + ex.Message); }
        }

        private void btnLocDoanhSo_Click(object sender, EventArgs e)
        {
            LoadDoanhSo();
        }


        // ===================== B. TAB 2: TỒN KHO & RỦI RO =====================

        private void LoadKhoToCombo()
        {
            DataTable dt = kn.ExecuteQuery("SELECT MaKho, TenKho FROM KHO");
            // Thêm tùy chọn "Tất cả Kho"
            DataRow newRow = dt.NewRow();
            newRow["MaKho"] = "ALL";
            newRow["TenKho"] = "Tất cả Kho";
            dt.Rows.InsertAt(newRow, 0);

            cboLocKho.DataSource = dt;
            cboLocKho.DisplayMember = "TenKho";
            cboLocKho.ValueMember = "MaKho";
            cboLocKho.SelectedIndex = 0;
        }

        private void LoadTonKho()
        {
            try
            {
                string maKhoLoc = cboLocKho.SelectedValue?.ToString() ?? "ALL";

                // 1. Tải KPI (Số lượng tồn dưới mức an toàn - Giả định mức an toàn là 500)
                string sqlSLThap = $@"
                    SELECT COUNT(T.MaSP)
                    FROM TONKHO T
                    WHERE T.SoLuongTonKho < 500
                    {(maKhoLoc != "ALL" ? $" AND T.MaKho = '{maKhoLoc}'" : "")}";

                int slTonThap = kn.ExecuteScalar<int>(sqlSLThap);
                lblSLTonThap.Text = $"{slTonThap} Sản phẩm";
                lblSLTonThap.ForeColor = (slTonThap > 0) ? Color.DarkOrange : Color.ForestGreen;

                // 2. Tải KPI (Tổng giá trị tồn kho)
                string sqlTongGiaTri = $@"
                    SELECT ISNULL(SUM(T.SoLuongTonKho * S.DonGia), 0)
                    FROM TONKHO T
                    JOIN SANPHAM S ON T.MaSP = S.MaSP
                    {(maKhoLoc != "ALL" ? $" WHERE T.MaKho = '{maKhoLoc}'" : "")}";

                decimal tongGiaTri = kn.ExecuteScalar<decimal>(sqlTongGiaTri);
                lblTongGiaTriTon.Text = string.Format("{0:N0} VNĐ", tongGiaTri);
                lblTongGiaTriTon.ForeColor = (tongGiaTri > 0) ? Color.Red : Color.Gray;

                // 3. Tải chi tiết tồn kho
                string sqlChiTiet = $@"
                    SELECT 
                        K.TenKho, S.MaSP, S.TenSP, S.DonViTinh, T.SoLuongTonKho, S.DonGia
                    FROM TONKHO T
                    JOIN KHO K ON T.MaKho = K.MaKho
                    JOIN SANPHAM S ON T.MaSP = S.MaSP
                    {(maKhoLoc != "ALL" ? $" WHERE T.MaKho = '{maKhoLoc}'" : "")}
                    ORDER BY T.SoLuongTonKho ASC";

                DataTable dt = kn.ExecuteQuery(sqlChiTiet);
                dgvTonKhoChiTiet.DataSource = dt;

                // Định dạng cột và đặt tên tiêu đề
                if (dgvTonKhoChiTiet.Columns.Contains("TenKho")) dgvTonKhoChiTiet.Columns["TenKho"].HeaderText = "Tên Kho";
                if (dgvTonKhoChiTiet.Columns.Contains("MaSP")) dgvTonKhoChiTiet.Columns["MaSP"].HeaderText = "Mã SP";
                if (dgvTonKhoChiTiet.Columns.Contains("TenSP")) dgvTonKhoChiTiet.Columns["TenSP"].HeaderText = "Tên Sản phẩm";
                if (dgvTonKhoChiTiet.Columns.Contains("DonViTinh")) dgvTonKhoChiTiet.Columns["DonViTinh"].HeaderText = "Đơn vị";
                if (dgvTonKhoChiTiet.Columns.Contains("SoLuongTonKho"))
                {
                    dgvTonKhoChiTiet.Columns["SoLuongTonKho"].HeaderText = "Số lượng tồn";
                    dgvTonKhoChiTiet.Columns["SoLuongTonKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTonKhoChiTiet.Columns["SoLuongTonKho"].DefaultCellStyle.Format = "N0";
                }
                if (dgvTonKhoChiTiet.Columns.Contains("DonGia"))
                {
                    dgvTonKhoChiTiet.Columns["DonGia"].HeaderText = "Giá vốn (VNĐ)";
                    dgvTonKhoChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                    dgvTonKhoChiTiet.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải Tồn kho: " + ex.Message); }
        }

        private void cboLocKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTonKho();
        }


        // ===================== C. TAB 3: CÔNG NỢ & RỦI RO =====================

        // PHƯƠNG THỨC MỚI: Tải danh sách Loại Khách hàng vào ComboBox
        private void LoadLoaiKHToCombo()
        {
            // Lấy danh sách các loại khách hàng duy nhất có trong CSDL
            DataTable dt = kn.ExecuteQuery("SELECT DISTINCT LoaiKH FROM KHACHHANG WHERE LoaiKH IS NOT NULL AND LoaiKH != ''");

            // Thêm tùy chọn "Tất cả Loại KH"
            DataRow newRow = dt.NewRow();
            newRow["LoaiKH"] = "Tất cả Loại KH";
            dt.Rows.InsertAt(newRow, 0);

            cboLocLoaiKH.DataSource = dt;
            cboLocLoaiKH.DisplayMember = "LoaiKH";
            cboLocLoaiKH.ValueMember = "LoaiKH"; // Dùng chính LoaiKH làm ValueMember
            cboLocLoaiKH.SelectedIndex = 0;
        }

        private void LoadCongNo()
        {
            // Lấy giá trị LoaiKH đang được chọn (Nếu là "Tất cả Loại KH" thì là giá trị lọc mặc định)
            string loaiKHLoc = cboLocLoaiKH.SelectedValue?.ToString() ?? "Tất cả Loại KH";
            string condition = "";

            if (loaiKHLoc != "Tất cả Loại KH")
            {
                // Thêm điều kiện lọc vào mệnh đề WHERE. Sử dụng N'{loaiKHLoc}' để xử lý Unicode.
                condition = $" AND LoaiKH = N'{loaiKHLoc}'";
            }

            try
            {
                // 1. Tải KPI (Tổng nợ đang có) - Áp dụng lọc Loại KH
                string sqlTongNo = $@"SELECT ISNULL(SUM(TongNo), 0) 
                                     FROM KHACHHANG 
                                     WHERE TongNo > 0 {condition}";
                decimal tongNo = kn.ExecuteScalar<decimal>(sqlTongNo);
                lblTongNoQuaHan.Text = string.Format("{0:N0} VNĐ", tongNo);
                lblTongNoQuaHan.ForeColor = (tongNo > 0) ? Color.DarkOrange : Color.Gray;

                // 2. Tải KPI (Khách nợ cao/ gần chạm hạn mức - Áp dụng lọc Loại KH
                string sqlNoCao = $@"
                    SELECT COUNT(MaKH) 
                    FROM KHACHHANG 
                    WHERE TongNo > 0 AND HanMucNo > 0 AND (TongNo / HanMucNo) >= 0.8 {condition}";

                int khachNoCao = kn.ExecuteScalar<int>(sqlNoCao);
                lblKhachNoCao.Text = $"{khachNoCao} KH";
                lblKhachNoCao.ForeColor = (khachNoCao > 0) ? Color.Red : Color.ForestGreen;

                // 3. Tải chi tiết Công nợ (có lọc theo Loại KH)
                string sqlChiTiet = $@"
                    SELECT 
                        MaKH, TenKH, LoaiKH, TongNo, HanMucNo, 
                        CAST(ROUND((TongNo / HanMucNo) * 100, 0) AS INT) AS TyLeNo
                    FROM KHACHHANG
                    WHERE TongNo > 0 AND HanMucNo > 0 {condition}
                    ORDER BY TyLeNo DESC";

                DataTable dt = kn.ExecuteQuery(sqlChiTiet);
                dgvCongNoChiTiet.DataSource = dt;

                // Định dạng cột và đặt tên tiêu đề (Giữ nguyên)
                if (dgvCongNoChiTiet.Columns.Contains("MaKH")) dgvCongNoChiTiet.Columns["MaKH"].HeaderText = "Mã KH";
                if (dgvCongNoChiTiet.Columns.Contains("TenKH")) dgvCongNoChiTiet.Columns["TenKH"].HeaderText = "Tên Khách hàng";
                if (dgvCongNoChiTiet.Columns.Contains("LoaiKH")) dgvCongNoChiTiet.Columns["LoaiKH"].HeaderText = "Loại KH";
                if (dgvCongNoChiTiet.Columns.Contains("TongNo"))
                {
                    dgvCongNoChiTiet.Columns["TongNo"].HeaderText = "Tổng nợ (VNĐ)";
                    dgvCongNoChiTiet.Columns["TongNo"].DefaultCellStyle.Format = "N0";
                    dgvCongNoChiTiet.Columns["TongNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvCongNoChiTiet.Columns.Contains("HanMucNo"))
                {
                    dgvCongNoChiTiet.Columns["HanMucNo"].HeaderText = "Hạn mức (VNĐ)";
                    dgvCongNoChiTiet.Columns["HanMucNo"].DefaultCellStyle.Format = "N0";
                    dgvCongNoChiTiet.Columns["HanMucNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvCongNoChiTiet.Columns.Contains("TyLeNo"))
                {
                    dgvCongNoChiTiet.Columns["TyLeNo"].HeaderText = "Tỷ lệ nợ (%)";
                    dgvCongNoChiTiet.Columns["TyLeNo"].DefaultCellStyle.Format = "N0";
                    dgvCongNoChiTiet.Columns["TyLeNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải Công nợ: " + ex.Message); }
        }

        private void btnLocCongNo_Click(object sender, EventArgs e)
        {
            // Nút LỌC chỉ cần gọi LoadCongNo() để cập nhật lại dữ liệu theo ComboBox đã chọn
            LoadCongNo();
        }

        private void cboLocLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tự động gọi LoadCongNo() khi giá trị ComboBox thay đổi
            LoadCongNo();
        }
        private void pnlKPIsTonKho_Paint(object sender, PaintEventArgs e)
        {
            // Đây là phương thức xử lý sự kiện Paint cho panel, không cần xử lý logic.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Thông báo cho người dùng trước khi mở báo cáo (tùy chọn)
                // MessageBox.Show("Đang khởi tạo báo cáo tồn kho Acecook...", "Hệ thống DSS");

                // Khởi tạo Form báo cáo tồn kho mà bạn đã tạo trước đó
                BaoCaoTonKho frmReport = new BaoCaoTonKho();

                // Hiển thị Form theo dạng Dialog (đè lên form hiện tại)
                frmReport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở báo cáo tồn kho: " + ex.Message, "Lỗi hệ thống");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = kn.getTonKho(); // Lấy dữ liệu từ lớp kết nối của bạn
                if (dt == null || dt.Rows.Count == 0) return;

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "TonKho_Acecook.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "TonKho");
                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất Excel thành công!");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}