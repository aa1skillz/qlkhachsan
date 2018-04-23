namespace QuanLyKSDM
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.btn_dangnhap = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ckb_showpass = new MetroFramework.Controls.MetroCheckBox();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.btnCauhinh = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dangnhap.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(40, 273);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(288, 46);
            this.btn_dangnhap.TabIndex = 6;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseCustomBackColor = true;
            this.btn_dangnhap.UseCustomForeColor = true;
            this.btn_dangnhap.UseSelectable = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(40, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tài khoản";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(40, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mật khẩu";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // ckb_showpass
            // 
            this.ckb_showpass.AutoSize = true;
            this.ckb_showpass.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.ckb_showpass.ForeColor = System.Drawing.Color.Black;
            this.ckb_showpass.Location = new System.Drawing.Point(40, 231);
            this.ckb_showpass.Name = "ckb_showpass";
            this.ckb_showpass.Size = new System.Drawing.Size(121, 20);
            this.ckb_showpass.TabIndex = 4;
            this.ckb_showpass.Text = "Hiện mật khẩu";
            this.ckb_showpass.UseCustomForeColor = true;
            this.ckb_showpass.UseSelectable = true;
            this.ckb_showpass.CheckedChanged += new System.EventHandler(this.ckb_showpass_CheckedChanged);
            // 
            // txt_user
            // 
            this.txt_user.Lines = new string[0];
            this.txt_user.Location = new System.Drawing.Point(40, 65);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(288, 35);
            this.txt_user.TabIndex = 1;
            this.txt_user.UseSelectable = true;
            // 
            // txt_password
            // 
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(40, 166);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(288, 35);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSelectable = true;
            // 
            // btnCauhinh
            // 
            this.btnCauhinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCauhinh.BackgroundImage")));
            this.btnCauhinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCauhinh.Location = new System.Drawing.Point(281, 221);
            this.btnCauhinh.Name = "btnCauhinh";
            this.btnCauhinh.Size = new System.Drawing.Size(47, 46);
            this.btnCauhinh.TabIndex = 5;
            this.btnCauhinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCauhinh.UseSelectable = true;
            this.btnCauhinh.Click += new System.EventHandler(this.btnCauhinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.btnCauhinh);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.ckb_showpass);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.btn_dangnhap);
            this.groupBox1.Location = new System.Drawing.Point(33, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frm_dangnhap
            // 
            this.AcceptButton = this.btn_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 497);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_dangnhap";
            this.Text = "Đăng nhập hệ thống";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_dangnhap;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox ckb_showpass;
        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroButton btnCauhinh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}