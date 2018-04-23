namespace QuanLyKSDM
{
    partial class frm_dangkiphong
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_NVlap = new MetroFramework.Controls.MetroTextBox();
            this.dt_ngaythue = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new MetroFramework.Controls.MetroButton();
            this.btn_luu = new MetroFramework.Controls.MetroButton();
            this.btn_KHhuy = new MetroFramework.Controls.MetroButton();
            this.btn_sua = new MetroFramework.Controls.MetroButton();
            this.btn_them = new MetroFramework.Controls.MetroButton();
            this.rbtn_nu = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_nam = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dt_ngaysinh = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_diachi = new MetroFramework.Controls.MetroTextBox();
            this.txt_cmnd = new MetroFramework.Controls.MetroTextBox();
            this.txt_tenkh = new MetroFramework.Controls.MetroTextBox();
            this.txt_quoctich = new MetroFramework.Controls.MetroTextBox();
            this.txt_makh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dt_ngaytra = new MetroFramework.Controls.MetroDateTime();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_maphong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_soluongnguoi = new MetroFramework.Controls.MetroTextBox();
            this.txt_maphieu = new MetroFramework.Controls.MetroTextBox();
            this.dgv_khach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_dkthue = new MetroFramework.Controls.MetroButton();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.dt_ngaylap = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khach)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel1.Location = new System.Drawing.Point(271, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nhân viên lập";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_NVlap
            // 
            this.txt_NVlap.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_NVlap.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_NVlap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_NVlap.Lines = new string[0];
            this.txt_NVlap.Location = new System.Drawing.Point(264, 115);
            this.txt_NVlap.MaxLength = 32767;
            this.txt_NVlap.Name = "txt_NVlap";
            this.txt_NVlap.PasswordChar = '\0';
            this.txt_NVlap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NVlap.SelectedText = "";
            this.txt_NVlap.Size = new System.Drawing.Size(144, 35);
            this.txt_NVlap.TabIndex = 9;
            this.txt_NVlap.UseCustomForeColor = true;
            this.txt_NVlap.UseSelectable = true;
            // 
            // dt_ngaythue
            // 
            this.dt_ngaythue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaythue.Location = new System.Drawing.Point(651, 50);
            this.dt_ngaythue.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_ngaythue.Name = "dt_ngaythue";
            this.dt_ngaythue.Size = new System.Drawing.Size(112, 30);
            this.dt_ngaythue.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_KHhuy);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.rbtn_nu);
            this.groupBox1.Controls.Add(this.rbtn_nam);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_quoctich);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 259);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_xoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_xoa.Location = new System.Drawing.Point(1030, 173);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(126, 38);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseCustomBackColor = true;
            this.btn_xoa.UseCustomForeColor = true;
            this.btn_xoa.UseSelectable = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_luu.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_luu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_luu.Location = new System.Drawing.Point(660, 200);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(102, 38);
            this.btn_luu.TabIndex = 13;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseCustomBackColor = true;
            this.btn_luu.UseCustomForeColor = true;
            this.btn_luu.UseSelectable = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_KHhuy
            // 
            this.btn_KHhuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_KHhuy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_KHhuy.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_KHhuy.Location = new System.Drawing.Point(843, 200);
            this.btn_KHhuy.Name = "btn_KHhuy";
            this.btn_KHhuy.Size = new System.Drawing.Size(102, 38);
            this.btn_KHhuy.TabIndex = 13;
            this.btn_KHhuy.Text = "Hủy";
            this.btn_KHhuy.UseCustomBackColor = true;
            this.btn_KHhuy.UseCustomForeColor = true;
            this.btn_KHhuy.UseSelectable = true;
            this.btn_KHhuy.Click += new System.EventHandler(this.btn_KHhuy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sua.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_sua.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_sua.Location = new System.Drawing.Point(1030, 109);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(126, 38);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseCustomBackColor = true;
            this.btn_sua.UseCustomForeColor = true;
            this.btn_sua.UseSelectable = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_them.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_them.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_them.Location = new System.Drawing.Point(1030, 45);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(126, 38);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseCustomBackColor = true;
            this.btn_them.UseCustomForeColor = true;
            this.btn_them.UseSelectable = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtn_nu.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtn_nu.ForeColor = System.Drawing.Color.Black;
            this.rbtn_nu.Location = new System.Drawing.Point(361, 205);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(47, 20);
            this.rbtn_nu.TabIndex = 11;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseCustomForeColor = true;
            this.rbtn_nu.UseSelectable = true;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtn_nam.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtn_nam.ForeColor = System.Drawing.Color.Black;
            this.rbtn_nam.Location = new System.Drawing.Point(228, 205);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(59, 20);
            this.rbtn_nam.TabIndex = 12;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseCustomForeColor = true;
            this.rbtn_nam.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel10.Location = new System.Drawing.Point(529, 91);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(75, 20);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Quốc tịch";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel9.Location = new System.Drawing.Point(529, 41);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(144, 20);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Số CMND/Hộ chiếu";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(226, 146);
            this.dt_ngaysinh.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(230, 30);
            this.dt_ngaysinh.TabIndex = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel8.Location = new System.Drawing.Point(529, 140);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 20);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Địa chỉ";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Lines = new string[0];
            this.txt_diachi.Location = new System.Drawing.Point(759, 139);
            this.txt_diachi.MaxLength = 32767;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_diachi.SelectedText = "";
            this.txt_diachi.Size = new System.Drawing.Size(230, 35);
            this.txt_diachi.TabIndex = 9;
            this.txt_diachi.UseSelectable = true;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Lines = new string[0];
            this.txt_cmnd.Location = new System.Drawing.Point(759, 35);
            this.txt_cmnd.MaxLength = 32767;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.PasswordChar = '\0';
            this.txt_cmnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cmnd.SelectedText = "";
            this.txt_cmnd.Size = new System.Drawing.Size(230, 35);
            this.txt_cmnd.TabIndex = 9;
            this.txt_cmnd.UseSelectable = true;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Lines = new string[0];
            this.txt_tenkh.Location = new System.Drawing.Point(226, 86);
            this.txt_tenkh.MaxLength = 32767;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.PasswordChar = '\0';
            this.txt_tenkh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenkh.SelectedText = "";
            this.txt_tenkh.Size = new System.Drawing.Size(230, 35);
            this.txt_tenkh.TabIndex = 9;
            this.txt_tenkh.UseSelectable = true;
            // 
            // txt_quoctich
            // 
            this.txt_quoctich.Lines = new string[0];
            this.txt_quoctich.Location = new System.Drawing.Point(759, 86);
            this.txt_quoctich.MaxLength = 32767;
            this.txt_quoctich.Name = "txt_quoctich";
            this.txt_quoctich.PasswordChar = '\0';
            this.txt_quoctich.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quoctich.SelectedText = "";
            this.txt_quoctich.Size = new System.Drawing.Size(230, 35);
            this.txt_quoctich.TabIndex = 9;
            this.txt_quoctich.UseSelectable = true;
            // 
            // txt_makh
            // 
            this.txt_makh.Lines = new string[0];
            this.txt_makh.Location = new System.Drawing.Point(226, 35);
            this.txt_makh.MaxLength = 32767;
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PasswordChar = '\0';
            this.txt_makh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_makh.SelectedText = "";
            this.txt_makh.Size = new System.Drawing.Size(140, 35);
            this.txt_makh.TabIndex = 9;
            this.txt_makh.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel7.Location = new System.Drawing.Point(28, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 20);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Giới tính";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel6.Location = new System.Drawing.Point(28, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Ngày sinh";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel3.Location = new System.Drawing.Point(19, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Tên Khách hàng";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel2.Location = new System.Drawing.Point(19, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Mã Khách hàng";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // dt_ngaytra
            // 
            this.dt_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaytra.Location = new System.Drawing.Point(838, 50);
            this.dt_ngaytra.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_ngaytra.Name = "dt_ngaytra";
            this.dt_ngaytra.Size = new System.Drawing.Size(114, 30);
            this.dt_ngaytra.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_maphong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.dt_ngaylap);
            this.groupBox2.Controls.Add(this.dt_ngaytra);
            this.groupBox2.Controls.Add(this.dt_ngaythue);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.txt_soluongnguoi);
            this.groupBox2.Controls.Add(this.txt_maphieu);
            this.groupBox2.Location = new System.Drawing.Point(24, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1184, 164);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // lbl_maphong
            // 
            this.lbl_maphong.AutoSize = true;
            this.lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_maphong.Location = new System.Drawing.Point(599, 110);
            this.lbl_maphong.Name = "lbl_maphong";
            this.lbl_maphong.Size = new System.Drawing.Size(157, 36);
            this.lbl_maphong.TabIndex = 9;
            this.lbl_maphong.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(456, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "PHÒNG:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel5.Location = new System.Drawing.Point(842, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Ngày trả";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel4.Location = new System.Drawing.Point(645, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Ngày thuê";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel12.Location = new System.Drawing.Point(1012, 18);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(116, 20);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "Số lượng người";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel11.Location = new System.Drawing.Point(39, 14);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(74, 20);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "Mã phiếu";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // txt_soluongnguoi
            // 
            this.txt_soluongnguoi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_soluongnguoi.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_soluongnguoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_soluongnguoi.Lines = new string[0];
            this.txt_soluongnguoi.Location = new System.Drawing.Point(1012, 50);
            this.txt_soluongnguoi.MaxLength = 32767;
            this.txt_soluongnguoi.Name = "txt_soluongnguoi";
            this.txt_soluongnguoi.PasswordChar = '\0';
            this.txt_soluongnguoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_soluongnguoi.SelectedText = "";
            this.txt_soluongnguoi.Size = new System.Drawing.Size(144, 35);
            this.txt_soluongnguoi.TabIndex = 9;
            this.txt_soluongnguoi.UseCustomForeColor = true;
            this.txt_soluongnguoi.UseSelectable = true;
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_maphieu.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_maphieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_maphieu.Lines = new string[0];
            this.txt_maphieu.Location = new System.Drawing.Point(17, 50);
            this.txt_maphieu.MaxLength = 32767;
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.PasswordChar = '\0';
            this.txt_maphieu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_maphieu.SelectedText = "";
            this.txt_maphieu.Size = new System.Drawing.Size(144, 35);
            this.txt_maphieu.TabIndex = 9;
            this.txt_maphieu.UseCustomForeColor = true;
            this.txt_maphieu.UseSelectable = true;
            // 
            // dgv_khach
            // 
            this.dgv_khach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_khach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_khach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_khach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_khach.Location = new System.Drawing.Point(24, 507);
            this.dgv_khach.Name = "dgv_khach";
            this.dgv_khach.RowTemplate.Height = 24;
            this.dgv_khach.Size = new System.Drawing.Size(1184, 235);
            this.dgv_khach.TabIndex = 13;
            this.dgv_khach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khach_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKHACH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHACH";
            this.Column2.HeaderText = "Tên khách hàng";
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
            this.Column5.DataPropertyName = "CMND";
            this.Column5.HeaderText = "Số CMND/Hộ chiếu";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "QUOCTICH";
            this.Column6.HeaderText = "Quốc tịch";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DIACHI";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.Name = "Column7";
            // 
            // btn_dkthue
            // 
            this.btn_dkthue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dkthue.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_dkthue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dkthue.Location = new System.Drawing.Point(344, 774);
            this.btn_dkthue.Name = "btn_dkthue";
            this.btn_dkthue.Size = new System.Drawing.Size(239, 54);
            this.btn_dkthue.TabIndex = 13;
            this.btn_dkthue.Text = "Đăng kí thuê";
            this.btn_dkthue.UseCustomBackColor = true;
            this.btn_dkthue.UseCustomForeColor = true;
            this.btn_dkthue.UseSelectable = true;
            this.btn_dkthue.Click += new System.EventHandler(this.btn_dkthue_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_huy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_huy.Location = new System.Drawing.Point(704, 774);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(239, 54);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseCustomBackColor = true;
            this.btn_huy.UseCustomForeColor = true;
            this.btn_huy.UseSelectable = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // dt_ngaylap
            // 
            this.dt_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaylap.Location = new System.Drawing.Point(458, 50);
            this.dt_ngaylap.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_ngaylap.Name = "dt_ngaylap";
            this.dt_ngaylap.Size = new System.Drawing.Size(112, 30);
            this.dt_ngaylap.TabIndex = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel13.Location = new System.Drawing.Point(457, 18);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(71, 20);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "Ngày lập";
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // frm_dangkiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 851);
            this.Controls.Add(this.dgv_khach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dkthue);
            this.Controls.Add(this.txt_NVlap);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.MaximizeBox = false;
            this.Name = "frm_dangkiphong";
            this.Text = "Đăng kí";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_dangkiphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_NVlap;
        private MetroFramework.Controls.MetroDateTime dt_ngaythue;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dt_ngaytra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_maphong;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime dt_ngaysinh;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_tenkh;
        private MetroFramework.Controls.MetroTextBox txt_makh;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_diachi;
        private MetroFramework.Controls.MetroRadioButton rbtn_nu;
        private MetroFramework.Controls.MetroRadioButton rbtn_nam;
        private MetroFramework.Controls.MetroTextBox txt_cmnd;
        private MetroFramework.Controls.MetroTextBox txt_quoctich;
        private System.Windows.Forms.DataGridView dgv_khach;
        private MetroFramework.Controls.MetroButton btn_xoa;
        private MetroFramework.Controls.MetroButton btn_sua;
        private MetroFramework.Controls.MetroButton btn_them;
        private MetroFramework.Controls.MetroButton btn_dkthue;
        private MetroFramework.Controls.MetroButton btn_huy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private MetroFramework.Controls.MetroButton btn_luu;
        private MetroFramework.Controls.MetroButton btn_KHhuy;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_maphieu;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txt_soluongnguoi;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime dt_ngaylap;
    }
}