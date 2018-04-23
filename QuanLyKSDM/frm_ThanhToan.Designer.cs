namespace QuanLyKSDM
{
    partial class frm_ThanhToan
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
            this.dgv_dichvusd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thanhtoan = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_maphong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_mpt = new System.Windows.Forms.TextBox();
            this.txt_nvl = new System.Windows.Forms.TextBox();
            this.txt_ngaythue = new System.Windows.Forms.TextBox();
            this.txt_ngaytra = new System.Windows.Forms.TextBox();
            this.txt_mkh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.lbl_tienphong = new System.Windows.Forms.Label();
            this.lbl_tiendv = new System.Windows.Forms.Label();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_sln = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvusd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dichvusd
            // 
            this.dgv_dichvusd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dichvusd.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_dichvusd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dichvusd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvusd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_dichvusd.Location = new System.Drawing.Point(23, 520);
            this.dgv_dichvusd.Name = "dgv_dichvusd";
            this.dgv_dichvusd.RowTemplate.Height = 24;
            this.dgv_dichvusd.Size = new System.Drawing.Size(754, 207);
            this.dgv_dichvusd.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENDV";
            this.Column1.HeaderText = "Tên dịch vụ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NGAYTHUE";
            this.Column2.HeaderText = "Ngày sử dụng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLDV";
            this.Column3.HeaderText = "Số lượng ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DONGIA";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thanhtoan.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.Location = new System.Drawing.Point(138, 760);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(134, 34);
            this.btn_thanhtoan.TabIndex = 1;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseCustomBackColor = true;
            this.btn_thanhtoan.UseCustomForeColor = true;
            this.btn_thanhtoan.UseSelectable = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(333, 760);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(134, 34);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "In hóa đơn";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Location = new System.Drawing.Point(534, 760);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(134, 34);
            this.metroButton3.TabIndex = 1;
            this.metroButton3.Text = "Thoát";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(34, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nhân viên lập";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lbl_maphong
            // 
            this.lbl_maphong.AutoSize = true;
            this.lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_maphong.Location = new System.Drawing.Point(388, 77);
            this.lbl_maphong.Name = "lbl_maphong";
            this.lbl_maphong.Size = new System.Drawing.Size(157, 36);
            this.lbl_maphong.TabIndex = 10;
            this.lbl_maphong.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(245, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "PHÒNG:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(34, 160);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Mã phiếu thuê";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(34, 241);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Ngày thuê";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(34, 279);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Ngày trả";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel5.Location = new System.Drawing.Point(434, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Mã khách hành";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel6.Location = new System.Drawing.Point(434, 201);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Tên khách hàng";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel7.Location = new System.Drawing.Point(434, 241);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Số CMND";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel8.Location = new System.Drawing.Point(230, 351);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 25);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Tiền phòng:";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel9.Location = new System.Drawing.Point(230, 398);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(124, 25);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Tiền dịch vụ:";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel10.Location = new System.Drawing.Point(230, 445);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(64, 25);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Tổng:";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // txt_mpt
            // 
            this.txt_mpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mpt.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_mpt.Location = new System.Drawing.Point(205, 160);
            this.txt_mpt.Multiline = true;
            this.txt_mpt.Name = "txt_mpt";
            this.txt_mpt.Size = new System.Drawing.Size(164, 25);
            this.txt_mpt.TabIndex = 12;
            // 
            // txt_nvl
            // 
            this.txt_nvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nvl.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_nvl.Location = new System.Drawing.Point(205, 201);
            this.txt_nvl.Multiline = true;
            this.txt_nvl.Name = "txt_nvl";
            this.txt_nvl.Size = new System.Drawing.Size(164, 25);
            this.txt_nvl.TabIndex = 12;
            // 
            // txt_ngaythue
            // 
            this.txt_ngaythue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaythue.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_ngaythue.Location = new System.Drawing.Point(205, 241);
            this.txt_ngaythue.Multiline = true;
            this.txt_ngaythue.Name = "txt_ngaythue";
            this.txt_ngaythue.Size = new System.Drawing.Size(164, 25);
            this.txt_ngaythue.TabIndex = 12;
            // 
            // txt_ngaytra
            // 
            this.txt_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaytra.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_ngaytra.Location = new System.Drawing.Point(205, 279);
            this.txt_ngaytra.Multiline = true;
            this.txt_ngaytra.Name = "txt_ngaytra";
            this.txt_ngaytra.Size = new System.Drawing.Size(164, 25);
            this.txt_ngaytra.TabIndex = 12;
            // 
            // txt_mkh
            // 
            this.txt_mkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkh.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_mkh.Location = new System.Drawing.Point(613, 160);
            this.txt_mkh.Multiline = true;
            this.txt_mkh.Name = "txt_mkh";
            this.txt_mkh.Size = new System.Drawing.Size(164, 25);
            this.txt_mkh.TabIndex = 12;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_tenkh.Location = new System.Drawing.Point(613, 201);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(164, 25);
            this.txt_tenkh.TabIndex = 12;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_cmnd.Location = new System.Drawing.Point(613, 241);
            this.txt_cmnd.Multiline = true;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(164, 25);
            this.txt_cmnd.TabIndex = 12;
            // 
            // lbl_tienphong
            // 
            this.lbl_tienphong.AutoSize = true;
            this.lbl_tienphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tienphong.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_tienphong.Location = new System.Drawing.Point(429, 351);
            this.lbl_tienphong.Name = "lbl_tienphong";
            this.lbl_tienphong.Size = new System.Drawing.Size(127, 25);
            this.lbl_tienphong.TabIndex = 13;
            this.lbl_tienphong.Text = "Tiền phòng ";
            // 
            // lbl_tiendv
            // 
            this.lbl_tiendv.AutoSize = true;
            this.lbl_tiendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiendv.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_tiendv.Location = new System.Drawing.Point(429, 397);
            this.lbl_tiendv.Name = "lbl_tiendv";
            this.lbl_tiendv.Size = new System.Drawing.Size(136, 25);
            this.lbl_tiendv.TabIndex = 13;
            this.lbl_tiendv.Text = "Tiền dịch vụ ";
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_tong.Location = new System.Drawing.Point(429, 445);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(68, 25);
            this.lbl_tong.TabIndex = 13;
            this.lbl_tong.Text = "Tổng ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel11.Location = new System.Drawing.Point(434, 279);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(146, 25);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Số lượng người ";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // txt_sln
            // 
            this.txt_sln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sln.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_sln.Location = new System.Drawing.Point(613, 279);
            this.txt_sln.Multiline = true;
            this.txt_sln.Name = "txt_sln";
            this.txt_sln.Size = new System.Drawing.Size(164, 25);
            this.txt_sln.TabIndex = 12;
            // 
            // frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 817);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.lbl_tiendv);
            this.Controls.Add(this.lbl_tienphong);
            this.Controls.Add(this.txt_sln);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_ngaytra);
            this.Controls.Add(this.txt_ngaythue);
            this.Controls.Add(this.txt_mkh);
            this.Controls.Add(this.txt_nvl);
            this.Controls.Add(this.txt_mpt);
            this.Controls.Add(this.lbl_maphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.dgv_dichvusd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ThanhToan";
            this.Text = "Thanh toán";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvusd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dichvusd;
        private MetroFramework.Controls.MetroButton btn_thanhtoan;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lbl_maphong;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.TextBox txt_mpt;
        private System.Windows.Forms.TextBox txt_nvl;
        private System.Windows.Forms.TextBox txt_ngaythue;
        private System.Windows.Forms.TextBox txt_ngaytra;
        private System.Windows.Forms.TextBox txt_mkh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label lbl_tienphong;
        private System.Windows.Forms.Label lbl_tiendv;
        private System.Windows.Forms.Label lbl_tong;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox txt_sln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}