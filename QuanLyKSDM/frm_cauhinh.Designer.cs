namespace QuanLyKSDM
{
    partial class frm_cauhinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cauhinh));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKetNoi = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbbAuthentication = new MetroFramework.Controls.MetroComboBox();
            this.cbbDatabase = new MetroFramework.Controls.MetroComboBox();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.cbbServerName = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKetNoi.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKetNoi.ForeColor = System.Drawing.Color.White;
            this.btnKetNoi.Location = new System.Drawing.Point(354, 373);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(273, 40);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseCustomBackColor = true;
            this.btnKetNoi.UseCustomForeColor = true;
            this.btnKetNoi.UseSelectable = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(208, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Server Name:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(208, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Authentication:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(208, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "User Name:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(208, 227);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "PassWord:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Lines = new string[] {
        "sa"};
            this.txtUserName.Location = new System.Drawing.Point(355, 169);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(272, 31);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "sa";
            this.txtUserName.UseSelectable = true;
            // 
            // txtPassWord
            // 
            this.txtPassWord.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassWord.Lines = new string[] {
        "12345678"};
            this.txtPassWord.Location = new System.Drawing.Point(355, 218);
            this.txtPassWord.MaxLength = 32767;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(272, 31);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "12345678";
            this.txtPassWord.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel5.Location = new System.Drawing.Point(208, 323);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 20);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Database";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // cbbAuthentication
            // 
            this.cbbAuthentication.FormattingEnabled = true;
            this.cbbAuthentication.ItemHeight = 24;
            this.cbbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbbAuthentication.Location = new System.Drawing.Point(355, 124);
            this.cbbAuthentication.Name = "cbbAuthentication";
            this.cbbAuthentication.Size = new System.Drawing.Size(272, 30);
            this.cbbAuthentication.TabIndex = 4;
            this.cbbAuthentication.UseSelectable = true;
            this.cbbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbbAuthentication_SelectedIndexChanged);
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.ItemHeight = 24;
            this.cbbDatabase.Location = new System.Drawing.Point(355, 316);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(272, 30);
            this.cbbDatabase.TabIndex = 4;
            this.cbbDatabase.UseSelectable = true;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(433, 266);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 31);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Thử kết nối";
            this.btnTest.UseCustomBackColor = true;
            this.btnTest.UseCustomForeColor = true;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbbServerName
            // 
            this.cbbServerName.FormattingEnabled = true;
            this.cbbServerName.ItemHeight = 24;
            this.cbbServerName.Location = new System.Drawing.Point(354, 82);
            this.cbbServerName.Name = "cbbServerName";
            this.cbbServerName.Size = new System.Drawing.Size(270, 30);
            this.cbbServerName.TabIndex = 5;
            this.cbbServerName.UseSelectable = true;
            // 
            // frm_cauhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 435);
            this.Controls.Add(this.cbbServerName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbAuthentication);
            this.Controls.Add(this.cbbDatabase);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cauhinh";
            this.Text = "Thiết lập cấu hình";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_cauhinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnKetNoi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassWord;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbbAuthentication;
        private MetroFramework.Controls.MetroComboBox cbbDatabase;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroComboBox cbbServerName;
    }
}