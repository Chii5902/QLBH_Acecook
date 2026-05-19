using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing; // Cần thêm namespace này để dùng Color và Font

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class SanPham : Form
    {
        Ketnoi kn = new Ketnoi();
        BindingSource bs = new BindingSource();

        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            radTenSP.Checked = true;
        }

        private void LoadDuLieu(string dieuKien = "")
        {
            try
            {
                string sql = "SELECT * FROM SANPHAM";
                if (dieuKien != "")
                {
                    sql += " WHERE " + dieuKien;
                }

                DataTable dt = kn.ExecuteQuery(sql);

                // --- BỔ SUNG ĐỊNH DẠNG DỮ LIỆU ---
                System.Windows.Forms.DataGridViewCellStyle boldFirebrickStyle = new System.Windows.Forms.DataGridViewCellStyle();
                // Đặt màu Firebrick
                boldFirebrickStyle.ForeColor = System.Drawing.Color.Firebrick;
                // Đặt Font Segoe UI, In đậm (Bold)
                boldFirebrickStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);

                // Áp dụng style cho toàn bộ dữ liệu (DefaultCellStyle)
                dgvSanPham.DefaultCellStyle = boldFirebrickStyle;
                // ------------------------------------

                bs.DataSource = dt;
                dgvSanPham.DataSource = bs;

                // Xóa và thiết lập lại DataBindings
                txtMaSP.DataBindings.Clear();
                txtTenSP.DataBindings.Clear();
                txtHanSuDung.DataBindings.Clear();
                txtDonViTinh.DataBindings.Clear();

                txtMaSP.DataBindings.Add("Text", bs, "MaSP");
                txtTenSP.DataBindings.Add("Text", bs, "TenSP");
                txtHanSuDung.DataBindings.Add("Text", bs, "HanSuDungNgay");
                txtDonViTinh.DataBindings.Add("Text", bs, "DonViTinh");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        // --- 4. CÁC CHỨC NĂNG THÊM - SỬA - XÓA ---

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Câu lệnh SQL Insert
                string sql = string.Format("INSERT INTO SANPHAM (MaSP, TenSP, DonViTinh, HanSuDungNgay) VALUES ('{0}', N'{1}', N'{2}', {3})",
                    txtMaSP.Text,
                    txtTenSP.Text,
                    txtDonViTinh.Text,
                    int.Parse(txtHanSuDung.Text)); // Chuyển HSD sang số

                if (kn.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadDuLieu(); // Tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Có thể Mã SP đã tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("UPDATE SANPHAM SET TenSP = N'{1}', DonViTinh = N'{2}', HanSuDungNgay = {3} WHERE MaSP = '{0}'",
                    txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text, txtHanSuDung.Text);

                if (kn.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadDuLieu();
                }
                else MessageBox.Show("Sửa thất bại!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("DELETE FROM SANPHAM WHERE MaSP = '{0}'", txtMaSP.Text);
                    if (kn.ExecuteNonQuery(sql) > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDuLieu();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // Nút Xem (Tải lại)
        private void btnXem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDuLieu();
        }

        // --- 5. TÌM KIẾM ---
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text.Trim();
            if (tk == "")
            {
                LoadDuLieu();
                return;
            }

            string query = "";
            if (radMaSP.Checked)
                query = $"MaSP LIKE '%{tk}%'";
            else
                query = $"TenSP LIKE N'%{tk}%'";

            LoadDuLieu(query);
        }
    }
}