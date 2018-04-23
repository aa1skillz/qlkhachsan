namespace QuanLyKSDM
{
    partial class frm_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phong));
            this.dgv_phong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_loaiphong = new MetroFramework.Controls.MetroComboBox();
            this.rbt_khongtrong = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_trong = new MetroFramework.Controls.MetroRadioButton();
            this.txt_sdt = new MetroFramework.Controls.MetroTextBox();
            this.txt_maphong = new MetroFramework.Controls.MetroTextBox();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.btn_luu = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_them = new MetroFramework.Controls.MetroButton();
            this.btn_sua = new MetroFramework.Controls.MetroButton();
            this.btn_xoa = new MetroFramework.Controls.MetroButton();
            this.btn_thoat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_phong
            // 
            this.dgv_phong.AllowUserToAddRows = false;
            this.dgv_phong.AllowUserToDeleteRows = false;
            this.dgv_phong.AllowUserToResizeColumns = false;
            this.dgv_phong.AllowUserToResizeRows = false;
            this.dgv_phong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_phong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_phong.Location = new System.Drawing.Point(23, 352);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowTemplate.Height = 24;
            this.dgv_phong.Size = new System.Drawing.Size(751, 233);
            this.dgv_phong.TabIndex = 7;
            this.dgv_phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPHONG";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAIPHONG";
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TINHTRANG";
            this.Column3.HeaderText = "Tình trạng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_loaiphong);
            this.groupBox1.Controls.Add(this.rbt_khongtrong);
            this.groupBox1.Controls.Add(this.rbtn_trong);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 226);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.ItemHeight = 24;
            this.cbb_loaiphong.Items.AddRange(new object[] {
            "Vip",
            "Bình dân",
            "Trung bình"});
            this.cbb_loaiphong.Location = new System.Drawing.Point(160, 87);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(197, 30);
            this.cbb_loaiphong.TabIndex = 11;
            this.cbb_loaiphong.UseSelectable = true;
            // 
            // rbt_khongtrong
            // 
            this.rbt_khongtrong.AutoSize = true;
            this.rbt_khongtrong.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbt_khongtrong.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbt_khongtrong.ForeColor = System.Drawing.Color.Black;
            this.rbt_khongtrong.Location = new System.Drawing.Point(243, 142);
            this.rbt_khongtrong.Name = "rbt_khongtrong";
            this.rbt_khongtrong.Size = new System.Drawing.Size(114, 20);
            this.rbt_khongtrong.TabIndex = 9;
            this.rbt_khongtrong.Text = "Không trống";
            this.rbt_khongtrong.UseCustomForeColor = true;
            this.rbt_khongtrong.UseSelectable = true;
            // 
            // rbtn_trong
            // 
            this.rbtn_trong.AutoSize = true;
            this.rbtn_trong.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtn_trong.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtn_trong.ForeColor = System.Drawing.Color.Black;
            this.rbtn_trong.Location = new System.Drawing.Point(159, 142);
            this.rbtn_trong.Name = "rbtn_trong";
            this.rbtn_trong.Size = new System.Drawing.Size(66, 20);
            this.rbtn_trong.TabIndex = 10;
            this.rbtn_trong.Text = "Trống";
            this.rbtn_trong.UseCustomForeColor = true;
            this.rbtn_trong.UseSelectable = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Lines = new string[0];
            this.txt_sdt.Location = new System.Drawing.Point(162, 176);
            this.txt_sdt.MaxLength = 32767;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.Size = new System.Drawing.Size(197, 35);
            this.txt_sdt.TabIndex = 8;
            this.txt_sdt.UseSelectable = true;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Lines = new string[0];
            this.txt_maphong.Location = new System.Drawing.Point(160, 33);
            this.txt_maphong.MaxLength = 32767;
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.PasswordChar = '\0';
            this.txt_maphong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_maphong.SelectedText = "";
            this.txt_maphong.Size = new System.Drawing.Size(144, 35);
            this.txt_maphong.TabIndex = 8;
            this.txt_maphong.UseSelectable = true;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_huy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(455, 130);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(94, 32);
            this.btn_huy.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseCustomBackColor = true;
            this.btn_huy.UseCustomForeColor = true;
            this.btn_huy.UseSelectable = true;
            this.btn_huy.UseStyleColors = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_luu.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(455, 76);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(94, 32);
            this.btn_luu.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseCustomBackColor = true;
            this.btn_luu.UseCustomForeColor = true;
            this.btn_luu.UseSelectable = true;
            this.btn_luu.UseStyleColors = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(12, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Số điện thoại";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(12, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Mã phòng";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(12, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Tình trạng";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(12, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Loại phòng";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_thoat);
            this.groupBox5.Location = new System.Drawing.Point(623, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 226);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_them.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(27, 31);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 32);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_them.UseCustomBackColor = true;
            this.btn_them.UseCustomForeColor = true;
            this.btn_them.UseSelectable = true;
            this.btn_them.UseStyleColors = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_sua.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(27, 76);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 32);
            this.btn_sua.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseCustomBackColor = true;
            this.btn_sua.UseCustomForeColor = true;
            this.btn_sua.UseSelectable = true;
            this.btn_sua.UseStyleColors = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(27, 121);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 32);
            this.btn_xoa.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseCustomBackColor = true;
            this.btn_xoa.UseCustomForeColor = true;
            this.btn_xoa.UseSelectable = true;
            this.btn_xoa.UseStyleColors = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(27, 166);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 32);
            this.btn_thoat.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseCustomBackColor = true;
            this.btn_thoat.UseCustomForeColor = true;
            this.btn_thoat.UseSelectable = true;
            this.btn_thoat.UseStyleColors = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 614);
            this.Controls.Add(this.dgv_phong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_phong";
            this.Text = "Quản lý phòng";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phong;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_maphong;
        private MetroFramework.Controls.MetroButton btn_huy;
        private MetroFramework.Controls.MetroButton btn_luu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btn_them;
        private MetroFramework.Controls.MetroButton btn_sua;
        private MetroFramework.Controls.MetroButton btn_xoa;
        private MetroFramework.Controls.MetroButton btn_thoat;
        private MetroFramework.Controls.MetroComboBox cbb_loaiphong;
        private MetroFramework.Controls.MetroRadioButton rbt_khongtrong;
        private MetroFramework.Controls.MetroRadioButton rbtn_trong;
        private MetroFramework.Controls.MetroTextBox txt_sdt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}