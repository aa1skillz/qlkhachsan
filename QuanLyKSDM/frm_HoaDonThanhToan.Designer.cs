namespace QuanLyKSDM
{
    partial class frm_HoaDonThanhToan
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLKHACHSANDataSet = new QuanLyKSDM.QLKHACHSANDataSet();
            this.HOADON_XEM_THEOMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADON_XEM_THEOMATableAdapter = new QuanLyKSDM.QLKHACHSANDataSetTableAdapters.HOADON_XEM_THEOMATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADON_XEM_THEOMABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADON_XEM_THEOMABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKSDM.HoaDonPhongThanhToan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 705);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLKHACHSANDataSet
            // 
            this.QLKHACHSANDataSet.DataSetName = "QLKHACHSANDataSet";
            this.QLKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADON_XEM_THEOMABindingSource
            // 
            this.HOADON_XEM_THEOMABindingSource.DataMember = "HOADON_XEM_THEOMA";
            this.HOADON_XEM_THEOMABindingSource.DataSource = this.QLKHACHSANDataSet;
            // 
            // HOADON_XEM_THEOMATableAdapter
            // 
            this.HOADON_XEM_THEOMATableAdapter.ClearBeforeFill = true;
            // 
            // frm_HoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 785);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_HoaDonThanhToan";
            this.Load += new System.EventHandler(this.frm_HoaDonThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADON_XEM_THEOMABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADON_XEM_THEOMABindingSource;
        private QLKHACHSANDataSet QLKHACHSANDataSet;
        private QLKHACHSANDataSetTableAdapters.HOADON_XEM_THEOMATableAdapter HOADON_XEM_THEOMATableAdapter;

    }
}