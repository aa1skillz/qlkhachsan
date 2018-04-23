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
using System.Text.RegularExpressions;
using DTO;
namespace QuanLyKSDM
{
    public partial class frm_LoaiDV : MetroForm
    {
        public frm_LoaiDV()
        {
            InitializeComponent();
        }
        BUS_DichVu busDV = new BUS_DichVu();
        DTO_DichVu dtoDV = new DTO_DichVu();
        private void frm_LoaiDV_Load(object sender, EventArgs e)
        {
            dgv_loaiDV.DataSource = busDV.getThongTinDV();
            btn_hien();
        }
        private void btn_hien()
        {
            btn_luu.Hide();
            btn_huy.Hide();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
        }

        private void clear()
        {
            txt_madv.Clear();
            txt_tendv.Clear();
            txt_dongia.Clear();
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
            clear();
            btn_an();
            dgv_loaiDV.Enabled = false;
            key = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_madv.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn loại dịch vụ cần sửa!!", "Thông báo !");
            }
            else
            {
                btn_an();
                txt_madv.Enabled = false;
                key = 2;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_madv.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn loại dịch vụ cần xóa!!", "Thông báo !");
            }
            else
            {
                btn_an();
                key = 3;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (batloinhap())
            {
                dtoDV.Madichvu = txt_madv.Text;
                dtoDV.Tendichvu = txt_tendv.Text;
                dtoDV.Dongia = float.Parse(txt_dongia.Text);
                if (key == 1)
                {
                    if (busDV.ktMDV(txt_madv.Text))

                        MetroMessageBox.Show(this, "Mã dịch vụ đã tồn tại!!", "Chú ý!");
                    else
                        if (busDV.them(dtoDV))
                        {
                            MetroMessageBox.Show(this, "Thêm thành công!", "Thông báo!");
                            dgv_loaiDV.Enabled = true;
                            frm_LoaiDV_Load(sender, e);
                            clear();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Thêm thất bại!", "Thông báo!");
                            dgv_loaiDV.Enabled = true;
                        }
                }

                else if (key == 2)
                {
                    if (busDV.capnhat(dtoDV))
                    {
                        MetroMessageBox.Show(this, "Cập nhật thành công!", "Thông báo!");
                        frm_LoaiDV_Load(sender, e);
                        clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Cập nhật thất bại!", "Thông báo!");
                    }
                }
                else if (key == 3)
                {
                    if (busDV.xoa(dtoDV))
                    {
                        MetroMessageBox.Show(this, "Xóa thành công!", "Thông báo!");
                        frm_LoaiDV_Load(sender, e);
                        clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Xóa thất bại!", "Thông báo!");
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            dgv_loaiDV.Enabled = true;
            clear();
            btn_hien();
        }
        private int key;
        private void dgv_loaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_madv.Text = dgv_loaiDV.Rows[i].Cells[0].Value.ToString();
                txt_tendv.Text = dgv_loaiDV.Rows[i].Cells[1].Value.ToString();
                txt_dongia.Text = dgv_loaiDV.Rows[i].Cells[2].Value.ToString();
            }

        }
        private bool KiemTraSo(string so)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(so);
        }
        private bool batloinhap()
        {
            if (String.IsNullOrEmpty(txt_madv.Text))
            {
                MetroMessageBox.Show(this, "Mã dịch vụ không được bỏ trống!!", "Chú ý!");
                txt_madv.Focus();
                return false;
            }

            else if (String.IsNullOrEmpty(txt_tendv.Text))
            {
                MetroMessageBox.Show(this, "Tên dịch vụ không được bỏ trống!!", "Chú ý!");
                txt_tendv.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txt_dongia.Text))
            {
                MetroMessageBox.Show(this, "Đơn giá không được bỏ trống!!", "Chú ý!");
                txt_dongia.Focus();
                return false;
            }
            else if (!KiemTraSo(txt_dongia.Text))
            {
                MetroMessageBox.Show(this, "Đơn giá phải là số!!", "Chú ý!");
                txt_dongia.Focus();
                return false;
            }
            return true;
        }
    }
}
