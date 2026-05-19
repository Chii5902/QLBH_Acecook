
namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class ThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControlThongKe = new System.Windows.Forms.TabControl();
            this.tabDoanhSo = new System.Windows.Forms.TabPage();
            this.dgvDoanhSoChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlKPIsDoanhSo = new System.Windows.Forms.Panel();
            this.lblTongDoanhSo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocDoanhSo = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.dgvTonKhoChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlKPIsTonKho = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSLTonThap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongGiaTriTon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLocKho = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabCongNo = new System.Windows.Forms.TabPage();
            this.dgvCongNoChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlKPIsCongNo = new System.Windows.Forms.Panel();
            this.cboLocLoaiKH = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLocCongNo = new System.Windows.Forms.Button();
            this.lblKhachNoCao = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTongNoQuaHan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tabControlThongKe.SuspendLayout();
            this.tabDoanhSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSoChiTiet)).BeginInit();
            this.pnlKPIsDoanhSo.SuspendLayout();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKhoChiTiet)).BeginInit();
            this.pnlKPIsTonKho.SuspendLayout();
            this.tabCongNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNoChiTiet)).BeginInit();
            this.pnlKPIsCongNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(342, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(504, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "BÁO CÁO PHÂN TÍCH - THỐNG KÊ";
            // 
            // tabControlThongKe
            // 
            this.tabControlThongKe.Controls.Add(this.tabDoanhSo);
            this.tabControlThongKe.Controls.Add(this.tabTonKho);
            this.tabControlThongKe.Controls.Add(this.tabCongNo);
            this.tabControlThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tabControlThongKe.Location = new System.Drawing.Point(0, 60);
            this.tabControlThongKe.Name = "tabControlThongKe";
            this.tabControlThongKe.SelectedIndex = 0;
            this.tabControlThongKe.Size = new System.Drawing.Size(1200, 640);
            this.tabControlThongKe.TabIndex = 1;
            // 
            // tabDoanhSo
            // 
            this.tabDoanhSo.Controls.Add(this.dgvDoanhSoChiTiet);
            this.tabDoanhSo.Controls.Add(this.pnlKPIsDoanhSo);
            this.tabDoanhSo.Location = new System.Drawing.Point(4, 32);
            this.tabDoanhSo.Name = "tabDoanhSo";
            this.tabDoanhSo.Padding = new System.Windows.Forms.Padding(10);
            this.tabDoanhSo.Size = new System.Drawing.Size(1192, 604);
            this.tabDoanhSo.TabIndex = 0;
            this.tabDoanhSo.Text = "1. Doanh số bán hàng";
            this.tabDoanhSo.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhSoChiTiet
            // 
            this.dgvDoanhSoChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhSoChiTiet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhSoChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoanhSoChiTiet.ColumnHeadersHeight = 35;
            this.dgvDoanhSoChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhSoChiTiet.EnableHeadersVisualStyles = false;
            this.dgvDoanhSoChiTiet.Location = new System.Drawing.Point(10, 100);
            this.dgvDoanhSoChiTiet.Name = "dgvDoanhSoChiTiet";
            this.dgvDoanhSoChiTiet.ReadOnly = true;
            this.dgvDoanhSoChiTiet.RowHeadersVisible = false;
            this.dgvDoanhSoChiTiet.RowHeadersWidth = 51;
            this.dgvDoanhSoChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhSoChiTiet.Size = new System.Drawing.Size(1172, 494);
            this.dgvDoanhSoChiTiet.TabIndex = 1;
            // 
            // pnlKPIsDoanhSo
            // 
            this.pnlKPIsDoanhSo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlKPIsDoanhSo.Controls.Add(this.lblTongDoanhSo);
            this.pnlKPIsDoanhSo.Controls.Add(this.label4);
            this.pnlKPIsDoanhSo.Controls.Add(this.btnLocDoanhSo);
            this.pnlKPIsDoanhSo.Controls.Add(this.dtpEnd);
            this.pnlKPIsDoanhSo.Controls.Add(this.dtpStart);
            this.pnlKPIsDoanhSo.Controls.Add(this.label3);
            this.pnlKPIsDoanhSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPIsDoanhSo.Location = new System.Drawing.Point(10, 10);
            this.pnlKPIsDoanhSo.Name = "pnlKPIsDoanhSo";
            this.pnlKPIsDoanhSo.Size = new System.Drawing.Size(1172, 90);
            this.pnlKPIsDoanhSo.TabIndex = 0;
            // 
            // lblTongDoanhSo
            // 
            this.lblTongDoanhSo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhSo.Location = new System.Drawing.Point(820, 48);
            this.lblTongDoanhSo.Name = "lblTongDoanhSo";
            this.lblTongDoanhSo.Size = new System.Drawing.Size(320, 30);
            this.lblTongDoanhSo.TabIndex = 5;
            this.lblTongDoanhSo.Text = "0 VNĐ";
            this.lblTongDoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(820, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "TỔNG DOANH SỐ";
            // 
            // btnLocDoanhSo
            // 
            this.btnLocDoanhSo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocDoanhSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocDoanhSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLocDoanhSo.ForeColor = System.Drawing.Color.White;
            this.btnLocDoanhSo.Location = new System.Drawing.Point(524, 30);
            this.btnLocDoanhSo.Name = "btnLocDoanhSo";
            this.btnLocDoanhSo.Size = new System.Drawing.Size(109, 33);
            this.btnLocDoanhSo.TabIndex = 3;
            this.btnLocDoanhSo.Text = "LỌC";
            this.btnLocDoanhSo.UseVisualStyleBackColor = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(257, 33);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(202, 30);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(17, 33);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(202, 30);
            this.dtpStart.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(227, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "—";
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.dgvTonKhoChiTiet);
            this.tabTonKho.Controls.Add(this.pnlKPIsTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 32);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.tabTonKho.Size = new System.Drawing.Size(1192, 604);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "2. Tồn kho ";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // dgvTonKhoChiTiet
            // 
            this.dgvTonKhoChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKhoChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKhoChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKhoChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKhoChiTiet.Location = new System.Drawing.Point(10, 100);
            this.dgvTonKhoChiTiet.Name = "dgvTonKhoChiTiet";
            this.dgvTonKhoChiTiet.ReadOnly = true;
            this.dgvTonKhoChiTiet.RowHeadersVisible = false;
            this.dgvTonKhoChiTiet.RowHeadersWidth = 51;
            this.dgvTonKhoChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKhoChiTiet.Size = new System.Drawing.Size(1172, 494);
            this.dgvTonKhoChiTiet.TabIndex = 1;
            // 
            // pnlKPIsTonKho
            // 
            this.pnlKPIsTonKho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlKPIsTonKho.Controls.Add(this.button2);
            this.pnlKPIsTonKho.Controls.Add(this.button1);
            this.pnlKPIsTonKho.Controls.Add(this.lblSLTonThap);
            this.pnlKPIsTonKho.Controls.Add(this.label6);
            this.pnlKPIsTonKho.Controls.Add(this.lblTongGiaTriTon);
            this.pnlKPIsTonKho.Controls.Add(this.label8);
            this.pnlKPIsTonKho.Controls.Add(this.cboLocKho);
            this.pnlKPIsTonKho.Controls.Add(this.label7);
            this.pnlKPIsTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPIsTonKho.Location = new System.Drawing.Point(10, 10);
            this.pnlKPIsTonKho.Name = "pnlKPIsTonKho";
            this.pnlKPIsTonKho.Size = new System.Drawing.Size(1172, 90);
            this.pnlKPIsTonKho.TabIndex = 0;
            this.pnlKPIsTonKho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKPIsTonKho_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(956, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSLTonThap
            // 
            this.lblSLTonThap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSLTonThap.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSLTonThap.Location = new System.Drawing.Point(263, 54);
            this.lblSLTonThap.Name = "lblSLTonThap";
            this.lblSLTonThap.Size = new System.Drawing.Size(200, 30);
            this.lblSLTonThap.TabIndex = 5;
            this.lblSLTonThap.Text = "0 Thùng";
            this.lblSLTonThap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(318, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tồn kho dưới min";
            // 
            // lblTongGiaTriTon
            // 
            this.lblTongGiaTriTon.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTriTon.ForeColor = System.Drawing.Color.Red;
            this.lblTongGiaTriTon.Location = new System.Drawing.Point(469, 54);
            this.lblTongGiaTriTon.Name = "lblTongGiaTriTon";
            this.lblTongGiaTriTon.Size = new System.Drawing.Size(242, 30);
            this.lblTongGiaTriTon.TabIndex = 3;
            this.lblTongGiaTriTon.Text = "0 VNĐ";
            this.lblTongGiaTriTon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(516, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "TỔNG GIÁ TRỊ TỒN";
            // 
            // cboLocKho
            // 
            this.cboLocKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKho.FormattingEnabled = true;
            this.cboLocKho.Location = new System.Drawing.Point(84, 20);
            this.cboLocKho.Name = "cboLocKho";
            this.cboLocKho.Size = new System.Drawing.Size(200, 31);
            this.cboLocKho.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lọc Kho:";
            // 
            // tabCongNo
            // 
            this.tabCongNo.Controls.Add(this.dgvCongNoChiTiet);
            this.tabCongNo.Controls.Add(this.pnlKPIsCongNo);
            this.tabCongNo.Location = new System.Drawing.Point(4, 32);
            this.tabCongNo.Name = "tabCongNo";
            this.tabCongNo.Padding = new System.Windows.Forms.Padding(10);
            this.tabCongNo.Size = new System.Drawing.Size(1192, 604);
            this.tabCongNo.TabIndex = 2;
            this.tabCongNo.Text = "3. Công nợ khách hàng";
            this.tabCongNo.UseVisualStyleBackColor = true;
            // 
            // dgvCongNoChiTiet
            // 
            this.dgvCongNoChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNoChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNoChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongNoChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNoChiTiet.Location = new System.Drawing.Point(10, 111);
            this.dgvCongNoChiTiet.Name = "dgvCongNoChiTiet";
            this.dgvCongNoChiTiet.ReadOnly = true;
            this.dgvCongNoChiTiet.RowHeadersVisible = false;
            this.dgvCongNoChiTiet.RowHeadersWidth = 51;
            this.dgvCongNoChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNoChiTiet.Size = new System.Drawing.Size(1172, 483);
            this.dgvCongNoChiTiet.TabIndex = 1;
            // 
            // pnlKPIsCongNo
            // 
            this.pnlKPIsCongNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlKPIsCongNo.Controls.Add(this.cboLocLoaiKH);
            this.pnlKPIsCongNo.Controls.Add(this.label13);
            this.pnlKPIsCongNo.Controls.Add(this.btnLocCongNo);
            this.pnlKPIsCongNo.Controls.Add(this.lblKhachNoCao);
            this.pnlKPIsCongNo.Controls.Add(this.label10);
            this.pnlKPIsCongNo.Controls.Add(this.lblTongNoQuaHan);
            this.pnlKPIsCongNo.Controls.Add(this.label12);
            this.pnlKPIsCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPIsCongNo.Location = new System.Drawing.Point(10, 10);
            this.pnlKPIsCongNo.Name = "pnlKPIsCongNo";
            this.pnlKPIsCongNo.Size = new System.Drawing.Size(1172, 101);
            this.pnlKPIsCongNo.TabIndex = 0;
            // 
            // cboLocLoaiKH
            // 
            this.cboLocLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoaiKH.FormattingEnabled = true;
            this.cboLocLoaiKH.Location = new System.Drawing.Point(135, 48);
            this.cboLocLoaiKH.Name = "cboLocLoaiKH";
            this.cboLocLoaiKH.Size = new System.Drawing.Size(200, 31);
            this.cboLocLoaiKH.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(20, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Lọc Loại KH:";
            // 
            // btnLocCongNo
            // 
            this.btnLocCongNo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLocCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocCongNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLocCongNo.ForeColor = System.Drawing.Color.White;
            this.btnLocCongNo.Location = new System.Drawing.Point(345, 48);
            this.btnLocCongNo.Name = "btnLocCongNo";
            this.btnLocCongNo.Size = new System.Drawing.Size(80, 31);
            this.btnLocCongNo.TabIndex = 4;
            this.btnLocCongNo.Text = "LỌC";
            this.btnLocCongNo.UseVisualStyleBackColor = false;
            // 
            // lblKhachNoCao
            // 
            this.lblKhachNoCao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblKhachNoCao.ForeColor = System.Drawing.Color.Red;
            this.lblKhachNoCao.Location = new System.Drawing.Point(820, 48);
            this.lblKhachNoCao.Name = "lblKhachNoCao";
            this.lblKhachNoCao.Size = new System.Drawing.Size(320, 30);
            this.lblKhachNoCao.TabIndex = 3;
            this.lblKhachNoCao.Text = "0 KH";
            this.lblKhachNoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(831, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Khách hàng nợ cao";
            // 
            // lblTongNoQuaHan
            // 
            this.lblTongNoQuaHan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongNoQuaHan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTongNoQuaHan.Location = new System.Drawing.Point(512, 48);
            this.lblTongNoQuaHan.Name = "lblTongNoQuaHan";
            this.lblTongNoQuaHan.Size = new System.Drawing.Size(320, 30);
            this.lblTongNoQuaHan.TabIndex = 1;
            this.lblTongNoQuaHan.Text = "0 VNĐ";
            this.lblTongNoQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(500, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "TỔNG NỢ HIỆN TẠI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(751, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControlThongKe);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Phân tích";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlThongKe.ResumeLayout(false);
            this.tabDoanhSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSoChiTiet)).EndInit();
            this.pnlKPIsDoanhSo.ResumeLayout(false);
            this.pnlKPIsDoanhSo.PerformLayout();
            this.tabTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKhoChiTiet)).EndInit();
            this.pnlKPIsTonKho.ResumeLayout(false);
            this.pnlKPIsTonKho.PerformLayout();
            this.tabCongNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNoChiTiet)).EndInit();
            this.pnlKPIsCongNo.ResumeLayout(false);
            this.pnlKPIsCongNo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlThongKe;
        private System.Windows.Forms.TabPage tabDoanhSo;
        private System.Windows.Forms.Panel pnlKPIsDoanhSo;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.TabPage tabCongNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblTongDoanhSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocDoanhSo;
        private System.Windows.Forms.DataGridView dgvDoanhSoChiTiet;
        private System.Windows.Forms.DataGridView dgvTonKhoChiTiet;
        private System.Windows.Forms.Panel pnlKPIsTonKho;
        private System.Windows.Forms.ComboBox cboLocKho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSLTonThap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongGiaTriTon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCongNoChiTiet;
        private System.Windows.Forms.Panel pnlKPIsCongNo;
        private System.Windows.Forms.Button btnLocCongNo;
        private System.Windows.Forms.Label lblKhachNoCao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongNoQuaHan;
        private System.Windows.Forms.Label label12;
        // Các Controls mới cho Công nợ (Đã được tạo trong InitializeComponent)
        private System.Windows.Forms.ComboBox cboLocLoaiKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}