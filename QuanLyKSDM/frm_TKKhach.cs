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
using BUS;
using MetroFramework;

namespace QuanLyKSDM
{
    public partial class frm_TKKhach : MetroForm
    {
        public frm_TKKhach()
        {
            InitializeComponent();
        }
        BUS_TKKhach tkk = new BUS_TKKhach();
        private void frm_TKKhach_Load(object sender, EventArgs e)
        {
            load_cbb();
        }

        private void load_cbb()
        {
            cbb_ma.DataSource = tkk.Ma();
            cbb_ma.DisplayMember = "MAKHACH";
            cbb_ma.ValueMember = "MAKHACH";
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
                    txt_ten.Enabled = false;
                    dgv_ttKh.DataSource = tkk.tktM(cbb_ma.Text);
                }
                else if (rbn_theoTen.Checked == true)
                {
                    if (String.IsNullOrEmpty(txt_ten.Text))
                    {
                        MetroMessageBox.Show(this, "Vui lòng nhập tên khách cần tìm");
                        txt_ten.Focus();
                    }
                    else
                    {
                        cbb_ma.Enabled = false;
                        txt_ten.Enabled = true;
                        string ten = "%" + txt_ten.Text + "%";
                        dgv_ttKh.DataSource = tkk.tktT(ten);
                        txt_ten.Clear();
                    }

                }
            }
        }

        private void rbtn_theoma_CheckedChanged(object sender, EventArgs e)
        {
             if(rbtn_theoma.Checked==true)
            {  
                cbb_ma.Enabled = true;
                txt_ten.Enabled=false;
                
            }
            else if(rbn_theoTen.Checked==true)
            {
                    cbb_ma.Enabled = false;
                    txt_ten.Enabled = true;
                }
        }

        private void rbn_theoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_theoma.Checked == true)
            {
                cbb_ma.Enabled = true;
                txt_ten.Enabled = false;
            }
            else if (rbn_theoTen.Checked == true)
            {
                cbb_ma.Enabled = false;
                txt_ten.Enabled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
