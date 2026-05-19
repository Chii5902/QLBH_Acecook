using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class Report : Form
    {
        // Thêm Property để nhận mã hóa đơn từ Form chính truyền sang
        public string MaHD_Selected { get; set; }

        public Report()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Cấu hình đường dẫn report
                reportViewer1.LocalReport.ReportEmbeddedResource = "_03_DoanLinhChi_QLBHAcecook_23DTH1_S5.Report1.rdlc";

                // Xóa các nguồn dữ liệu cũ để tránh trùng lặp khi in nhiều lần
                reportViewer1.LocalReport.DataSources.Clear();

                // 2. Sử dụng biến truyền vào và xử lý khoảng trắng (Trim) để khớp với CHAR(10)
                // Lưu ý: Ta dùng Trim() để sạch dữ liệu, nhưng trong SQL dùng LIKE sẽ an toàn hơn
                string maHD = MaHD_Selected.Trim();

                // --- DATASET 1: CHI TIẾT HÓA ĐƠN ---
                DataTable dtCTHD = kn.ExecuteQuery("SELECT * FROM CHITIETHOADON WHERE MaHD LIKE '" + maHD + "%'");
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtCTHD));

                // --- DATASET 2: THÔNG TIN TỔNG QUÁT ---
                DataTable dtHD = kn.ExecuteQuery("SELECT * FROM HOADON WHERE MaHD LIKE '" + maHD + "%'");
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dtHD));

                // --- DATASET 3: THÔNG TIN SẢN PHẨM (Để Lookup tên SP) ---
                DataTable dtSP = kn.getAllSP();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", dtSP));

                // 3. Kiểm tra thực tế trước khi hiển thị
                if (dtHD.Rows.Count > 0)
                {
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    // Thông báo nếu lỡ truyền sai mã hoặc lưu chưa kịp vào DB
                    MessageBox.Show("Không tìm thấy dữ liệu hóa đơn: " + MaHD_Selected, "Thông báo");
                    this.Close(); // Đóng form report nếu không có dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message);
            }
        }
    }
}
