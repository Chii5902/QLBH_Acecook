using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class DonHang : Form
    {
        Ketnoi kn = new Ketnoi();
        // Biến lưu trữ để tính toán
        decimal tongTienDonHang = 0;
        decimal congNoHienTai = 0;
        decimal hanMucNo = 0;

        public DonHang()
        {
            InitializeComponent();
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }

        // 1. LOAD DANH SÁCH ĐƠN HÀNG
        private void LoadDanhSachDonHang(string keyword = "")
        {
            try
            {
                string sql = "SELECT MaDH, NgayDat, TrangThai FROM DONHANG WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword) && keyword != "Nhập mã đơn...")
                {
                    sql += $" AND MaDH LIKE '%{keyword}%'";
                }
                sql += " ORDER BY NgayDat DESC";

                DataTable dt = kn.ExecuteQuery(sql);

                // Tạo cột hiển thị đẹp: DH123 (Chờ duyệt)
                dt.Columns.Add("HienThi", typeof(string), "MaDH + ' (' + TrangThai + ')'");

                lstDonHang.DataSource = dt;
                lstDonHang.DisplayMember = "HienThi";
                lstDonHang.ValueMember = "MaDH";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách: " + ex.Message); }
        }

        // 2. SỰ KIỆN CHỌN ĐƠN HÀNG (QUAN TRỌNG NHẤT)
        private void lstDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDonHang.SelectedValue == null) return;

            // Lấy Mã ĐH từ giá trị đang chọn
            // Lưu ý: Cần convert sang string cẩn thận vì SelectedValue có thể là DataRowView lúc mới load
            string maDH = "";
            if (lstDonHang.SelectedValue is DataRowView)
                maDH = ((DataRowView)lstDonHang.SelectedValue)["MaDH"].ToString();
            else
                maDH = lstDonHang.SelectedValue.ToString();

            LoadThongTinChiTiet(maDH);
            LoadGridSanPham(maDH); // <--- HÀM LOAD CHI TIẾT SẢN PHẨM
        }

        private void LoadThongTinChiTiet(string maDH)
        {
            try
            {
                // Lấy thông tin đơn + tài chính khách
                string sql = $@"
                    SELECT d.MaDH, d.NgayDat, d.TrangThai,
                           k.TenKH, k.TongNo, k.HanMucNo,
                           (SELECT SUM(c.SoLuong * c.DonGia) FROM CHITIETDONHANG c WHERE c.MaDH = d.MaDH) as TongTien
                    FROM DONHANG d
                    JOIN KHACHHANG k ON d.MaKH = k.MaKH
                    WHERE d.MaDH = '{maDH}'";

                DataTable dt = kn.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    txtMaDH.Text = dr["MaDH"].ToString();
                    txtNgayDat.Text = Convert.ToDateTime(dr["NgayDat"]).ToString("dd/MM/yyyy HH:mm");
                    txtKhachHang.Text = dr["TenKH"].ToString();
                    txtTrangThai.Text = dr["TrangThai"].ToString();

                    tongTienDonHang = dr["TongTien"] != DBNull.Value ? Convert.ToDecimal(dr["TongTien"]) : 0;
                    congNoHienTai = Convert.ToDecimal(dr["TongNo"]);
                    hanMucNo = Convert.ToDecimal(dr["HanMucNo"]);

                    txtTongTien.Text = string.Format("{0:N0} VNĐ", tongTienDonHang);
                    txtNoHienTai.Text = string.Format("{0:N0} VNĐ", congNoHienTai);
                    txtHanMuc.Text = string.Format("{0:N0} VNĐ", hanMucNo);

                    XuLyTrangThai(txtTrangThai.Text);
                }
            }
            catch { }
        }

        // --- HÀM LOAD GRID CHI TIẾT SẢN PHẨM (BẠN CẦN CÁI NÀY) ---
        private void LoadGridSanPham(string maDH)
        {
            try
            {
                // Join bảng ChiTiet với SanPham để lấy tên SP
                string sql = $@"
                    SELECT s.MaSP, s.TenSP, s.DonViTinh, c.SoLuong, c.DonGia, (c.SoLuong * c.DonGia) AS ThanhTien
                    FROM CHITIETDONHANG c
                    JOIN SANPHAM s ON c.MaSP = s.MaSP
                    WHERE c.MaDH = '{maDH}'";

                DataTable dt = kn.ExecuteQuery(sql);
                dgvChiTietDonHang.DataSource = dt;

                // Format tiền tệ cho đẹp
                if (dgvChiTietDonHang.Columns["DonGia"] != null)
                    dgvChiTietDonHang.Columns["DonGia"].DefaultCellStyle.Format = "N0";

                if (dgvChiTietDonHang.Columns["ThanhTien"] != null)
                    dgvChiTietDonHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
            catch { }
        }

        private void XuLyTrangThai(string trangThai)
        {
            trangThai = trangThai.Trim();

            if (trangThai == "Chờ duyệt" || trangThai == "Đang xử lý")
            {
                txtTrangThai.ForeColor = Color.Blue;
                btnDuyet.Enabled = true;
                btnHuy.Enabled = true;
                btnDuyet.BackColor = Color.Firebrick;
                btnHuy.BackColor = Color.Gray;
            }
            else
            {
                if (trangThai == "Đã duyệt") txtTrangThai.ForeColor = Color.Green;
                else txtTrangThai.ForeColor = Color.Red;

                btnDuyet.Enabled = false;
                btnHuy.Enabled = false;
                btnDuyet.BackColor = Color.LightGray;
                btnHuy.BackColor = Color.LightGray;
            }
        }

        // --- CÁC NÚT CHỨC NĂNG ---
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachDonHang(txtTimKiem.Text.Trim());
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Banhang f = new Banhang();
            f.ShowDialog();
            LoadDanhSachDonHang(); // Refresh list sau khi tạo xong
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            // Logic kiểm tra nợ
            decimal noDuKien = congNoHienTai + tongTienDonHang;
            if (noDuKien > hanMucNo)
            {
                if (MessageBox.Show($"CẢNH BÁO: Vượt hạn mức!\nNợ mới: {noDuKien:N0}\nHạn mức: {hanMucNo:N0}\nDuyệt ngoại lệ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            else
            {
                if (MessageBox.Show("Duyệt đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }

            CapNhatTrangThaiDonHang("Đã duyệt");
            CapNhatCongNoKhachHang(tongTienDonHang);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CapNhatTrangThaiDonHang("Đã hủy");
            }
        }

        private void CapNhatTrangThaiDonHang(string tt)
        {
            try
            {
                string sql = $"UPDATE DONHANG SET TrangThai = N'{tt}' WHERE MaDH = '{txtMaDH.Text}'";
                if (kn.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("Thành công!");
                    LoadDanhSachDonHang(); // Refresh list bên trái để cập nhật trạng thái mới
                    // Chọn lại đúng dòng vừa xử lý để hiển thị chi tiết cập nhật
                    lstDonHang.SelectedValue = txtMaDH.Text;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void CapNhatCongNoKhachHang(decimal soTien)
        {
            try
            {

                string sql = $@"UPDATE KHACHHANG 
                                SET TongNo = TongNo + {soTien} 
                                FROM KHACHHANG k 
                                JOIN DONHANG d ON k.MaKH = d.MaKH 
                                WHERE d.MaDH = '{txtMaDH.Text}'";
                kn.ExecuteNonQuery(sql);
            }
            catch { }
        }
    }
}

