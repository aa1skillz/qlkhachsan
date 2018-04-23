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
using DTO;
using MetroFramework;
using System.Text.RegularExpressions;

namespace QuanLyKSDM
{
    public partial class frm_phong : MetroForm
    {
        public frm_phong()
        {
            InitializeComponent();
        }
        BUS_Phong bus_phong = new BUS_Phong();
        DTO_Phong dto_phong = new DTO_Phong();
        private void frm_phong_Load(object sender, EventArgs e)
        {
            dgv_phong.DataSource = bus_phong.GetPhong();
            load_cbbTenPhong();
            btn_hien();
        }
        private void clear()
        {
            txt_sdt.Clear();
            txt_maphong.Clear();
            dgv_phong.Enabled = true;

        }
        private void load_cbbTenPhong()
        {
            cbb_loaiphong.DataSource = bus_phong.GetTenPhong();
            cbb_loaiphong.DisplayMember = "TENLOAIPHONG";
            cbb_loaiphong.ValueMember = "MALOAIPHONG";
        }
        private void dgv_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_maphong.Text = dgv_phong.Rows[i].Cells[0].Value.ToString();
                cbb_loaiphong.Text = dgv_phong.Rows[i].Cells[1].Value.ToString();
                if (String.Compare(dgv_phong.Rows[i].Cells[2].Value.ToString(), "TRỐNG", true) == 0)
                {
                    rbtn_trong.Checked = true;
                    rbt_khongtrong.Checked = false;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                }
                else
                {
                    rbtn_trong.Checked = false;
                    rbt_khongtrong.Checked = true;
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;

                }
                txt_sdt.Text = dgv_phong.Rows[i].Cells[3].Value.ToString();
            }
        }
        private int key;
        private void btn_hien()
        {
            btn_luu.Hide();
            btn_huy.Hide();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
        }

        private void btn_an()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = false;
            btn_luu.Show();
            btn_huy.Show();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_maphong.Text = bus_phong.tutangMPhong();
            txt_maphong.Enabled = false;
            btn_an();
            key = 1;
            dgv_phong.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (!Batloinhap())
                {
                    dto_phong.Maphong = txt_maphong.Text;
                    
                    dto_phong.Maloaiphong = cbb_loaiphong.SelectedValue.ToString();
                    MessageBox.Show(dto_phong.Maloaiphong);

                    if (rbtn_trong.Checked == true)
                        dto_phong.Tinhtrang = "TRỐNG";
                    else if (rbt_khongtrong.Checked == true)
                    {
                        dto_phong.Tinhtrang = "KHÔNG TRỐNG";
                    }
                    dto_phong.Sodienthoai = txt_sdt.Text;
                    if (bus_phong.themPhong(dto_phong))
                    {
                        MetroMessageBox.Show(this, "Thêm thành công", "Thông báo!");
                        clear();
                        frm_phong_Load(sender, e);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Thêm thất bại", "Thông báo!");
                    }
                }
            }

            if(key==2)
            {
                 if (!Batloinhap())
                 {
                     dto_phong.Maphong = txt_maphong.Text;
                     dto_phong.Maloaiphong = cbb_loaiphong.SelectedValue.ToString();

                     if (rbtn_trong.Checked == true)
                         dto_phong.Tinhtrang = "TRỐNG";
                     else if (rbt_khongtrong.Checked == true)
                     {
                         dto_phong.Tinhtrang = "KHÔNG TRỐNG";
                     }
                     dto_phong.Sodienthoai = txt_sdt.Text;
                     if (bus_phong.suaPhong(dto_phong))
                     {
                         MetroMessageBox.Show(this, "Cập nhật thành công", "Thông báo!");
                         clear();
                         frm_phong_Load(sender, e);
                     }
                     else
                     {
                         MetroMessageBox.Show(this, "Cập nhật thất bại", "Thông báo!");
                     }
                 }
            }
            if (key == 3)
            {
                dto_phong.Maphong = txt_maphong.Text;
                if(bus_phong.xoaPhong(dto_phong))
                {
                    MetroMessageBox.Show(this, "Xóa thành công", "Thông báo!");
                    clear();
                    frm_phong_Load(sender, e);
                }
                else
                {
                    MetroMessageBox.Show(this, "Xóa thất bại", "Thông báo!");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_maphong.Text))
                MetroMessageBox.Show(this,"Chọn phòng cần cập nhật thông tin","Chú ý!");
            key = 2;
            txt_maphong.Enabled = false;
            btn_an();
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_maphong.Text))
                MetroMessageBox.Show(this, "Chọn phòng cần xóa", "Chú ý!");
            key = 3;
            btn_an();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Batloinhap()
        {
         if (String.IsNullOrEmpty(txt_sdt.Text))
            {

                MetroMessageBox.Show(this, "Số điện thoại không được bỏ trống", "Chú ý!");
                txt_sdt.Focus();
                return true;

            }

            else if (!KiemTraSDT(txt_sdt.Text))
            {
                MetroMessageBox.Show(this, "Số điện thoại không đúng", "Chú ý!");
                txt_sdt.Focus();
                return true;
            }
            return false;
        }
        private bool KiemTraSDT(string sdt)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(sdt);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            btn_hien();
            clear();
        }
        
    }
}
