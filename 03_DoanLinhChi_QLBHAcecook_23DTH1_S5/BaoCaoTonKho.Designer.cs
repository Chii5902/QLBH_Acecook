namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class BaoCaoTonKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLBHDataSet4 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet4();
            this.qLBHDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet3 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet3();
            this.qLBHDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet7 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet7();
            this.qLBHDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.qLBHDataSet4BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.qLBHDataSet3BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.qLBHDataSet7BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_03_DoanLinhChi_QLBHAcecook_23DTH1_S5.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLBHDataSet4
            // 
            this.qLBHDataSet4.DataSetName = "QLBHDataSet4";
            this.qLBHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet4BindingSource
            // 
            this.qLBHDataSet4BindingSource.DataSource = this.qLBHDataSet4;
            this.qLBHDataSet4BindingSource.Position = 0;
            // 
            // qLBHDataSet3
            // 
            this.qLBHDataSet3.DataSetName = "QLBHDataSet3";
            this.qLBHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet3BindingSource
            // 
            this.qLBHDataSet3BindingSource.DataSource = this.qLBHDataSet3;
            this.qLBHDataSet3BindingSource.Position = 0;
            // 
            // qLBHDataSet7
            // 
            this.qLBHDataSet7.DataSetName = "QLBHDataSet7";
            this.qLBHDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet7BindingSource
            // 
            this.qLBHDataSet7BindingSource.DataSource = this.qLBHDataSet7;
            this.qLBHDataSet7BindingSource.Position = 0;
            // 
            // BaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoTonKho";
            this.Text = "BaoCaoTonKho";
            this.Load += new System.EventHandler(this.BaoCaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLBHDataSet4BindingSource;
        private QLBHDataSet4 qLBHDataSet4;
        private System.Windows.Forms.BindingSource qLBHDataSet3BindingSource;
        private QLBHDataSet3 qLBHDataSet3;
        private System.Windows.Forms.BindingSource qLBHDataSet7BindingSource;
        private QLBHDataSet7 qLBHDataSet7;
    }
}