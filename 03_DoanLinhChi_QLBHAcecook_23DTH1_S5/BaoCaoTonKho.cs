using ClosedXML.Excel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    public partial class BaoCaoTonKho : Form
    {
        public BaoCaoTonKho()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void BaoCaoTonKho_Load(object sender, EventArgs e)
        {

            try
            {// 1. Cấu hình file báo cáo (Đảm bảo tên file là Report2.rdlc)
                reportViewer1.LocalReport.ReportEmbeddedResource = "_03_DoanLinhChi_QLBHAcecook_23DTH1_S5.Report2.rdlc";

                // 2. Làm sạch nguồn dữ liệu trước khi nạp mới
                reportViewer1.LocalReport.DataSources.Clear();

                // 3. Gọi hàm getTonKho() từ lớp Ketnoi mà bạn đã viết
                DataTable dt = kn.getTonKho();

                DataTable dtSP = kn.getAllSP();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dtSP));

                DataTable dtK = kn.getKho();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", dtK));

                // 4. Thiết lập nguồn dữ liệu cho Report
                // QUAN TRỌNG: "DataSet1" phải khớp với tên DataSet bạn tạo trong Report2.rdlc
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 5. Hiển thị báo cáo lên màn hình
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo tồn kho: " + ex.Message, "Thông báo");
            }
        }
    }
}
