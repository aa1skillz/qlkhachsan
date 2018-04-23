namespace QuanLyKSDM
{
    partial class frm_dichvu
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dt_nsd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.cbb_dv = new System.Windows.Forms.ComboBox();
            this.dmup_sl = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(82, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ngày sử dụng :";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mns
            // 
            this.mns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns.Name = "mns";
            this.mns.Size = new System.Drawing.Size(67, 4);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton2.Location = new System.Drawing.Point(142, 576);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(264, 40);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Thoát";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dt_nsd
            // 
            this.dt_nsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nsd.Location = new System.Drawing.Point(245, 34);
            this.dt_nsd.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_nsd.Name = "dt_nsd";
            this.dt_nsd.Size = new System.Drawing.Size(153, 30);
            this.dt_nsd.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(82, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên dịch vụ:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(82, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Số lượng:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton3.Location = new System.Drawing.Point(142, 516);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(264, 40);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Thêm";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // cbb_dv
            // 
            this.cbb_dv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_dv.FormattingEnabled = true;
            this.cbb_dv.Location = new System.Drawing.Point(245, 86);
            this.cbb_dv.Name = "cbb_dv";
            this.cbb_dv.Size = new System.Drawing.Size(153, 28);
            this.cbb_dv.TabIndex = 5;
            // 
            // dmup_sl
            // 
            this.dmup_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmup_sl.Items.Add("1");
            this.dmup_sl.Items.Add("2");
            this.dmup_sl.Items.Add("3");
            this.dmup_sl.Items.Add("4");
            this.dmup_sl.Items.Add("5");
            this.dmup_sl.Items.Add("6");
            this.dmup_sl.Items.Add("7");
            this.dmup_sl.Items.Add("8");
            this.dmup_sl.Items.Add("9");
            this.dmup_sl.Items.Add("10");
            this.dmup_sl.Items.Add("11");
            this.dmup_sl.Items.Add("12");
            this.dmup_sl.Items.Add("13");
            this.dmup_sl.Items.Add("14");
            this.dmup_sl.Items.Add("15");
            this.dmup_sl.Items.Add("16");
            this.dmup_sl.Items.Add("17");
            this.dmup_sl.Items.Add("18");
            this.dmup_sl.Items.Add("19");
            this.dmup_sl.Items.Add("20");
            this.dmup_sl.Items.Add("21");
            this.dmup_sl.Items.Add("22");
            this.dmup_sl.Items.Add("23");
            this.dmup_sl.Items.Add("24");
            this.dmup_sl.Items.Add("25");
            this.dmup_sl.Items.Add("26");
            this.dmup_sl.Items.Add("27");
            this.dmup_sl.Items.Add("28");
            this.dmup_sl.Items.Add("29");
            this.dmup_sl.Items.Add("30");
            this.dmup_sl.Items.Add("31");
            this.dmup_sl.Items.Add("32");
            this.dmup_sl.Items.Add("33");
            this.dmup_sl.Items.Add("34");
            this.dmup_sl.Items.Add("35");
            this.dmup_sl.Items.Add("36");
            this.dmup_sl.Items.Add("37");
            this.dmup_sl.Items.Add("38");
            this.dmup_sl.Items.Add("39");
            this.dmup_sl.Items.Add("40");
            this.dmup_sl.Items.Add("41");
            this.dmup_sl.Items.Add("42");
            this.dmup_sl.Items.Add("43");
            this.dmup_sl.Items.Add("44");
            this.dmup_sl.Items.Add("45");
            this.dmup_sl.Items.Add("46");
            this.dmup_sl.Items.Add("47");
            this.dmup_sl.Items.Add("48");
            this.dmup_sl.Items.Add("49");
            this.dmup_sl.Items.Add("50");
            this.dmup_sl.Items.Add("51");
            this.dmup_sl.Items.Add("52");
            this.dmup_sl.Items.Add("53");
            this.dmup_sl.Items.Add("54");
            this.dmup_sl.Items.Add("55");
            this.dmup_sl.Items.Add("56");
            this.dmup_sl.Items.Add("57");
            this.dmup_sl.Items.Add("58");
            this.dmup_sl.Items.Add("59");
            this.dmup_sl.Items.Add("60");
            this.dmup_sl.Items.Add("61");
            this.dmup_sl.Items.Add("62");
            this.dmup_sl.Items.Add("63");
            this.dmup_sl.Items.Add("64");
            this.dmup_sl.Items.Add("65");
            this.dmup_sl.Items.Add("66");
            this.dmup_sl.Items.Add("67");
            this.dmup_sl.Items.Add("68");
            this.dmup_sl.Items.Add("69");
            this.dmup_sl.Items.Add("70");
            this.dmup_sl.Items.Add("71");
            this.dmup_sl.Items.Add("72");
            this.dmup_sl.Items.Add("73");
            this.dmup_sl.Items.Add("74");
            this.dmup_sl.Items.Add("75");
            this.dmup_sl.Items.Add("76");
            this.dmup_sl.Items.Add("77");
            this.dmup_sl.Items.Add("78");
            this.dmup_sl.Items.Add("79");
            this.dmup_sl.Items.Add("80");
            this.dmup_sl.Items.Add("81");
            this.dmup_sl.Items.Add("82");
            this.dmup_sl.Items.Add("83");
            this.dmup_sl.Items.Add("84");
            this.dmup_sl.Items.Add("85");
            this.dmup_sl.Items.Add("86");
            this.dmup_sl.Items.Add("87");
            this.dmup_sl.Items.Add("88");
            this.dmup_sl.Items.Add("89");
            this.dmup_sl.Items.Add("90");
            this.dmup_sl.Items.Add("91");
            this.dmup_sl.Items.Add("92");
            this.dmup_sl.Items.Add("93");
            this.dmup_sl.Items.Add("94");
            this.dmup_sl.Items.Add("95");
            this.dmup_sl.Items.Add("96");
            this.dmup_sl.Items.Add("97");
            this.dmup_sl.Items.Add("98");
            this.dmup_sl.Items.Add("99");
            this.dmup_sl.Location = new System.Drawing.Point(245, 133);
            this.dmup_sl.Name = "dmup_sl";
            this.dmup_sl.Size = new System.Drawing.Size(152, 27);
            this.dmup_sl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dmup_sl);
            this.groupBox1.Controls.Add(this.cbb_dv);
            this.groupBox1.Controls.Add(this.dt_nsd);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dgv_dv
            // 
            this.dgv_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_dv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_dv.Location = new System.Drawing.Point(23, 281);
            this.dgv_dv.Name = "dgv_dv";
            this.dgv_dv.RowTemplate.Height = 24;
            this.dgv_dv.Size = new System.Drawing.Size(485, 217);
            this.dgv_dv.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENDV";
            this.Column1.HeaderText = "Tên dịch vụ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DONGIA";
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLDV";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYTHUE";
            this.Column4.HeaderText = "Ngày sử dụng";
            this.Column4.Name = "Column4";
            // 
            // frm_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 640);
            this.Controls.Add(this.dgv_dv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton3);
            this.Name = "frm_dichvu";
            this.Text = "Dịch vụ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_dichvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ContextMenuStrip mns;
        private MetroFramework.Controls.MetroDateTime dt_nsd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ComboBox cbb_dv;
        private System.Windows.Forms.DomainUpDown dmup_sl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}