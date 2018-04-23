using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using BUS;
using DTO;

namespace QuanLyKSDM
{
    public partial class frm_dangnhap : MetroForm
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text))
            {
                MetroMessageBox.Show(this, "Tên đăng nhập không được để trống", "Thông báo");
                txt_user.Focus();
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
            {
                MetroMessageBox.Show(this, "Mật khẩu không được để trống", "Thông báo");
                txt_password.Focus();
            }
            else
            {
                
                BUS_DangNhap BUS_DangNhap = new BUS_DangNhap();
                DTO_DangNhap dtoDangNhap = new DTO_DangNhap(txt_user.Text);

                dtoDangNhap.User = txt_user.Text;
                dtoDangNhap.Password = txt_password.Text;
                if (BUS_DangNhap.iCheckTaiKhoan(dtoDangNhap))
                {
                    this.Hide();
                    frm_home frm_home = new frm_home();
                    frm_home.QuyenNguoiDung = BUS_DangNhap.getCV(dtoDangNhap).Rows[0]["CHUCVU"].ToString();
                    frm_taikhoan.taikhoan = txt_user.Text;
                    frm_home.TaiKhoan = txt_user.Text;
                    frm_home.ShowDialog();
                }
                else
                {
                    MetroMessageBox.Show(this, "Đăng nhập thất bại! Kiểm tra lại tên đăng nhập hoặc mật khẩu", "Thông báo");
                }

            }
        }
        private void btnCauhinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cauhinh frmch = new frm_cauhinh();
            frmch.ShowDialog();
        }

        private void ckb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_showpass.Checked == true)
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';
        }
        

    }
}
