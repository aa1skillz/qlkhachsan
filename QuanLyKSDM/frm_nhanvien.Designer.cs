namespace QuanLyKSDM
{
    partial class frm_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nhanvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new MetroFramework.Controls.MetroButton();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.dt_Ngaysinh = new MetroFramework.Controls.MetroDateTime();
            this.txt_Sdt = new MetroFramework.Controls.MetroTextBox();
            this.txt_Diachi = new MetroFramework.Controls.MetroTextBox();
            this.txt_Chucvu = new MetroFramework.Controls.MetroTextBox();
            this.txt_Tennv = new MetroFramework.Controls.MetroTextBox();
            this.txt_manv = new MetroFramework.Controls.MetroTextBox();
            this.RbtnNu = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnNam = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_ThemNV = new MetroFramework.Controls.MetroButton();
            this.btn_SuaNV = new MetroFramework.Controls.MetroButton();
            this.btn_XoaNV = new MetroFramework.Controls.MetroButton();
            this.btn_Thoat = new MetroFramework.Controls.MetroButton();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.dt_Ngaysinh);
            this.groupBox1.Controls.Add(this.txt_Sdt);
            this.groupBox1.Controls.Add(this.txt_Diachi);
            this.groupBox1.Controls.Add(this.txt_Chucvu);
            this.groupBox1.Controls.Add(this.txt_Tennv);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.RbtnNu);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Luu.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Luu.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(450, 141);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(114, 36);
            this.btn_Luu.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseCustomBackColor = true;
            this.btn_Luu.UseCustomForeColor = true;
            this.btn_Luu.UseSelectable = true;
            this.btn_Luu.UseStyleColors = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_huy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_huy.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(450, 203);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(114, 36);
            this.btn_huy.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_huy.TabIndex = 1;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseCustomBackColor = true;
            this.btn_huy.UseCustomForeColor = true;
            this.btn_huy.UseSelectable = true;
            this.btn_huy.UseStyleColors = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaysinh.Location = new System.Drawing.Point(157, 128);
            this.dt_Ngaysinh.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(213, 30);
            this.dt_Ngaysinh.TabIndex = 3;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Lines = new string[0];
            this.txt_Sdt.Location = new System.Drawing.Point(158, 233);
            this.txt_Sdt.MaxLength = 32767;
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.PasswordChar = '\0';
            this.txt_Sdt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Sdt.SelectedText = "";
            this.txt_Sdt.Size = new System.Drawing.Size(212, 26);
            this.txt_Sdt.TabIndex = 2;
            this.txt_Sdt.UseSelectable = true;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Lines = new string[0];
            this.txt_Diachi.Location = new System.Drawing.Point(158, 179);
            this.txt_Diachi.MaxLength = 32767;
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.PasswordChar = '\0';
            this.txt_Diachi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Diachi.SelectedText = "";
            this.txt_Diachi.Size = new System.Drawing.Size(212, 26);
            this.txt_Diachi.TabIndex = 2;
            this.txt_Diachi.UseSelectable = true;
            // 
            // txt_Chucvu
            // 
            this.txt_Chucvu.Lines = new string[0];
            this.txt_Chucvu.Location = new System.Drawing.Point(157, 332);
            this.txt_Chucvu.MaxLength = 32767;
            this.txt_Chucvu.Name = "txt_Chucvu";
            this.txt_Chucvu.PasswordChar = '\0';
            this.txt_Chucvu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Chucvu.SelectedText = "";
            this.txt_Chucvu.Size = new System.Drawing.Size(221, 26);
            this.txt_Chucvu.TabIndex = 2;
            this.txt_Chucvu.UseSelectable = true;
            // 
            // txt_Tennv
            // 
            this.txt_Tennv.Lines = new string[0];
            this.txt_Tennv.Location = new System.Drawing.Point(158, 82);
            this.txt_Tennv.MaxLength = 32767;
            this.txt_Tennv.Name = "txt_Tennv";
            this.txt_Tennv.PasswordChar = '\0';
            this.txt_Tennv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Tennv.SelectedText = "";
            this.txt_Tennv.Size = new System.Drawing.Size(183, 26);
            this.txt_Tennv.TabIndex = 2;
            this.txt_Tennv.UseSelectable = true;
            // 
            // txt_manv
            // 
            this.txt_manv.Lines = new string[0];
            this.txt_manv.Location = new System.Drawing.Point(158, 33);
            this.txt_manv.MaxLength = 32767;
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.PasswordChar = '\0';
            this.txt_manv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_manv.SelectedText = "";
            this.txt_manv.Size = new System.Drawing.Size(136, 26);
            this.txt_manv.TabIndex = 2;
            this.txt_manv.UseSelectable = true;
            // 
            // RbtnNu
            // 
            this.RbtnNu.AutoSize = true;
            this.RbtnNu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RbtnNu.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.RbtnNu.ForeColor = System.Drawing.Color.Black;
            this.RbtnNu.Location = new System.Drawing.Point(294, 288);
            this.RbtnNu.Name = "RbtnNu";
            this.RbtnNu.Size = new System.Drawing.Size(47, 20);
            this.RbtnNu.TabIndex = 1;
            this.RbtnNu.Text = "Nữ";
            this.RbtnNu.UseCustomForeColor = true;
            this.RbtnNu.UseSelectable = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnNam.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtnNam.ForeColor = System.Drawing.Color.Black;
            this.rbtnNam.Location = new System.Drawing.Point(160, 288);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(59, 20);
            this.rbtnNam.TabIndex = 1;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseCustomForeColor = true;
            this.rbtnNam.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel8.Location = new System.Drawing.Point(17, 288);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 20);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Giới tính";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel9.Location = new System.Drawing.Point(17, 237);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 20);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Số điện thoại";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel7.Location = new System.Drawing.Point(17, 332);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 20);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Chức vụ";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(17, 185);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Địa chỉ";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(17, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Ngày sinh";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(17, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên nhân viên";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(17, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã nhân viên";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_ThemNV);
            this.groupBox5.Controls.Add(this.btn_SuaNV);
            this.groupBox5.Controls.Add(this.btn_XoaNV);
            this.groupBox5.Controls.Add(this.btn_Thoat);
            this.groupBox5.Location = new System.Drawing.Point(621, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 400);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ThemNV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_ThemNV.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_ThemNV.ForeColor = System.Drawing.Color.White;
            this.btn_ThemNV.Location = new System.Drawing.Point(42, 89);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(133, 36);
            this.btn_ThemNV.TabIndex = 1;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_ThemNV.UseCustomBackColor = true;
            this.btn_ThemNV.UseCustomForeColor = true;
            this.btn_ThemNV.UseSelectable = true;
            this.btn_ThemNV.UseStyleColors = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_SuaNV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_SuaNV.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_SuaNV.ForeColor = System.Drawing.Color.White;
            this.btn_SuaNV.Location = new System.Drawing.Point(42, 150);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(133, 36);
            this.btn_SuaNV.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_SuaNV.TabIndex = 1;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseCustomBackColor = true;
            this.btn_SuaNV.UseCustomForeColor = true;
            this.btn_SuaNV.UseSelectable = true;
            this.btn_SuaNV.UseStyleColors = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_XoaNV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_XoaNV.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_XoaNV.ForeColor = System.Drawing.Color.White;
            this.btn_XoaNV.Location = new System.Drawing.Point(42, 215);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(133, 36);
            this.btn_XoaNV.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_XoaNV.TabIndex = 1;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseCustomBackColor = true;
            this.btn_XoaNV.UseCustomForeColor = true;
            this.btn_XoaNV.UseSelectable = true;
            this.btn_XoaNV.UseStyleColors = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Thoat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Thoat.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(42, 277);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(133, 36);
            this.btn_Thoat.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseCustomBackColor = true;
            this.btn_Thoat.UseCustomForeColor = true;
            this.btn_Thoat.UseSelectable = true;
            this.btn_Thoat.UseStyleColors = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            this.dgv_NhanVien.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_NhanVien.Location = new System.Drawing.Point(23, 501);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(807, 253);
            this.dgv_NhanVien.TabIndex = 1;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIOITINH";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYSINH";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CHUCVU";
            this.Column5.HeaderText = "Chức vụ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DIACHI";
            this.Column9.HeaderText = "Địa chỉ";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "USER";
            this.Column7.HeaderText = "Tài khoản";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PASSWORD";
            this.Column8.HeaderText = "Mật khẩu";
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(851, 764);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nhanvien";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Quản lý nhân viên";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dt_Ngaysinh;
        private MetroFramework.Controls.MetroTextBox txt_Sdt;
        private MetroFramework.Controls.MetroTextBox txt_Diachi;
        private MetroFramework.Controls.MetroTextBox txt_Chucvu;
        private MetroFramework.Controls.MetroTextBox txt_Tennv;
        private MetroFramework.Controls.MetroTextBox txt_manv;
        private MetroFramework.Controls.MetroRadioButton RbtnNu;
        private MetroFramework.Controls.MetroRadioButton rbtnNam;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private MetroFramework.Controls.MetroButton btn_Luu;
        private MetroFramework.Controls.MetroButton btn_huy;
        private MetroFramework.Controls.MetroButton btn_ThemNV;
        private MetroFramework.Controls.MetroButton btn_SuaNV;
        private MetroFramework.Controls.MetroButton btn_XoaNV;
        private MetroFramework.Controls.MetroButton btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    }
}