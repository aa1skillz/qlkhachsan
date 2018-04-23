using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using BUS;

namespace QuanLyKSDM
{
    public partial class frm_TKPhong : MetroForm
    {
        public frm_TKPhong()
        {
            InitializeComponent();
        }
        BUS_TimKiemPhong busTKP = new BUS_TimKiemPhong();
        private void frm_TKPhong_Load(object sender, EventArgs e)
        {
            load_cbb();
        }
        private void load_cbb()
        {
            cbb_ma.DataSource = busTKP.getMa();
            cbb_ma.DisplayMember = "MAPHONG";
            cbb_ma.ValueMember = "MAPHONG";
            cbb_loaiphong.DataSource = busTKP.getPhong();
            cbb_loaiphong.DisplayMember = "TENLOAIPHONG";
            cbb_loaiphong.ValueMember = "TENLOAIPHONG";
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (rbtn_theoma.Checked != true && rbn_theoTen.Checked != true)
                MetroMessageBox.Show(this, "Mời chọn phương thức tìm kiếm!", "Chú ý!");
            else
            {
                if (rbtn_theoma.Checked == true)
                {
                    cbb_ma.Enabled = true;
                    cbb_loaiphong.Enabled = false;
                    dgv_ttKh.DataSource = busTKP.tktM(cbb_ma.Text);
                }
                else if (rbn_theoTen.Checked == true)
                {
                    cbb_ma.Enabled = false;
                    cbb_loaiphong.Enabled = true;
                    dgv_ttKh.DataSource = busTKP.tktT(cbb_loaiphong.Text);
                }

            }
        }

        private void rbtn_theoma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_theoma.Checked == true)
            {
                cbb_ma.Enabled = true;
                cbb_loaiphong.Enabled = false;

            }
            else if (rbn_theoTen.Checked == true)
            {
                cbb_ma.Enabled = false;
                cbb_loaiphong.Enabled = true;
            }
        }

        private void rbn_theoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_theoma.Checked == true)
            {
                cbb_ma.Enabled = true;
                cbb_loaiphong.Enabled = false;

            }
            else if (rbn_theoTen.Checked == true)
            {
                cbb_ma.Enabled = false;
                cbb_loaiphong.Enabled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
