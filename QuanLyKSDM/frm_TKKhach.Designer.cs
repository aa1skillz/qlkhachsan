namespace QuanLyKSDM
{
    partial class frm_TKKhach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbn_theoTen = new System.Windows.Forms.RadioButton();
            this.rbtn_theoma = new System.Windows.Forms.RadioButton();
            this.cbb_ma = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_ten = new MetroFramework.Controls.MetroTextBox();
            this.dgv_ttKh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttKh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_theoTen);
            this.groupBox1.Controls.Add(this.rbtn_theoma);
            this.groupBox1.Controls.Add(this.cbb_ma);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rbn_theoTen
            // 
            this.rbn_theoTen.AutoSize = true;
            this.rbn_theoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_theoTen.Location = new System.Drawing.Point(101, 101);
            this.rbn_theoTen.Name = "rbn_theoTen";
            this.rbn_theoTen.Size = new System.Drawing.Size(123, 24);
            this.rbn_theoTen.TabIndex = 3;
            this.rbn_theoTen.TabStop = true;
            this.rbn_theoTen.Text = "Tìm theo tên";
            this.rbn_theoTen.UseVisualStyleBackColor = true;
            this.rbn_theoTen.CheckedChanged += new System.EventHandler(this.rbn_theoTen_CheckedChanged);
            // 
            // rbtn_theoma
            // 
            this.rbtn_theoma.AutoSize = true;
            this.rbtn_theoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_theoma.Location = new System.Drawing.Point(101, 50);
            this.rbtn_theoma.Name = "rbtn_theoma";
            this.rbtn_theoma.Size = new System.Drawing.Size(123, 24);
            this.rbtn_theoma.TabIndex = 3;
            this.rbtn_theoma.TabStop = true;
            this.rbtn_theoma.Text = "Tìm theo mã";
            this.rbtn_theoma.UseVisualStyleBackColor = true;
            this.rbtn_theoma.CheckedChanged += new System.EventHandler(this.rbtn_theoma_CheckedChanged);
            // 
            // cbb_ma
            // 
            this.cbb_ma.FormattingEnabled = true;
            this.cbb_ma.Location = new System.Drawing.Point(251, 49);
            this.cbb_ma.Name = "cbb_ma";
            this.cbb_ma.Size = new System.Drawing.Size(153, 28);
            this.cbb_ma.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.Location = new System.Drawing.Point(486, 101);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(149, 38);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Location = new System.Drawing.Point(486, 44);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(149, 38);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Xem";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Lines = new string[0];
            this.txt_ten.Location = new System.Drawing.Point(251, 96);
            this.txt_ten.MaxLength = 32767;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.PasswordChar = '\0';
            this.txt_ten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ten.SelectedText = "";
            this.txt_ten.Size = new System.Drawing.Size(153, 35);
            this.txt_ten.TabIndex = 0;
            this.txt_ten.UseSelectable = true;
            // 
            // dgv_ttKh
            // 
            this.dgv_ttKh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ttKh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ttKh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ttKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_ttKh.Location = new System.Drawing.Point(52, 273);
            this.dgv_ttKh.Name = "dgv_ttKh";
            this.dgv_ttKh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ttKh.RowTemplate.Height = 24;
            this.dgv_ttKh.Size = new System.Drawing.Size(735, 369);
            this.dgv_ttKh.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKHACH";
            this.Column1.HeaderText = "Mã khách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHACH";
            this.Column2.HeaderText = "Tên khách";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYSINH";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIOITINH";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DIACHI";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CMND";
            this.Column6.HeaderText = "CMND";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "QUOCTICH";
            this.Column7.HeaderText = "Quốc tịch";
            this.Column7.Name = "Column7";
            // 
            // frm_TKKhach
            // 
            this.AcceptButton = this.btn_timkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(842, 691);
            this.Controls.Add(this.dgv_ttKh);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TKKhach";
            this.Text = "Tìm kiếm khách hàng";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_TKKhach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttKh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbn_theoTen;
        private System.Windows.Forms.RadioButton rbtn_theoma;
        private System.Windows.Forms.ComboBox cbb_ma;
        private System.Windows.Forms.Button btn_timkiem;
        private MetroFramework.Controls.MetroTextBox txt_ten;
        private System.Windows.Forms.DataGridView dgv_ttKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_thoat;
    }
}