using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Globalization; // Cần thiết cho việc Parse tiền tệ

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class HDon : Form
    {
        // Giả định lớp Ketnoi của bạn chứa logic kết nối CSDL và ExecuteQuery/ExecuteNonQuery
        Ketnoi kn = new Ketnoi();

        private string _maHDHienTai;
        private BindingSource bsMasterOrders = new BindingSource(); // BindingSource cho danh sách đơn hàng chờ

        // Thuế GTGT 10%
        private const decimal VAT_RATE = 0.10m;

        // Constructor mặc định (REQUIRED - Cho phép Debug/Design)
        public HDon()
        {
            InitializeComponent();
            // Không nên gán _maHDHienTai cứng, để nó tự động tạo Mã HD mới khi load
            _maHDHienTai = string.Empty;
        }

        // Constructor chuẩn (Nhận Mã HD từ form gọi)
        public HDon(string maHD) : this()
        {
            // Constructor này sẽ được dùng khi xem hóa đơn đã tồn tại, nhưng hiện tại ta tập trung vào lập mới.
            _maHDHienTai = maHD;
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            // Tải danh sách đơn hàng chờ lập hóa đơn
            LoadMasterOrders();

            // Nếu có đơn hàng, tự động chọn dòng đầu tiên và load chi tiết
            if (bsMasterOrders.Count > 0)
            {
                // Gọi hàm tự động load chi tiết tạo hóa đơn
                DataRowView firstRow = (DataRowView)bsMasterOrders.Current;
                LoadChiTietTaoHoaDon((string)firstRow["MaDH"]);
            }
            else
            {
                // Không có đơn hàng chờ, hiển thị Mã HD mới và xóa các trường khác
                txtMaHD.Text = GenerateNewMaHD();
                ClearMasterDetails();
            }

            // Thiết lập sự kiện điều hướng
            SetNavigationEvents();
        }

        // --- A. LOAD DANH SÁCH ĐƠN HÀNG CHỜ LẬP HÓA ĐƠN (MASTER) ---

        private void LoadMasterOrders()
        {
            try
            {
                // Sử dụng VIEW V_DonHangChoLapHoaDon đã tạo để lấy danh sách chính xác
                string sql = @"
                    SELECT MaDH, NgayDat, TenKH, TongTienHang, MaKH 
                    FROM V_DonHangChoLapHoaDon 
                    ORDER BY NgayDat ASC";

                DataTable dt = kn.ExecuteQuery(sql); // Giả định kn.ExecuteQuery trả về DataTable

                bsMasterOrders.DataSource = dt;
                dgvMasterOrders.DataSource = bsMasterOrders;

                // Định dạng Grid
                if (dgvMasterOrders.Columns.Contains("MaDH"))
                    dgvMasterOrders.Columns["MaDH"].HeaderText = "Mã ĐH";
                if (dgvMasterOrders.Columns.Contains("TenKH"))
                    dgvMasterOrders.Columns["TenKH"].HeaderText = "Khách hàng";
                if (dgvMasterOrders.Columns.Contains("NgayDat"))
                    dgvMasterOrders.Columns["NgayDat"].HeaderText = "Ngày Đặt";
                if (dgvMasterOrders.Columns.Contains("TongTienHang"))
                {
                    dgvMasterOrders.Columns["TongTienHang"].HeaderText = "Tổng Tiền Hàng (Sau CK)";
                    // Dùng định dạng tiền tệ
                    dgvMasterOrders.Columns["TongTienHang"].DefaultCellStyle.Format = "N0";
                }
                if (dgvMasterOrders.Columns.Contains("MaKH"))
                    dgvMasterOrders.Columns["MaKH"].Visible = false; // Ẩn MaKH

                // Cần làm sạch chi tiết nếu danh sách rỗng
                if (dt.Rows.Count == 0)
                {
                    ClearMasterDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đơn chờ: " + ex.Message, "Lỗi SQL");
            }
        }

        private void dgvMasterOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Chuyển vị trí BindingSource
                bsMasterOrders.Position = e.RowIndex;

                // Lấy MaDH từ dòng đang chọn
                string maDH = dgvMasterOrders.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                LoadChiTietTaoHoaDon(maDH);
            }
        }

        // --- B. LOAD DỮ LIỆU ĐỂ TẠO HÓA ĐƠN MỚI ---

        private void LoadChiTietTaoHoaDon(string maDH)
        {
            try
            {
                // Lấy thông tin Master từ BindingSource (đã có TenKH, MaDH, TongTienHang, MaKH)
                DataRowView currentRow = (DataRowView)bsMasterOrders.Current;

                // 1. Gán dữ liệu vào Master GroupBox
                txtMaDH.Text = (string)currentRow["MaDH"];
                txtTenKH.Text = (string)currentRow["TenKH"];
                txtNgayBan.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // Ngày tạo hóa đơn là ngày hiện tại
                txtPhuongThucTT.Text = "Chuyển khoản"; // Giả định phương thức TT
                txtMaHD.Text = GenerateNewMaHD(); // Gợi ý Mã HD mới

                // 2. Tải chi tiết đơn hàng (Grid) - Sử dụng VIEW V_ChiTietDonHang
                string sqlDetail = $@"
                    SELECT MaSP, TenSP, SoLuong, DonGia, ChietKhau, ThanhTien
                    FROM V_ChiTietDonHang 
                    WHERE MaDH = '{maDH}'";

                DataTable dtDetail = kn.ExecuteQuery(sqlDetail);
                dgvChiTietHD.DataSource = dtDetail;

                // 3. Tính toán và hiển thị Tóm tắt tài chính (Subtotal, Tax, Total)
                CalculateSummary(dtDetail);

                // Định dạng Grid
                if (dgvChiTietHD.Columns.Contains("MaSP"))
                    dgvChiTietHD.Columns["MaSP"].Visible = false; // Ẩn cột Mã SP

                if (dgvChiTietHD.Columns.Contains("DonGia"))
                {
                    dgvChiTietHD.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                    dgvChiTietHD.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                    // Giả định ChietKhau là số float 0.05 -> hiển thị 5%
                    dgvChiTietHD.Columns["ChietKhau"].DefaultCellStyle.Format = "P1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message, "Lỗi SQL");
            }
        }

        private void CalculateSummary(DataTable dtDetail)
        {
            decimal tongTienHang = 0m;

            if (dtDetail != null && dtDetail.Rows.Count > 0)
            {
                // [FIX CS0266] Ép kiểu rõ ràng sang decimal (dùng Convert.ToDecimal)
                tongTienHang = Convert.ToDecimal(dtDetail.AsEnumerable()
                                        .Sum(row => row.Field<double>("ThanhTien")));
            }

            decimal thue = tongTienHang * VAT_RATE; // Thuế VAT 10%
            decimal tongThanhToan = tongTienHang + thue;

            // Đổ dữ liệu vào Footer Summary (sử dụng CultureInfo cho đúng định dạng Việt Nam)
            lblTongTienHangValue.Text = tongTienHang.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            lblThueValue.Text = thue.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            lblTongThanhToanValue.Text = tongThanhToan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
        }

        // --- C. XỬ LÝ NÚT (ACTION & NAVIGATION) ---

        private void btnLuuVaPhatHanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần lập hóa đơn.", "Lỗi");
                return;
            }

            // 1. Lấy các giá trị đã tính toán từ Labels và TextBoxes
            string maHD = txtMaHD.Text;
            string maDH = txtMaDH.Text;
            string phuongThucTT = txtPhuongThucTT.Text;

            // Dùng hàm ParseCurrency để chuyển đổi từ Label.Text về Decimal
            decimal tongTienHang = ParseCurrency(lblTongTienHangValue.Text);
            decimal thue = ParseCurrency(lblThueValue.Text);
            decimal tongThanhToan = ParseCurrency(lblTongThanhToanValue.Text);

            // Lấy chi tiết sản phẩm từ DataGridView
            DataTable dtChiTiet = (DataTable)dgvChiTietHD.DataSource;

            if (dtChiTiet == null || dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có chi tiết sản phẩm để lập hóa đơn.", "Lỗi");
                return;
            }

            // Bắt đầu Transaction (nên dùng Transaction để đảm bảo tính toàn vẹn)
            // Tuy nhiên, trong mô hình đơn giản, ta dùng NonQuery và chấp nhận rủi ro.

            try
            {
                // Thao tác 1: INSERT HOADON (Master)
                string sqlHD = @"INSERT INTO HOADON (MaHD, MaDH, NgayBan, TongTienHang, Thue, TongThanhToan, PhuongThucThanhToan)
                                 VALUES (@MaHD, @MaDH, GETDATE(), @TongHang, @Thue, @TongTT, @PTTT)";

                SqlCommand cmdHD = new SqlCommand(sqlHD);
                cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                cmdHD.Parameters.AddWithValue("@MaDH", maDH);
                cmdHD.Parameters.AddWithValue("@TongHang", tongTienHang);
                cmdHD.Parameters.AddWithValue("@Thue", thue);
                cmdHD.Parameters.AddWithValue("@TongTT", tongThanhToan);
                cmdHD.Parameters.AddWithValue("@PTTT", phuongThucTT);

                kn.ExecuteNonQuery(cmdHD); // Giả định kn.ExecuteNonQuery nhận SqlCommand

                // Thao tác 2: INSERT CHITIETHOADON (Detail)
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    // Lấy Đơn giá gốc (từ bảng ChiTietDonHang sang ChiTietHoaDon)
                    double donGiaGoc = Convert.ToDouble(row["DonGia"]);

                    string sqlCTHD = @"INSERT INTO CHITIETHOADON (MaHD, MaSP, SoLuong, DonGia)
                                       VALUES (@MaHD, @MaSP, @SL, @DG)";

                    SqlCommand cmdCTHD = new SqlCommand(sqlCTHD);
                    cmdCTHD.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCTHD.Parameters.AddWithValue("@MaSP", maSP);
                    cmdCTHD.Parameters.AddWithValue("@SL", soLuong);
                    cmdCTHD.Parameters.AddWithValue("@DG", donGiaGoc);

                    kn.ExecuteNonQuery(cmdCTHD); // Giả định kn.ExecuteNonQuery nhận SqlCommand
                }

                MessageBox.Show($"Lập Hóa đơn {maHD} thành công! Đơn hàng {maDH} đã được lập hóa đơn.", "Phát hành", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại danh sách Master List (Đơn hàng vừa lập hóa đơn sẽ biến mất)
                LoadMasterOrders();

                // Sau khi load lại, tự động chọn đơn hàng đầu tiên (nếu còn)
                if (bsMasterOrders.Count > 0)
                {
                    DataRowView firstRow = (DataRowView)bsMasterOrders.Current;
                    LoadChiTietTaoHoaDon((string)firstRow["MaDH"]);
                }
                else
                {
                    ClearMasterDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập Hóa đơn: " + ex.Message, "Lỗi SQL");
            }
            Report frmReport = new Report();
            frmReport.MaHD_Selected = txtMaHD.Text; // Truyền mã vừa tạo sang
            frmReport.ShowDialog();
        }

        // Cần thêm hàm này vì hàm btnLuuVaPhatHanh_Click của bạn sử dụng SqlCommand
        // Giả định bạn đã có hàm này trong lớp Ketnoi, nếu không, phải thay thế bằng
        // kn.ExecuteNonQuery(string sql) như trong DataHelper.
        // private void ExecuteNonQuery(SqlCommand cmd) { ... } 

        // --- D. HÀM HỖ TRỢ VÀ ĐIỀU HƯỚNG ---

        private void SetNavigationEvents()
        {
            // BindingSource đã tự động xử lý khi nút click, chỉ cần đảm bảo hàm LoadChiTietTaoHoaDon được gọi.
            // bsMasterOrders.PositionChanged đã được xử lý thông qua dgvMasterOrders_CellClick (khi người dùng click) 
            // và NavigateGrid.
        }

        private void ClearMasterDetails()
        {
            txtMaHD.Text = GenerateNewMaHD();
            txtMaDH.Clear();
            txtTenKH.Clear();
            txtNgayBan.Clear();
            txtPhuongThucTT.Clear();
            lblTongTienHangValue.Text = "0 VNĐ";
            lblThueValue.Text = "0 VNĐ";
            lblTongThanhToanValue.Text = "0 VNĐ";
            dgvChiTietHD.DataSource = null;
        }

        private decimal ParseCurrency(string currencyString)
        {
            // Loại bỏ " VNĐ" và sử dụng CultureInfo của Việt Nam để xử lý dấu chấm/phẩy
            currencyString = currencyString.Replace(" VNĐ", "").Trim();
            // Nếu dùng định dạng N0 (ví dụ: 12.345.678) thì phải dùng NumberStyles.Currency hoặc NumberStyles.AllowThousands
            decimal.TryParse(currencyString, NumberStyles.AllowThousands, CultureInfo.GetCultureInfo("vi-VN"), out decimal result);
            return result;
        }

        private string GenerateNewMaHD()
        {
            // Logic tạo mã HD đơn giản (cần cải thiện bằng cách truy vấn Max(MaHD) trong thực tế)
            return "HD" + (new Random().Next(100, 9999)).ToString("D4");
        }


        // --- E. CÁC HÀM ĐIỀU HƯỚNG (GIỮ NGUYÊN) ---
        private void NavigateGrid(int direction)
        {
            if (bsMasterOrders.Current != null)
            {
                switch (direction)
                {
                    case 0: bsMasterOrders.MoveFirst(); break;
                    case 1: bsMasterOrders.MovePrevious(); break;
                    case 2: bsMasterOrders.MoveNext(); break;
                    case 3: bsMasterOrders.MoveLast(); break;
                }
            }
            // Gọi lại hàm load chi tiết tạo hóa đơn
            if (bsMasterOrders.Current != null)
            {
                DataRowView currentRow = (DataRowView)bsMasterOrders.Current;
                LoadChiTietTaoHoaDon((string)currentRow["MaDH"]);
            }
        }
        private void btnDau_Click(object sender, EventArgs e) { NavigateGrid(0); }
        private void btnTruoc_Click(object sender, EventArgs e) { NavigateGrid(1); }
        private void btnSau_Click(object sender, EventArgs e) { NavigateGrid(2); }
        private void btnCuoi_Click(object sender, EventArgs e) { NavigateGrid(3); }
        private void LoadChiTietHoaDon(string maHD) { /* Dành cho xem HĐ cũ - Tạm thời bỏ qua */ }
        private void pnlNavigation_Paint(object sender, PaintEventArgs e) { /* Giữ nguyên */ }
    }
}