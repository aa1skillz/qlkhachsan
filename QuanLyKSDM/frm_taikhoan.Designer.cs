namespace QuanLyKSDM
{
    partial class frm_taikhoan
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
            this.btn_doimk = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.grb_doimk = new System.Windows.Forms.GroupBox();
            this.txt_rmkm = new MetroFramework.Controls.MetroTextBox();
            this.btn_huy = new MetroFramework.Controls.MetroButton();
            this.btn_lưu = new MetroFramework.Controls.MetroButton();
            this.txt_mkm = new MetroFramework.Controls.MetroTextBox();
            this.txt_mkc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_thoat = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.grb_doimk.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(124, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên đăng nhập:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btn_doimk
            // 
            this.btn_doimk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_doimk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_doimk.ForeColor = System.Drawing.Color.Snow;
            this.btn_doimk.Location = new System.Drawing.Point(149, 295);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(125, 32);
            this.btn_doimk.TabIndex = 1;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseCustomBackColor = true;
            this.btn_doimk.UseCustomForeColor = true;
            this.btn_doimk.UseSelectable = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(124, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên nhân viên:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_user);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(308, 115);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(61, 24);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(308, 44);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(49, 24);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User";
            // 
            // grb_doimk
            // 
            this.grb_doimk.Controls.Add(this.txt_rmkm);
            this.grb_doimk.Controls.Add(this.btn_huy);
            this.grb_doimk.Controls.Add(this.btn_lưu);
            this.grb_doimk.Controls.Add(this.txt_mkm);
            this.grb_doimk.Controls.Add(this.txt_mkc);
            this.grb_doimk.Controls.Add(this.metroLabel5);
            this.grb_doimk.Controls.Add(this.metroLabel4);
            this.grb_doimk.Controls.Add(this.metroLabel3);
            this.grb_doimk.Location = new System.Drawing.Point(34, 333);
            this.grb_doimk.Name = "grb_doimk";
            this.grb_doimk.Size = new System.Drawing.Size(520, 276);
            this.grb_doimk.TabIndex = 3;
            this.grb_doimk.TabStop = false;
            // 
            // txt_rmkm
            // 
            this.txt_rmkm.Lines = new string[0];
            this.txt_rmkm.Location = new System.Drawing.Point(247, 139);
            this.txt_rmkm.MaxLength = 32767;
            this.txt_rmkm.Name = "txt_rmkm";
            this.txt_rmkm.PasswordChar = '*';
            this.txt_rmkm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_rmkm.SelectedText = "";
            this.txt_rmkm.Size = new System.Drawing.Size(191, 35);
            this.txt_rmkm.TabIndex = 1;
            this.txt_rmkm.UseSelectable = true;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_huy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_huy.ForeColor = System.Drawing.Color.Snow;
            this.btn_huy.Location = new System.Drawing.Point(299, 217);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(101, 32);
            this.btn_huy.TabIndex = 1;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseCustomBackColor = true;
            this.btn_huy.UseCustomForeColor = true;
            this.btn_huy.UseSelectable = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_lưu
            // 
            this.btn_lưu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_lưu.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_lưu.ForeColor = System.Drawing.Color.Snow;
            this.btn_lưu.Location = new System.Drawing.Point(149, 217);
            this.btn_lưu.Name = "btn_lưu";
            this.btn_lưu.Size = new System.Drawing.Size(91, 32);
            this.btn_lưu.TabIndex = 1;
            this.btn_lưu.Text = "Lưu";
            this.btn_lưu.UseCustomBackColor = true;
            this.btn_lưu.UseCustomForeColor = true;
            this.btn_lưu.UseSelectable = true;
            this.btn_lưu.Click += new System.EventHandler(this.btn_lưu_Click);
            // 
            // txt_mkm
            // 
            this.txt_mkm.Lines = new string[0];
            this.txt_mkm.Location = new System.Drawing.Point(247, 90);
            this.txt_mkm.MaxLength = 32767;
            this.txt_mkm.Name = "txt_mkm";
            this.txt_mkm.PasswordChar = '*';
            this.txt_mkm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mkm.SelectedText = "";
            this.txt_mkm.Size = new System.Drawing.Size(191, 35);
            this.txt_mkm.TabIndex = 1;
            this.txt_mkm.UseSelectable = true;
            // 
            // txt_mkc
            // 
            this.txt_mkc.Lines = new string[0];
            this.txt_mkc.Location = new System.Drawing.Point(189, 32);
            this.txt_mkc.MaxLength = 32767;
            this.txt_mkc.Name = "txt_mkc";
            this.txt_mkc.PasswordChar = '*';
            this.txt_mkc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mkc.SelectedText = "";
            this.txt_mkc.Size = new System.Drawing.Size(249, 35);
            this.txt_mkc.TabIndex = 1;
            this.txt_mkc.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel5.Location = new System.Drawing.Point(17, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(172, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Nhập lại mật khẩu mới:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(17, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Mật khẩu mới:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(17, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Mật khẩu cũ:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_thoat.ForeColor = System.Drawing.Color.Snow;
            this.btn_thoat.Location = new System.Drawing.Point(327, 295);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(145, 32);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseCustomBackColor = true;
            this.btn_thoat.UseCustomForeColor = true;
            this.btn_thoat.UseSelectable = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 632);
            this.Controls.Add(this.grb_doimk);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_taikhoan";
            this.Text = "Thông tin tài khoản";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_taikhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_doimk.ResumeLayout(false);
            this.grb_doimk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_doimk;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.GroupBox grb_doimk;
        private MetroFramework.Controls.MetroTextBox txt_rmkm;
        private MetroFramework.Controls.MetroButton btn_huy;
        private MetroFramework.Controls.MetroButton btn_lưu;
        private MetroFramework.Controls.MetroTextBox txt_mkm;
        private MetroFramework.Controls.MetroTextBox txt_mkc;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_thoat;
    }
}