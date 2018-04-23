namespace QuanLyKSDM
{
    partial class frm_baocao
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
            this.VIEW_REPORT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKHACHSANDataSet = new QuanLyKSDM.QLKHACHSANDataSet();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VIEW_REPORT1TableAdapter = new QuanLyKSDM.QLKHACHSANDataSetTableAdapters.VIEW_REPORT1TableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.VIEW_REPORT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKHACHSANDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VIEW_REPORT1BindingSource
            // 
            this.VIEW_REPORT1BindingSource.DataMember = "VIEW_REPORT1";
            this.VIEW_REPORT1BindingSource.DataSource = this.QLKHACHSANDataSet;
            // 
            // QLKHACHSANDataSet
            // 
            this.QLKHACHSANDataSet.DataSetName = "QLKHACHSANDataSet";
            this.QLKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.reportViewer1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 123);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1347, 430);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VIEW_REPORT1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKSDM.BaoCao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1347, 430);
            this.reportViewer1.TabIndex = 2;
            // 
            // VIEW_REPORT1TableAdapter
            // 
            this.VIEW_REPORT1TableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Người dùng :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ngày xem:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(121, 74);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(162, 30);
            this.metroDateTime1.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(121, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "ADMIN";
            // 
            // frm_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 592);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frm_baocao";
            this.Load += new System.EventHandler(this.fm_baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VIEW_REPORT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKHACHSANDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VIEW_REPORT1BindingSource;
        private QLKHACHSANDataSet QLKHACHSANDataSet;
        private QLKHACHSANDataSetTableAdapters.VIEW_REPORT1TableAdapter VIEW_REPORT1TableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}