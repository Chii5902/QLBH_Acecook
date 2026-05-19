namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5

{

    partial class XuatKho

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTaoPhieu = new System.Windows.Forms.TabPage();
            this.splitCreate = new System.Windows.Forms.SplitContainer();
            this.grpDonCho = new System.Windows.Forms.GroupBox();
            this.dgvDonChoXuat = new System.Windows.Forms.DataGridView();
            this.grpChiTietDon = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDon = new System.Windows.Forms.DataGridView();
            this.grpThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDH_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPX_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActionCreate = new System.Windows.Forms.Panel();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.lblStatusCreate = new System.Windows.Forms.Label();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.splitHistory = new System.Windows.Forms.SplitContainer();
            this.grpDSPhieu = new System.Windows.Forms.GroupBox();
            this.dgvDSPhieu = new System.Windows.Forms.DataGridView();
            this.grpChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTaoPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCreate)).BeginInit();
            this.splitCreate.Panel1.SuspendLayout();
            this.splitCreate.Panel2.SuspendLayout();
            this.splitCreate.SuspendLayout();
            this.grpDonCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonChoXuat)).BeginInit();
            this.grpChiTietDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).BeginInit();
            this.grpThongTinPhieu.SuspendLayout();
            this.panelActionCreate.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).BeginInit();
            this.splitHistory.Panel1.SuspendLayout();
            this.splitHistory.Panel2.SuspendLayout();
            this.splitHistory.SuspendLayout();
            this.grpDSPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).BeginInit();
            this.grpChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
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
            this.labelTitle.Location = new System.Drawing.Point(471, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(310, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ XUẤT KHO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTaoPhieu);
            this.tabControl1.Controls.Add(this.tabLichSu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 640);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTaoPhieu
            // 
            this.tabTaoPhieu.Controls.Add(this.splitCreate);
            this.tabTaoPhieu.Location = new System.Drawing.Point(4, 32);
            this.tabTaoPhieu.Name = "tabTaoPhieu";
            this.tabTaoPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaoPhieu.Size = new System.Drawing.Size(1192, 604);
            this.tabTaoPhieu.TabIndex = 0;
            this.tabTaoPhieu.Text = "1. Tạo Phiếu Xuất";
            this.tabTaoPhieu.UseVisualStyleBackColor = true;
            // 
            // splitCreate
            // 
            this.splitCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCreate.Location = new System.Drawing.Point(3, 3);
            this.splitCreate.Name = "splitCreate";
            // 
            // splitCreate.Panel1
            // 
            this.splitCreate.Panel1.Controls.Add(this.grpDonCho);
            this.splitCreate.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitCreate.Panel2
            // 
            this.splitCreate.Panel2.Controls.Add(this.grpChiTietDon);
            this.splitCreate.Panel2.Controls.Add(this.grpThongTinPhieu);
            this.splitCreate.Panel2.Controls.Add(this.panelActionCreate);
            this.splitCreate.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitCreate.Size = new System.Drawing.Size(1186, 598);
            this.splitCreate.SplitterDistance = 350;
            this.splitCreate.TabIndex = 0;
            // 
            // grpDonCho
            // 
            this.grpDonCho.Controls.Add(this.dgvDonChoXuat);
            this.grpDonCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDonCho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDonCho.ForeColor = System.Drawing.Color.Firebrick;
            this.grpDonCho.Location = new System.Drawing.Point(5, 5);
            this.grpDonCho.Name = "grpDonCho";
            this.grpDonCho.Size = new System.Drawing.Size(340, 588);
            this.grpDonCho.TabIndex = 0;
            this.grpDonCho.TabStop = false;
            this.grpDonCho.Text = "Danh sách Đơn hàng Chờ xử lý";
            // 
            // dgvDonChoXuat
            // 
            this.dgvDonChoXuat.AllowUserToAddRows = false;
            this.dgvDonChoXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonChoXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonChoXuat.ColumnHeadersHeight = 29;
            this.dgvDonChoXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonChoXuat.Location = new System.Drawing.Point(3, 26);
            this.dgvDonChoXuat.Name = "dgvDonChoXuat";
            this.dgvDonChoXuat.ReadOnly = true;
            this.dgvDonChoXuat.RowHeadersVisible = false;
            this.dgvDonChoXuat.RowHeadersWidth = 51;
            this.dgvDonChoXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonChoXuat.Size = new System.Drawing.Size(334, 559);
            this.dgvDonChoXuat.TabIndex = 0;
            this.dgvDonChoXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonChoXuat_CellClick);
            // 
            // grpChiTietDon
            // 
            this.grpChiTietDon.Controls.Add(this.dgvChiTietDon);
            this.grpChiTietDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTietDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChiTietDon.ForeColor = System.Drawing.Color.Firebrick;
            this.grpChiTietDon.Location = new System.Drawing.Point(5, 185);
            this.grpChiTietDon.Name = "grpChiTietDon";
            this.grpChiTietDon.Size = new System.Drawing.Size(822, 302);
            this.grpChiTietDon.TabIndex = 2;
            this.grpChiTietDon.TabStop = false;
            this.grpChiTietDon.Text = "Chi tiết sản phẩm & Kiểm tra Tồn kho";
            // 
            // dgvChiTietDon
            // 
            this.dgvChiTietDon.AllowUserToAddRows = false;
            this.dgvChiTietDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDon.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvChiTietDon.ColumnHeadersHeight = 29;
            this.dgvChiTietDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietDon.Location = new System.Drawing.Point(3, 26);
            this.dgvChiTietDon.Name = "dgvChiTietDon";
            this.dgvChiTietDon.RowHeadersVisible = false;
            this.dgvChiTietDon.RowHeadersWidth = 51;
            this.dgvChiTietDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDon.Size = new System.Drawing.Size(816, 273);
            this.dgvChiTietDon.TabIndex = 0;
            // 
            // grpThongTinPhieu
            // 
            this.grpThongTinPhieu.BackColor = System.Drawing.Color.White;
            this.grpThongTinPhieu.Controls.Add(this.txtTongSL);
            this.grpThongTinPhieu.Controls.Add(this.label5);
            this.grpThongTinPhieu.Controls.Add(this.dtpNgayXuat);
            this.grpThongTinPhieu.Controls.Add(this.label4);
            this.grpThongTinPhieu.Controls.Add(this.cboKho);
            this.grpThongTinPhieu.Controls.Add(this.label3);
            this.grpThongTinPhieu.Controls.Add(this.txtMaDH_Input);
            this.grpThongTinPhieu.Controls.Add(this.label2);
            this.grpThongTinPhieu.Controls.Add(this.txtMaPX_Input);
            this.grpThongTinPhieu.Controls.Add(this.label1);
            this.grpThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTinPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.grpThongTinPhieu.Location = new System.Drawing.Point(5, 5);
            this.grpThongTinPhieu.Name = "grpThongTinPhieu";
            this.grpThongTinPhieu.Size = new System.Drawing.Size(822, 180);
            this.grpThongTinPhieu.TabIndex = 0;
            this.grpThongTinPhieu.TabStop = false;
            this.grpThongTinPhieu.Text = "Thông tin Phiếu Xuất";
            // 
            // txtTongSL
            // 
            this.txtTongSL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongSL.Location = new System.Drawing.Point(186, 126);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.ReadOnly = true;
            this.txtTongSL.Size = new System.Drawing.Size(200, 30);
            this.txtTongSL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng số lượng:";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(550, 79);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(232, 30);
            this.dtpNgayXuat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(417, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày xuất:";
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(186, 76);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(200, 31);
            this.cboKho.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kho xuất hàng:";
            // 
            // txtMaDH_Input
            // 
            this.txtMaDH_Input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaDH_Input.Location = new System.Drawing.Point(550, 29);
            this.txtMaDH_Input.Name = "txtMaDH_Input";
            this.txtMaDH_Input.ReadOnly = true;
            this.txtMaDH_Input.Size = new System.Drawing.Size(232, 30);
            this.txtMaDH_Input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(417, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // txtMaPX_Input
            // 
            this.txtMaPX_Input.BackColor = System.Drawing.Color.White;
            this.txtMaPX_Input.Location = new System.Drawing.Point(186, 26);
            this.txtMaPX_Input.Name = "txtMaPX_Input";
            this.txtMaPX_Input.Size = new System.Drawing.Size(200, 30);
            this.txtMaPX_Input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu xuất:";
            // 
            // panelActionCreate
            // 
            this.panelActionCreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelActionCreate.Controls.Add(this.btnKiemTra);
            this.panelActionCreate.Controls.Add(this.btnTaoPhieu);
            this.panelActionCreate.Controls.Add(this.lblStatusCreate);
            this.panelActionCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionCreate.Location = new System.Drawing.Point(5, 487);
            this.panelActionCreate.Name = "panelActionCreate";
            this.panelActionCreate.Size = new System.Drawing.Size(822, 106);
            this.panelActionCreate.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.White;
            this.btnKiemTra.Location = new System.Drawing.Point(170, 39);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(186, 55);
            this.btnKiemTra.TabIndex = 0;
            this.btnKiemTra.Text = "KIỂM TRA TỒN";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTaoPhieu.Enabled = false;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieu.Location = new System.Drawing.Point(436, 38);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(190, 55);
            this.btnTaoPhieu.TabIndex = 1;
            this.btnTaoPhieu.Text = "XUẤT KHO ";
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // lblStatusCreate
            // 
            this.lblStatusCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusCreate.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusCreate.Location = new System.Drawing.Point(15, 2);
            this.lblStatusCreate.Name = "lblStatusCreate";
            this.lblStatusCreate.Size = new System.Drawing.Size(804, 30);
            this.lblStatusCreate.TabIndex = 2;
            this.lblStatusCreate.Text = "Trạng thái: Vui lòng chọn đơn hàng.";
            this.lblStatusCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabLichSu
            // 
            this.tabLichSu.Controls.Add(this.splitHistory);
            this.tabLichSu.Location = new System.Drawing.Point(4, 32);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(1192, 604);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "2. Lịch sử Xuất kho";
            this.tabLichSu.UseVisualStyleBackColor = true;
            // 
            // splitHistory
            // 
            this.splitHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHistory.Location = new System.Drawing.Point(3, 3);
            this.splitHistory.Name = "splitHistory";
            // 
            // splitHistory.Panel1
            // 
            this.splitHistory.Panel1.Controls.Add(this.grpDSPhieu);
            this.splitHistory.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitHistory.Panel2
            // 
            this.splitHistory.Panel2.Controls.Add(this.grpChiTietPhieu);
            this.splitHistory.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitHistory.Size = new System.Drawing.Size(1186, 598);
            this.splitHistory.SplitterDistance = 350;
            this.splitHistory.TabIndex = 0;
            // 
            // grpDSPhieu
            // 
            this.grpDSPhieu.Controls.Add(this.dgvDSPhieu);
            this.grpDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDSPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.grpDSPhieu.Location = new System.Drawing.Point(5, 5);
            this.grpDSPhieu.Name = "grpDSPhieu";
            this.grpDSPhieu.Size = new System.Drawing.Size(340, 588);
            this.grpDSPhieu.TabIndex = 0;
            this.grpDSPhieu.TabStop = false;
            this.grpDSPhieu.Text = "Danh sách Phiếu đã xuất";
            // 
            // dgvDSPhieu
            // 
            this.dgvDSPhieu.AllowUserToAddRows = false;
            this.dgvDSPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhieu.ColumnHeadersHeight = 29;
            this.dgvDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhieu.Location = new System.Drawing.Point(3, 26);
            this.dgvDSPhieu.Name = "dgvDSPhieu";
            this.dgvDSPhieu.ReadOnly = true;
            this.dgvDSPhieu.RowHeadersVisible = false;
            this.dgvDSPhieu.RowHeadersWidth = 51;
            this.dgvDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhieu.Size = new System.Drawing.Size(334, 559);
            this.dgvDSPhieu.TabIndex = 0;
            this.dgvDSPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieu_CellClick);
            // 
            // grpChiTietPhieu
            // 
            this.grpChiTietPhieu.Controls.Add(this.dgvChiTietPhieu);
            this.grpChiTietPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChiTietPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.grpChiTietPhieu.Location = new System.Drawing.Point(5, 5);
            this.grpChiTietPhieu.Name = "grpChiTietPhieu";
            this.grpChiTietPhieu.Size = new System.Drawing.Size(822, 588);
            this.grpChiTietPhieu.TabIndex = 0;
            this.grpChiTietPhieu.TabStop = false;
            this.grpChiTietPhieu.Text = "Chi tiết hàng hóa trong phiếu";
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.AllowUserToAddRows = false;
            this.dgvChiTietPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieu.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvChiTietPhieu.ColumnHeadersHeight = 29;
            this.dgvChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(3, 26);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.RowHeadersVisible = false;
            this.dgvChiTietPhieu.RowHeadersWidth = 51;
            this.dgvChiTietPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(816, 559);
            this.dgvChiTietPhieu.TabIndex = 0;
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "XuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Xuất Kho";
            this.Load += new System.EventHandler(this.XuatKho_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTaoPhieu.ResumeLayout(false);
            this.splitCreate.Panel1.ResumeLayout(false);
            this.splitCreate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCreate)).EndInit();
            this.splitCreate.ResumeLayout(false);
            this.grpDonCho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonChoXuat)).EndInit();
            this.grpChiTietDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).EndInit();
            this.grpThongTinPhieu.ResumeLayout(false);
            this.grpThongTinPhieu.PerformLayout();
            this.panelActionCreate.ResumeLayout(false);
            this.tabLichSu.ResumeLayout(false);
            this.splitHistory.Panel1.ResumeLayout(false);
            this.splitHistory.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).EndInit();
            this.splitHistory.ResumeLayout(false);
            this.grpDSPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).EndInit();
            this.grpChiTietPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.TabPage tabTaoPhieu;

        private System.Windows.Forms.TabPage tabLichSu;

        private System.Windows.Forms.SplitContainer splitCreate;

        private System.Windows.Forms.GroupBox grpDonCho;

        private System.Windows.Forms.DataGridView dgvDonChoXuat;

        private System.Windows.Forms.GroupBox grpChiTietDon;

        private System.Windows.Forms.DataGridView dgvChiTietDon;

        private System.Windows.Forms.GroupBox grpThongTinPhieu;

        private System.Windows.Forms.Panel panelActionCreate;

        private System.Windows.Forms.Button btnTaoPhieu;

        private System.Windows.Forms.Button btnKiemTra;

        private System.Windows.Forms.Label lblStatusCreate;

        private System.Windows.Forms.SplitContainer splitHistory;

        private System.Windows.Forms.GroupBox grpDSPhieu;

        private System.Windows.Forms.DataGridView dgvDSPhieu;

        private System.Windows.Forms.GroupBox grpChiTietPhieu;

        private System.Windows.Forms.DataGridView dgvChiTietPhieu;



        // New Inputs

        private System.Windows.Forms.TextBox txtMaPX_Input;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtMaDH_Input;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cboKho;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DateTimePicker dtpNgayXuat;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtTongSL;

        private System.Windows.Forms.Label label5;

    }

}