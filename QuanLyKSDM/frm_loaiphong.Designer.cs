namespace QuanLyKSDM
{
    partial class frm_loaiphong
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
            this.btn_luu = new MetroFramework.Controls.MetroButton();
            this.btl_huy = new MetroFramework.Controls.MetroButton();
            this.btn_them = new MetroFramework.Controls.MetroButton();
            this.btn_sua = new MetroFramework.Controls.MetroButton();
            this.btn_xoa = new MetroFramework.Controls.MetroButton();
            this.btn_thoat = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_malp = new MetroFramework.Controls.MetroTextBox();
            this.txt_tenlp = new MetroFramework.Controls.MetroTextBox();
            this.txt_dongia = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_loaiphong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_luu.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(368, 62);
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
            // btl_huy
            // 
            this.btl_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btl_huy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btl_huy.ForeColor = System.Drawing.Color.White;
            this.btl_huy.Location = new System.Drawing.Point(368, 100);
            this.btl_huy.Name = "btl_huy";
            this.btl_huy.Size = new System.Drawing.Size(94, 32);
            this.btl_huy.Style = MetroFramework.MetroColorStyle.Orange;
            this.btl_huy.TabIndex = 3;
            this.btl_huy.Text = "Hủy";
            this.btl_huy.UseCustomBackColor = true;
            this.btl_huy.UseCustomForeColor = true;
            this.btl_huy.UseSelectable = true;
            this.btl_huy.UseStyleColors = true;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_them.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(27, 24);
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
            this.btn_sua.Location = new System.Drawing.Point(27, 62);
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
            this.btn_xoa.Location = new System.Drawing.Point(27, 100);
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
            this.btn_thoat.Location = new System.Drawing.Point(27, 138);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_thoat);
            this.groupBox5.Location = new System.Drawing.Point(513, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 189);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(13, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Đơn giá";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(13, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Tên loại phòng";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(13, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Mã loại phòng";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_malp
            // 
            this.txt_malp.Lines = new string[0];
            this.txt_malp.Location = new System.Drawing.Point(156, 28);
            this.txt_malp.MaxLength = 32767;
            this.txt_malp.Name = "txt_malp";
            this.txt_malp.PasswordChar = '\0';
            this.txt_malp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_malp.SelectedText = "";
            this.txt_malp.Size = new System.Drawing.Size(169, 35);
            this.txt_malp.TabIndex = 8;
            this.txt_malp.UseSelectable = true;
            // 
            // txt_tenlp
            // 
            this.txt_tenlp.Lines = new string[0];
            this.txt_tenlp.Location = new System.Drawing.Point(156, 82);
            this.txt_tenlp.MaxLength = 32767;
            this.txt_tenlp.Name = "txt_tenlp";
            this.txt_tenlp.PasswordChar = '\0';
            this.txt_tenlp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenlp.SelectedText = "";
            this.txt_tenlp.Size = new System.Drawing.Size(169, 35);
            this.txt_tenlp.TabIndex = 8;
            this.txt_tenlp.UseSelectable = true;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Lines = new string[0];
            this.txt_dongia.Location = new System.Drawing.Point(156, 134);
            this.txt_dongia.MaxLength = 32767;
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PasswordChar = '\0';
            this.txt_dongia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dongia.SelectedText = "";
            this.txt_dongia.Size = new System.Drawing.Size(169, 35);
            this.txt_dongia.TabIndex = 8;
            this.txt_dongia.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_malp);
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.btl_huy);
            this.groupBox1.Controls.Add(this.txt_tenlp);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dgv_loaiphong
            // 
            this.dgv_loaiphong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_loaiphong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_loaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_loaiphong.Location = new System.Drawing.Point(23, 289);
            this.dgv_loaiphong.Name = "dgv_loaiphong";
            this.dgv_loaiphong.RowTemplate.Height = 24;
            this.dgv_loaiphong.Size = new System.Drawing.Size(641, 233);
            this.dgv_loaiphong.TabIndex = 4;
            this.dgv_loaiphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiphong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAIPHONG";
            this.Column1.HeaderText = "Mã loại phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAIPHONG";
            this.Column2.HeaderText = "Tên loại phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // frm_loaiphong
            // 
            this.AcceptButton = this.btn_luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 555);
            this.Controls.Add(this.dgv_loaiphong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.Name = "frm_loaiphong";
            this.Text = "Loại phòng";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_loaiphong_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_luu;
        private MetroFramework.Controls.MetroButton btl_huy;
        private MetroFramework.Controls.MetroButton btn_them;
        private MetroFramework.Controls.MetroButton btn_sua;
        private MetroFramework.Controls.MetroButton btn_xoa;
        private MetroFramework.Controls.MetroButton btn_thoat;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_malp;
        private MetroFramework.Controls.MetroTextBox txt_tenlp;
        private MetroFramework.Controls.MetroTextBox txt_dongia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}