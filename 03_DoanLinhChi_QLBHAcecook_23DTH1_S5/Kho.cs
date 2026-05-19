using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class Kho : Form
    {
        // Khởi tạo lớp kết nối (KHÔNG SỬA ĐỔI)
        Ketnoi kn = new Ketnoi();

        public Kho()
        {
            InitializeComponent();
            // Đăng ký các sự kiện
            this.Load += new EventHandler(Kho_Load);
            dgvTonKho.CellClick += new DataGridViewCellEventHandler(dgvTonKho_CellClick);
            btnTim.Click += new EventHandler(btnTim_Click);
            btnHienThi.Click += new EventHandler(btnHienThi_Click);
            btnLuuDieuChinh.Click += new EventHandler(btnLuuDieuChinh_Click);
        }

        // --- 1. LOAD FORM & DỮ LIỆU ---
        private void Kho_Load(object sender, EventArgs e)
        {
            LoadDSTonKho();
            ResetPanelDieuChinh();
        }

        private void LoadDSTonKho(string keyword = "")
        {
            try
            {
                // SỬA SQL: Dùng ISNULL(t.SoLuongTonKho, 0) AS SoLuongTon
                // Vì bạn không muốn sửa Ketnoi.cs, ta dùng phiên bản ExecuteQuery(string query) không tham số.
                string sql = @"
                    SELECT 
                        s.MaSP, 
                        s.TenSP, 
                        s.DonViTinh, 
                        ISNULL(t.SoLuongTonKho, 0) AS SoLuongTon,
                        s.HanSuDungNgay,
                        s.DonGia
                    FROM SANPHAM s
                    LEFT JOIN TONKHO t ON s.MaSP = t.MaSP";

                if (!string.IsNullOrEmpty(keyword))
                {
                    sql += " WHERE s.MaSP LIKE N'%" + keyword + "%' OR s.TenSP LIKE N'%" + keyword + "%'";
                }

                // GỌI PHƯƠNG THỨC ExecuteQuery KHÔNG THAM SỐ CŨ (Đã có sẵn trong Ketnoi.cs)
                DataTable dt = kn.ExecuteQuery(sql);
                dgvTonKho.DataSource = dt;

                // --- BỔ SUNG ĐỊNH DẠNG DỮ LIỆU: FIREBRICK VÀ IN ĐẬM ---
                System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
                // Đặt màu Firebrick
                boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
                // Đặt Font Segoe UI, In đậm (Bold)
                boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);

                // Áp dụng style cho toàn bộ dữ liệu (DefaultCellStyle)
                dgvTonKho.DefaultCellStyle = boldFirebrickStyle;
                // --------------------------------------------------------

                // Đặt tên cột hiển thị
                if (dgvTonKho.Columns["MaSP"] != null) dgvTonKho.Columns["MaSP"].HeaderText = "Mã SP";
                if (dgvTonKho.Columns["TenSP"] != null) dgvTonKho.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                if (dgvTonKho.Columns["DonViTinh"] != null) dgvTonKho.Columns["DonViTinh"].HeaderText = "ĐVT";
                if (dgvTonKho.Columns["SoLuongTon"] != null) dgvTonKho.Columns["SoLuongTon"].HeaderText = "Tồn Kho";
                if (dgvTonKho.Columns["HanSuDungNgay"] != null) dgvTonKho.Columns["HanSuDungNgay"].HeaderText = "HSD (Ngày)";
                if (dgvTonKho.Columns["DonGia"] != null) dgvTonKho.Columns["DonGia"].HeaderText = "Giá Bán";

                // Định dạng cột số
                if (dgvTonKho.Columns["SoLuongTon"] != null) dgvTonKho.Columns["SoLuongTon"].DefaultCellStyle.Format = "N0";
                if (dgvTonKho.Columns["DonGia"] != null) dgvTonKho.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu kho: " + ex.Message);
            }
        }

        // --- 2. SỰ KIỆN CHỌN DÒNG TRÊN LƯỚI ---
        private void dgvTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTonKho.Rows[e.RowIndex];

                // Đổ dữ liệu vào Panel bên phải
                txtMaSP_DieuChinh.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP_DieuChinh.Text = row.Cells["TenSP"].Value.ToString();

                // Xử lý hiển thị tồn hiện tại (tránh lỗi null)
                string tonHienTai = row.Cells["SoLuongTon"].Value.ToString();
                txtTonHienTai.Text = string.IsNullOrEmpty(tonHienTai) ? "0" : tonHienTai;

                // Reset ô nhập liệu
                // Kiểm tra giới hạn Maximum trước khi gán giá trị
                decimal tonDecimal = Convert.ToDecimal(txtTonHienTai.Text);
                if (tonDecimal > numSoLuongMoi.Maximum)
                {
                    // Nếu giá trị lớn hơn Maximum, đặt Maximum thành giá trị đó (hoặc một số lớn hơn)
                    numSoLuongMoi.Maximum = tonDecimal + 1000;
                }
                numSoLuongMoi.Value = tonDecimal; // Gợi ý số lượng cũ

                txtLyDo.Text = "";
                txtLyDo.Focus();
            }
        }

        // --- 3. SỰ KIỆN LƯU ĐIỀU CHỈNH ---
        private void btnLuuDieuChinh_Click(object sender, EventArgs e)
        {
            // Validate (Kiểm tra)
            if (string.IsNullOrEmpty(txtMaSP_DieuChinh.Text))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do điều chỉnh kho (VD: Kiểm kê, Hàng hư hỏng...)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDo.Focus();
                return;
            }

            string maSP = txtMaSP_DieuChinh.Text;
            int soLuongMoi = (int)numSoLuongMoi.Value;
            int soLuongCu = int.Parse(txtTonHienTai.Text);

            if (soLuongMoi == soLuongCu)
            {
                MessageBox.Show("Số lượng mới giống số lượng cũ. Không cần điều chỉnh.", "Thông báo");
                return;
            }

            // Xác nhận
            DialogResult hoi = MessageBox.Show($"Bạn chắc chắn muốn điều chỉnh tồn kho cho sản phẩm '{txtTenSP_DieuChinh.Text}'?\n\nTồn cũ: {soLuongCu}\nTồn mới: {soLuongMoi}",
                                             "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hoi == DialogResult.Yes)
            {
                // SỬ DỤNG ExecuteNonQuery CỦA LỚP KETNOI MÀ KHÔNG GÂY LỖI KẾT NỐI
                UpdateTonKho(maSP, soLuongMoi);
            }
        }

        // Hàm cập nhật tồn kho sử dụng ExecuteNonQuery(string query)
        private void UpdateTonKho(string maSP, int soLuongMoi)
        {
            // TẠO CÂU LỆNH SQL ĐẦY ĐỦ (Dùng MaKho='K01' mặc định)
            // LƯU Ý: Phải dùng ExecuteNonQuery(string query) để tận dụng hàm có sẵn trong Ketnoi.cs
            string sql = $@"IF EXISTS (SELECT 1 FROM TONKHO WHERE MaSP = N'{maSP}' AND MaKho = 'K01')
                            BEGIN
                                UPDATE TONKHO SET SoLuongTonKho = {soLuongMoi} 
                                WHERE MaSP = N'{maSP}' AND MaKho = 'K01'
                            END
                            ELSE
                            BEGIN
                                INSERT INTO TONKHO (MaKho, MaSP, SoLuongTonKho) 
                                VALUES ('K01', N'{maSP}', {soLuongMoi})
                            END";

            // GỌI ExecuteNonQuery
            int result = kn.ExecuteNonQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật tồn kho thành công!", "Thông báo");
                LoadDSTonKho(); // Tải lại danh sách
                ResetPanelDieuChinh();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại hoặc không có thay đổi!", "Lỗi");
            }
        }

        // --- 4. CÁC CHỨC NĂNG KHÁC ---
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDSTonKho(txtTimKiemSP.Text.Trim());
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtTimKiemSP.Clear();
            LoadDSTonKho();
        }

        private void ResetPanelDieuChinh()
        {
            txtMaSP_DieuChinh.Clear();
            txtTenSP_DieuChinh.Clear();
            txtTonHienTai.Text = "0";
            // Đặt lại giá trị ban đầu cho NumericUpDown
            numSoLuongMoi.Value = 0;
            numSoLuongMoi.Maximum = 99999; // Đặt lại Maximum mặc định (Nếu bạn không đặt trong Designer)
            txtLyDo.Clear();
        }

        private void gbDieuChinh_Enter(object sender, EventArgs e)
        {
            // Không làm gì
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
    }
}