namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    partial class Report
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
            this.qLBHDataSet = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet();
            this.qLBHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet1 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet1();
            this.qLBHDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet2 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet2();
            this.qLBHDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet3 = new _03_DoanLinhChi_QLBHAcecook_23DTH1_S5.QLBHDataSet3();
            this.qLBHDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.qLBHDataSet1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.qLBHDataSet2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.qLBHDataSet3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_03_DoanLinhChi_QLBHAcecook_23DTH1_S5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSetBindingSource
            // 
            this.qLBHDataSetBindingSource.DataSource = this.qLBHDataSet;
            this.qLBHDataSetBindingSource.Position = 0;
            // 
            // qLBHDataSet1
            // 
            this.qLBHDataSet1.DataSetName = "QLBHDataSet1";
            this.qLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet1BindingSource
            // 
            this.qLBHDataSet1BindingSource.DataSource = this.qLBHDataSet1;
            this.qLBHDataSet1BindingSource.Position = 0;
            // 
            // qLBHDataSet1BindingSource1
            // 
            this.qLBHDataSet1BindingSource1.DataSource = this.qLBHDataSet1;
            this.qLBHDataSet1BindingSource1.Position = 0;
            // 
            // qLBHDataSet2
            // 
            this.qLBHDataSet2.DataSetName = "QLBHDataSet2";
            this.qLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSet2BindingSource
            // 
            this.qLBHDataSet2BindingSource.DataSource = this.qLBHDataSet2;
            this.qLBHDataSet2BindingSource.Position = 0;
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
            // qLBHDataSetBindingSource1
            // 
            this.qLBHDataSetBindingSource1.DataSource = this.qLBHDataSet;
            this.qLBHDataSetBindingSource1.Position = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLBHDataSetBindingSource;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource qLBHDataSet1BindingSource;
        private QLBHDataSet1 qLBHDataSet1;
        private System.Windows.Forms.BindingSource qLBHDataSet2BindingSource;
        private QLBHDataSet2 qLBHDataSet2;
        private System.Windows.Forms.BindingSource qLBHDataSet3BindingSource;
        private QLBHDataSet3 qLBHDataSet3;
        private System.Windows.Forms.BindingSource qLBHDataSetBindingSource1;
        private System.Windows.Forms.BindingSource qLBHDataSet1BindingSource1;
    }
}