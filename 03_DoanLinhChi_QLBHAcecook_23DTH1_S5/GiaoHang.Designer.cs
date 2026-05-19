namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class GiaoHang
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvDSGiaoHang = new System.Windows.Forms.DataGridView();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.cboTrangThaiGH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayGiao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPGH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoHang)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(317, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(328, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ GIAO HÀNG";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlNavigation);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 540);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvDSGiaoHang);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpList.ForeColor = System.Drawing.Color.Firebrick;
            this.grpList.Location = new System.Drawing.Point(5, 5);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(640, 470);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách Phiếu giao hàng";
            // 
            // dgvDSGiaoHang
            // 
            this.dgvDSGiaoHang.AllowUserToAddRows = false;
            this.dgvDSGiaoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGiaoHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSGiaoHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSGiaoHang.ColumnHeadersHeight = 30;
            this.dgvDSGiaoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSGiaoHang.EnableHeadersVisualStyles = false;
            this.dgvDSGiaoHang.Location = new System.Drawing.Point(3, 26);
            this.dgvDSGiaoHang.Name = "dgvDSGiaoHang";
            this.dgvDSGiaoHang.ReadOnly = true;
            this.dgvDSGiaoHang.RowHeadersVisible = false;
            this.dgvDSGiaoHang.RowHeadersWidth = 51;
            this.dgvDSGiaoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGiaoHang.Size = new System.Drawing.Size(634, 441);
            this.dgvDSGiaoHang.TabIndex = 0;
            this.dgvDSGiaoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGiaoHang_CellClick);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNavigation.Controls.Add(this.btnCuoi);
            this.pnlNavigation.Controls.Add(this.btnSau);
            this.pnlNavigation.Controls.Add(this.btnTruoc);
            this.pnlNavigation.Controls.Add(this.btnDau);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigation.Location = new System.Drawing.Point(5, 475);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(640, 60);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnCuoi
            // 
            this.btnCuoi.BackColor = System.Drawing.Color.Firebrick;
            this.btnCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCuoi.ForeColor = System.Drawing.Color.White;
            this.btnCuoi.Location = new System.Drawing.Point(360, 10);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(80, 40);
            this.btnCuoi.TabIndex = 3;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.BackColor = System.Drawing.Color.Firebrick;
            this.btnSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSau.ForeColor = System.Drawing.Color.White;
            this.btnSau.Location = new System.Drawing.Point(260, 10);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(80, 40);
            this.btnSau.TabIndex = 2;
            this.btnSau.Text = ">>";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.Firebrick;
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTruoc.ForeColor = System.Drawing.Color.White;
            this.btnTruoc.Location = new System.Drawing.Point(160, 10);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(80, 40);
            this.btnTruoc.TabIndex = 1;
            this.btnTruoc.Text = "<<";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.BackColor = System.Drawing.Color.Firebrick;
            this.btnDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDau.ForeColor = System.Drawing.Color.White;
            this.btnDau.Location = new System.Drawing.Point(60, 10);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(80, 40);
            this.btnDau.TabIndex = 0;
            this.btnDau.Text = "|<";
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // grpDetail
            // 
            this.grpDetail.BackColor = System.Drawing.Color.White;
            this.grpDetail.Controls.Add(this.btnCapNhatTrangThai);
            this.grpDetail.Controls.Add(this.cboTrangThaiGH);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Controls.Add(this.txtNgayGiao);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.txtMaHD);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.txtMaDH);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.txtMaPGH);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetail.ForeColor = System.Drawing.Color.Firebrick;
            this.grpDetail.Location = new System.Drawing.Point(5, 5);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(336, 530);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Chi tiết Phiếu giao hàng";
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCapNhatTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatTrangThai.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(30, 383);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(280, 48);
            this.btnCapNhatTrangThai.TabIndex = 10;
            this.btnCapNhatTrangThai.Text = "CẬP NHẬT TRẠNG THÁI";
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = false;
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            // 
            // cboTrangThaiGH
            // 
            this.cboTrangThaiGH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiGH.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboTrangThaiGH.FormattingEnabled = true;
            this.cboTrangThaiGH.Location = new System.Drawing.Point(147, 315);
            this.cboTrangThaiGH.Name = "cboTrangThaiGH";
            this.cboTrangThaiGH.Size = new System.Drawing.Size(163, 31);
            this.cboTrangThaiGH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trạng thái:";
            // 
            // txtNgayGiao
            // 
            this.txtNgayGiao.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNgayGiao.Location = new System.Drawing.Point(147, 248);
            this.txtNgayGiao.Name = "txtNgayGiao";
            this.txtNgayGiao.ReadOnly = true;
            this.txtNgayGiao.Size = new System.Drawing.Size(163, 30);
            this.txtNgayGiao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày giao:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaHD.Location = new System.Drawing.Point(147, 189);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(163, 30);
            this.txtMaHD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã HD:";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaDH.Location = new System.Drawing.Point(147, 127);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(163, 30);
            this.txtMaDH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ĐH:";
            // 
            // txtMaPGH
            // 
            this.txtMaPGH.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtMaPGH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaPGH.ForeColor = System.Drawing.Color.Red;
            this.txtMaPGH.Location = new System.Drawing.Point(147, 62);
            this.txtMaPGH.Name = "txtMaPGH";
            this.txtMaPGH.ReadOnly = true;
            this.txtMaPGH.Size = new System.Drawing.Size(163, 30);
            this.txtMaPGH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PGH:";
            // 
            // GiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "GiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phiếu Giao Hàng";
            this.Load += new System.EventHandler(this.PhieuGiaoHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoHang)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvDSGiaoHang;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TextBox txtMaPGH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThaiGH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayGiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label2;
    }
}