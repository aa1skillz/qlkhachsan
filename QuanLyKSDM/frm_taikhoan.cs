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
    public partial class frm_taikhoan : MetroForm
    {
        public frm_taikhoan()
        {
            InitializeComponent();
        }
        public static string taikhoan;
        BUS_DangNhap dn = new BUS_DangNhap();
        private void frm_taikhoan_Load(object sender, EventArgs e)
        {
            grb_doimk.Hide();
            lbl_user.Text=taikhoan;
            lbl_name.Text = dn.getName(taikhoan).Rows[0]["TENNV"].ToString();


        }
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            grb_doimk.Show();
        }

        private void btn_lưu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mkc.Text)){
                MetroMessageBox.Show(this, "Vui lòng nhập mật khẩu cũ", "Chú ý!");
                txt_mkc.Focus();
            }
            else if (txt_mkc.Text != dn.getPass(taikhoan).Rows[0]["PASSWORD"].ToString())
            {
                MetroMessageBox.Show(this, "Sai mật khẩu cũ", "Chú ý!");
                txt_mkc.Focus();
            }
            else if (String.IsNullOrEmpty(txt_mkm.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng nhập mật khẩu mới", "Chú ý!");
                txt_mkm.Focus();
            }
            else if (txt_rmkm.Text != txt_mkm.Text)
            {
                MetroMessageBox.Show(this, "Mật khẩu không khớp", "Chú ý!");
                txt_rmkm.Focus();
            }
            else
            {
                if (dn.doiMK(taikhoan, txt_mkm.Text))
                {
                    MetroMessageBox.Show(this, "Cập nhật thành công", "Thông báo!");
                    grb_doimk.Hide();
                    frm_taikhoan_Load(sender, e);
                }
                else
                {
                    MetroMessageBox.Show(this, "Cập nhật thất bại", "Thông báo!");
                }
             
            }
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            grb_doimk.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
