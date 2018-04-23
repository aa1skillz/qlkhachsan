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
    public partial class frm_loaiphong : MetroForm
    {
        public frm_loaiphong()
        {
            InitializeComponent();
        }

        BUS_LoaiPhong busLP = new BUS_LoaiPhong();
        DTO_LoaiPhong dtoLP = new DTO_LoaiPhong();
        private void frm_loaiphong_Load(object sender, EventArgs e)
        {
            dgv_loaiphong.DataSource = busLP.getLP();
            btn_hien();
        }

        private void dgv_loaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_malp.Text = dgv_loaiphong.Rows[i].Cells[0].Value.ToString();
                txt_tenlp.Text = dgv_loaiphong.Rows[i].Cells[1].Value.ToString();
                txt_dongia.Text = dgv_loaiphong.Rows[i].Cells[2].Value.ToString();
            }
        }
        private void btn_hien()
        {
            btn_luu.Hide();
            btl_huy.Hide();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
        }

        private void clear()
        {
            txt_malp.Clear();
            txt_tenlp.Clear();
            txt_dongia.Clear();
        }
        private void btn_an()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = false;
            btn_luu.Show();
            btl_huy.Show();
        }

        private bool KiemTraSo(string so)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(so);
        }
        private bool batloinhap()
        {
            if (String.IsNullOrEmpty(txt_malp.Text))
            {
                MetroMessageBox.Show(this, "Mã loại phòng không được bỏ trống!!", "Chú ý!");
                txt_malp.Focus();
                return false;
            }

            else if (String.IsNullOrEmpty(txt_tenlp.Text))
            {
                MetroMessageBox.Show(this, "Tên loại phòng không được bỏ trống!!", "Chú ý!");
                txt_tenlp.Focus();
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
                txt_tenlp.Focus();
                return false;
            }
            return true;
        }

        private int key;
        private void btn_them_Click(object sender, EventArgs e)
        {
            clear();
            btn_an();
            dgv_loaiphong.Enabled = false;
            key = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_malp.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn loại phòng cần sửa!!", "Thông báo !");
            }
            else
            {
                btn_an();
                txt_malp.Enabled = false;
                key = 2;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_malp.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn loại phòng cần xóa!!", "Thông báo !");
            }
            else
            {
                btn_an();
                key = 3;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (batloinhap())
            {
                dtoLP.Maloaiphong = txt_malp.Text;
                dtoLP.Tenloaiphong = txt_tenlp.Text;
                dtoLP.Dongia = float.Parse(txt_dongia.Text);
                if (key == 1)
                {
                    if (busLP.ktMLP(txt_malp.Text))

                        MetroMessageBox.Show(this, "Mã loại phòng đã tồn tại!!", "Chú ý!");
                    else
                        if (busLP.them(dtoLP))
                        {
                            MetroMessageBox.Show(this, "Thêm thành công!", "Thông báo!");
                            dgv_loaiphong.Enabled = true;
                            frm_loaiphong_Load(sender, e);
                            clear();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Thêm thất bại!", "Thông báo!");
                            dgv_loaiphong.Enabled = true;
                        }
                }

                else if (key == 2)
                {
                    if (busLP.capnhat(dtoLP))
                    {
                        MetroMessageBox.Show(this, "Cập nhật thành công!", "Thông báo!");
                        frm_loaiphong_Load(sender, e);
                        clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Cập nhật thất bại!", "Thông báo!");
                    }
                }
                else if (key == 3)
                {
                    if (busLP.xoa(dtoLP))
                    {
                        MetroMessageBox.Show(this, "Xóa thành công!", "Thông báo!");
                        frm_loaiphong_Load(sender, e);
                        clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Xóa thất bại!", "Thông báo!");
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
