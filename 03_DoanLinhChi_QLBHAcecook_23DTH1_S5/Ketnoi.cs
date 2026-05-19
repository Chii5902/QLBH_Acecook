
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    internal class Ketnoi
    {
        private string connectString = @"Data Source=LAPTOP-EVH7G3G6\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Encrypt=False";

        // --- ĐIỂM SỬA 1: CHỈ TẠO KẾT NỐI, KHÔNG MỞ NÓ TẠI ĐÂY ---
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(connectString);
            // conn.Open(); // <-- ĐÃ BỎ DÒNG NÀY ĐỂ TRÁNH LỖI LẶP KẾT NỐI
            return conn;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                data = thucthi.ExecuteNonQuery();
                ketnoi.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(SqlCommand cmd)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = GetConnect())
                {
                    conn.Open(); // <-- THÊM MỞ KẾT NỐI AN TOÀN TRONG KHỐI TRY/USING
                    cmd.Connection = conn; // Gán kết nối cho SqlCommand
                    rowsAffected = cmd.ExecuteNonQuery();
                } // Kết nối tự động được đóng/dispose
            }
            catch (Exception ex)
            {
                // Rất quan trọng: Báo lỗi CSDL chi tiết cho người dùng
                MessageBox.Show("Lỗi ExecuteNonQuery (SqlCommand): " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }


        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                SqlDataAdapter laydulieu = new SqlDataAdapter(thucthi);
                laydulieu.Fill(dt);
                ketnoi.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = GetConnect())
                {
                    conn.Open(); // <-- THÊM MỞ KẾT NỐI AN TOÀN TRONG KHỐI TRY/USING
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        result = cmd.ExecuteScalar();
                    }
                } // Kết nối tự động được đóng/dispose
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu đơn: " + ex.Message);
            }
            return result;
        }
        // TRONG CLASS Ketnoi
        public DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnect())
            {
                try
                {
                    conn.Open(); // <-- THÊM MỞ KẾT NỐI AN TOÀN TRONG KHỐI TRY/USING
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Gán các tham số (ví dụ: @Start, @End) vào command
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi Query Overload");
                }
            } // Kết nối tự động được đóng/dispose
            return dt;
        }
        public T ExecuteScalar<T>(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnect())
            {
                try
                {
                    conn.Open(); // <-- THÊM MỞ KẾT NỐI AN TOÀN TRONG KHỐI TRY/USING
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    object result = cmd.ExecuteScalar();

                    // Kiểm tra và chuyển đổi kiểu dữ liệu an toàn
                    if (result == null || result == DBNull.Value)
                        return default(T); // Trả về 0 (cho int/decimal) hoặc null (cho string)

                    return (T)Convert.ChangeType(result, typeof(T));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tính toán KPI: " + ex.Message, "Lỗi Scalar");
                    return default(T);
                }
            } // Kết nối tự động được đóng/dispose
        }
        public DataTable getAllSP()
        {
            // Tận dụng hàm ExecuteQuery ở trên để lấy toàn bộ nhân viên
            return ExecuteQuery("SELECT * FROM SANPHAM");
        }
        public DataTable getAllHD()
        {
            // Tận dụng hàm ExecuteQuery ở trên để lấy toàn bộ nhân viên
            return ExecuteQuery("SELECT * FROM HOADON");
        }
        public DataTable getAllCTDH()
        {
            // Tận dụng hàm ExecuteQuery ở trên để lấy toàn bộ nhân viên
            return ExecuteQuery("SELECT * FROM CHITIETHOADON");
        }
        public DataTable getTomTatHoaDon(string maHD)
        {
            // Câu lệnh SQL tính toán trực tiếp các cột bạn cần
            string query = @"
        SELECT 
            MaHD, 
            NgayBan,
            SUM(SoLuong * DonGia) AS TongTienHang,
            SUM(SoLuong * DonGia) * 0.1 AS Thue,
            SUM(SoLuong * DonGia) * 1.1 AS TongThanhToan
        FROM CHITIETHOADON
        WHERE MaHD = @MaHD
        GROUP BY MaHD, NgayBan";
            SqlParameter[] parameters = {
        new SqlParameter("@MaHD", maHD)
    };

            return ExecuteQuery(query, parameters);
        }
        public DataTable getThongTinHoaDonReport(string maHD)
        {
            // Lấy đúng các cột bạn đã INSERT vào ở nút Phát hành
            string query = "SELECT MaHD, NgayBan, TongTienHang, Thue, TongThanhToan, PhuongThucThanhToan FROM HOADON WHERE MaHD = @MaHD";

            SqlParameter[] parameters = {
        new SqlParameter("@MaHD", maHD)
    };

            return ExecuteQuery(query, parameters);
        }
        public DataTable getChiTietHoaDonTheoMa(string maHD)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
        new SqlParameter("@MaHD", maHD)
    };
            return ExecuteQuery(query, parameters);
        }
        public DataTable getTonKho()
        {
            string sql = @"SELECT 
                        tk.MaKho, 
                        k.TenKho, 
                        tk.MaSP, 
                        sp.TenSP, 
                        tk.SoLuongTonKho
                   FROM TONKHO tk
                   INNER JOIN SANPHAM sp ON tk.MaSP = sp.MaSP
                   INNER JOIN KHO k ON tk.MaKho = k.MaKho";

            return ExecuteQuery(sql);
        }
        public DataTable getHD()
        {
            // Bạn thay 'TONKHO' bằng tên bảng thực tế trong DB của bạn nhé
            string sql = "SELECT * FROM HOADON";
            return ExecuteQuery(sql);
        }
        public DataTable getKho()
        {
            // Bạn thay 'TONKHO' bằng tên bảng thực tế trong DB của bạn nhé
            string sql = "SELECT * FROM KHO";
            return ExecuteQuery(sql);
        }
    }
}