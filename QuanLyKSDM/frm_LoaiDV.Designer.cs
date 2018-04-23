namespace QuanLyKSDM
{
    partial class frm_LoaiDV
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
            this.btn_them = new MetroFramework.Controls.MetroButton();
            this.btn_sua = new MetroFramework.Controls.MetroButton();
            this.btn_thoat = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new MetroFramework.Controls.MetroButton();
            this.txt_dongia = new MetroFramework.Controls.MetroTextBox();
            this.txt_madv = new MetroFramework.Controls.MetroTextBox();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.btn_luu = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgv_loaiDV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tendv = new MetroFramework.Controls.MetroTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_them.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(28, 18);
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
            this.btn_sua.Location = new System.Drawing.Point(28, 63);
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
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(28, 153);
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
            this.groupBox5.Location = new System.Drawing.Point(644, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 203);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(28, 108);
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
            // txt_dongia
            // 
            this.txt_dongia.Lines = new string[0];
            this.txt_dongia.Location = new System.Drawing.Point(161, 139);
            this.txt_dongia.MaxLength = 32767;
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PasswordChar = '\0';
            this.txt_dongia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dongia.SelectedText = "";
            this.txt_dongia.Size = new System.Drawing.Size(197, 35);
            this.txt_dongia.TabIndex = 8;
            this.txt_dongia.UseSelectable = true;
            // 
            // txt_madv
            // 
            this.txt_madv.Lines = new string[0];
            this.txt_madv.Location = new System.Drawing.Point(161, 33);
            this.txt_madv.MaxLength = 32767;
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.PasswordChar = '\0';
            this.txt_madv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_madv.SelectedText = "";
            this.txt_madv.Size = new System.Drawing.Size(144, 35);
            this.txt_madv.TabIndex = 8;
            this.txt_madv.UseSelectable = true;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_huy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(456, 109);
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
            this.btn_luu.Location = new System.Drawing.Point(456, 55);
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
            this.metroLabel4.Location = new System.Drawing.Point(13, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Đơn giá";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(13, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Mã dịch vụ";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(13, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Tên dịch vụ";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // dgv_loaiDV
            // 
            this.dgv_loaiDV.AllowUserToAddRows = false;
            this.dgv_loaiDV.AllowUserToDeleteRows = false;
            this.dgv_loaiDV.AllowUserToResizeColumns = false;
            this.dgv_loaiDV.AllowUserToResizeRows = false;
            this.dgv_loaiDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaiDV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_loaiDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_loaiDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_loaiDV.Location = new System.Drawing.Point(34, 300);
            this.dgv_loaiDV.Name = "dgv_loaiDV";
            this.dgv_loaiDV.RowTemplate.Height = 24;
            this.dgv_loaiDV.Size = new System.Drawing.Size(761, 196);
            this.dgv_loaiDV.TabIndex = 10;
            this.dgv_loaiDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiDV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.txt_tendv);
            this.groupBox1.Controls.Add(this.txt_madv);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(34, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Lines = new string[0];
            this.txt_tendv.Location = new System.Drawing.Point(161, 83);
            this.txt_tendv.MaxLength = 32767;
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.PasswordChar = '\0';
            this.txt_tendv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tendv.SelectedText = "";
            this.txt_tendv.Size = new System.Drawing.Size(175, 35);
            this.txt_tendv.TabIndex = 8;
            this.txt_tendv.UseSelectable = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADV";
            this.Column1.HeaderText = "Mã dịch vụ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDV";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // frm_LoaiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 532);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgv_loaiDV);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_LoaiDV";
            this.Text = "Quản Lý Dịch Vụ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_LoaiDV_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_them;
        private MetroFramework.Controls.MetroButton btn_sua;
        private MetroFramework.Controls.MetroButton btn_thoat;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btn_xoa;
        private MetroFramework.Controls.MetroTextBox txt_dongia;
        private MetroFramework.Controls.MetroTextBox txt_madv;
        private MetroFramework.Controls.MetroButton btn_huy;
        private MetroFramework.Controls.MetroButton btn_luu;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgv_loaiDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}