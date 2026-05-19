using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing; // Bổ sung Drawing để sử dụng Color/Font

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class Banhang : Form
    {
        // --- KHAI BÁO KẾT NỐI ---
        Ketnoi kn = new Ketnoi();
        DataTable dtGioHang;
        string _maNV = "NV01"; // Giả định nhân viên đang đăng nhập là NV01

        public Banhang()
        {
            InitializeComponent();

            // Đăng ký sự kiện tính tiền ngay khi nhập xong số lượng
            dgvGioHang.CellEndEdit += DgvGioHang_CellEndEdit;

            // --- SỬA LỖI ĐĂNG KÝ SỰ KIỆN ---
            // Đăng ký sự kiện cho nút Thêm vào giỏ
            btnThem.Click += new EventHandler(btnThem_Click);
            // Đăng ký sự kiện cho nút Xóa khỏi giỏ
            btnXoa.Click += new EventHandler(btnXoa_Click);
            // Đã có hàm btnTao_Click nên không cần đăng ký lại trong constructor
            // ------------------------------------
        }

        private void DgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BindingContext[dtGioHang].EndCurrentEdit();
            TinhTongTien();
        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            TaoMaDonHangTuDong();
            LoadKhachHang();
            LoadSanPham();
            KhoiTaoGioHang();
        }

        // --- 1. CÁC HÀM HỖ TRỢ LOAD DỮ LIỆU ---
        private void TaoMaDonHangTuDong()
        {
            Random rd = new Random();
            int soNgauNhien = rd.Next(100, 999);
            txtMaDH.Text = "DH" + soNgauNhien;
        }

        private void LoadKhachHang()
        {
            try
            {
                string sql = "SELECT MaKH, TenKH FROM KHACHHANG";
                DataTable dt = kn.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboKhachHang.DataSource = dt;
                    cboKhachHang.DisplayMember = "TenKH";
                    cboKhachHang.ValueMember = "MaKH";
                    cboKhachHang.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message);
            }
        }

        private void LoadSanPham()
        {
            try
            {
                string sql = "SELECT MaSP, TenSP, DonViTinh, DonGia FROM SANPHAM";
                DataTable dt = kn.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvSanPham.DataSource = dt;

                    // --- ĐỊNH DẠNG: ĐỎ VÀ IN ĐẬM CHO DS SẢN PHẨM ---
                    System.Windows.Forms.DataGridViewCellStyle boldRedStyleSP = new System.Windows.Forms.DataGridViewCellStyle();
                    boldRedStyleSP.ForeColor = System.Drawing.Color.Firebrick;
                    boldRedStyleSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
                    dgvSanPham.DefaultCellStyle = boldRedStyleSP;
                    // --------------------------------------------------------

                    if (dgvSanPham.Columns["DonGia"] != null)
                        dgvSanPham.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void KhoiTaoGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaSP");
            dtGioHang.Columns.Add("TenSP");
            dtGioHang.Columns.Add("DonViTinh");
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");

            dgvGioHang.DataSource = dtGioHang;

            // --- ĐỊNH DẠNG: ĐỎ VÀ IN ĐẬM CHO GIỎ HÀNG ---
            System.Windows.Forms.DataGridViewCellStyle boldRedStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldRedStyle.ForeColor = System.Drawing.Color.Firebrick;
            boldRedStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgvGioHang.DefaultCellStyle = boldRedStyle;
            // -----------------------------------------------------

            if (dgvGioHang.Columns["DonGia"] != null)
                dgvGioHang.Columns["DonGia"].DefaultCellStyle.Format = "N0";

            if (dgvGioHang.Columns["ThanhTien"] != null)
                dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }

        // --- 2. XỬ LÝ TÌM KIẾM SẢN PHẨM ---
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvSanPham.DataSource;
                if (dt != null)
                {
                    string keyword = txtTimKiem.Text.Trim();
                    if (string.IsNullOrEmpty(keyword))
                        dt.DefaultView.RowFilter = "";
                    else
                        dt.DefaultView.RowFilter = string.Format("TenSP LIKE '%{0}%' OR MaSP LIKE '%{0}%'", keyword);
                }
            }
            catch { }
        }

        // --- 3. XỬ LÝ THÊM VÀO GIỎ ---
        private void ThemVaoGio(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvSanPham.Rows.Count || dgvSanPham.Rows[rowIndex].Cells["MaSP"].Value == null) return;

            string maSP = dgvSanPham.Rows[rowIndex].Cells["MaSP"].Value.ToString();
            string tenSP = dgvSanPham.Rows[rowIndex].Cells["TenSP"].Value.ToString();
            string dvt = dgvSanPham.Rows[rowIndex].Cells["DonViTinh"].Value.ToString();
            decimal donGia = 0;

            if (dgvSanPham.Rows[rowIndex].Cells["DonGia"].Value != DBNull.Value)
                donGia = Convert.ToDecimal(dgvSanPham.Rows[rowIndex].Cells["DonGia"].Value);

            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row["MaSP"].ToString() == maSP)
                {
                    row["SoLuong"] = (int)row["SoLuong"] + 1;
                    TinhTongTien();
                    return;
                }
            }

            dtGioHang.Rows.Add(maSP, tenSP, dvt, 1, donGia);
            TinhTongTien();
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ThemVaoGio(e.RowIndex);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                int index = dgvSanPham.SelectedRows[0].Index;
                ThemVaoGio(index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm bên trái trước!", "Thông báo");
            }
        }

        // --- 4. XỬ LÝ XÓA KHỎI GIỎ ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count > 0)
            {
                DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi giỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgvGioHang.SelectedRows)
                    {
                        if (!item.IsNewRow && item.DataBoundItem != null)
                        {
                            DataRowView rowView = (DataRowView)item.DataBoundItem;
                            rowView.Row.Delete();
                        }
                    }
                    dtGioHang.AcceptChanges();
                    TinhTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa bên giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- 5. TÍNH TOÁN TỔNG TIỀN ---
        // Sửa lỗi: Đã sử dụng Compute để tính tổng tiền an toàn hơn
        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện này thường không được dùng nếu đã dùng CellEndEdit, nhưng giữ lại nếu cần thiết
            // TinhTongTien(); 
        }

        private void TinhTongTien()
        {
            decimal tong = 0;

            // Sử dụng Compute để tính tổng
            object sumResult = dtGioHang.Compute("SUM(ThanhTien)", "");
            if (sumResult != DBNull.Value)
            {
                tong = Convert.ToDecimal(sumResult);
            }

            lblThanhTien.Text = tong.ToString("N0") + " VNĐ";
        }

        // --- 6. XỬ LÝ NÚT TẠO ĐƠN HÀNG (LƯU VÀO CSDL) ---
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhachHang.Focus();
                return;
            }

            using (SqlConnection conn = kn.GetConnect())
            {
                // Mở kết nối (đã loại bỏ kiểm tra conn.State thừa)
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. INSERT DONHANG
                    string sqlDH = @"INSERT INTO DONHANG (MaDH, MaKH, MaNV, NgayDat, NgayGiaoHang, TrangThai) 
                                     VALUES (@Ma, @Kh, @Nv, @NgayDat, @NgayGiao, N'Chờ duyệt')"; // Đổi trạng thái sang 'Chờ duyệt'

                    SqlCommand cmd = new SqlCommand(sqlDH, conn, tran);
                    cmd.Parameters.AddWithValue("@Ma", txtMaDH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kh", cboKhachHang.SelectedValue);
                    cmd.Parameters.AddWithValue("@Nv", _maNV);
                    cmd.Parameters.AddWithValue("@NgayDat", DateTime.Now);
                    cmd.Parameters.AddWithValue("@NgayGiao", dtpNgayGiao.Value);

                    cmd.ExecuteNonQuery();

                    // 2. INSERT CHITIETDONHANG
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        string sqlCT = @"INSERT INTO CHITIETDONHANG (MaDH, MaSP, SoLuong, DonGia, ChietKhau) 
                                         VALUES (@Ma, @Sp, @Sl, @Gia, 0)"; // Giả định chiết khấu là 0

                        SqlCommand cmd2 = new SqlCommand(sqlCT, conn, tran);
                        cmd2.Parameters.AddWithValue("@Ma", txtMaDH.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Sp", row["MaSP"]);
                        cmd2.Parameters.AddWithValue("@Sl", row["SoLuong"]);
                        cmd2.Parameters.AddWithValue("@Gia", row["DonGia"]);

                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Tạo đơn hàng THÀNH CÔNG!\nMã đơn: " + txtMaDH.Text + "\nTrạng thái: Chờ duyệt",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form sau khi lưu thành công
                    dtGioHang.Clear();
                    lblThanhTien.Text = "0 VNĐ";
                    TaoMaDonHangTuDong();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi tạo đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // Gọi hàm lưu đơn hàng chính
            btnLuu_Click(sender, e);
        }
    }
}