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
    public partial class frm_dangkiphong : MetroForm
    {
        public frm_dangkiphong()
        {
            InitializeComponent();
        }
        public static string maphong;
        public static string maphieu;
        BUS_Khach busKhach = new BUS_Khach();
        BUS_DangNhap dn = new BUS_DangNhap();
        private void frm_dangkiphong_Load(object sender, EventArgs e)
        {
            dt_ngaylap.Value = DateTime.Now;
            dt_ngaythue.Value = DateTime.Now;
            txt_maphieu.Enabled = false;
            txt_maphieu.Text = busPhieuThue.tutangMPT();
            maphieu = txt_maphieu.Text;
            lbl_maphong.Text = maphong;
            dgv_khach.DataSource = busKhach.getKhach();
            txt_NVlap.Text = dn.getName(frm_taikhoan.taikhoan).Rows[0]["TENNV"].ToString();
            txt_NVlap.Enabled = false;
            alh();

        }
        private void clear()
        {
            txt_makh.Clear();
            txt_diachi.Clear();
            txt_quoctich.Clear();
            txt_cmnd.Clear();
            txt_tenkh.Clear();
            dt_ngaysinh.Value = DateTime.Now;
        }
        private void dgv_khach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_makh.Enabled = false;
                txt_makh.Text = dgv_khach.Rows[i].Cells[0].Value.ToString();
                txt_tenkh.Text = dgv_khach.Rows[i].Cells[1].Value.ToString();
                dt_ngaysinh.Text = dgv_khach.Rows[i].Cells[2].Value.ToString();
                if (String.Compare(dgv_khach.Rows[i].Cells[3].Value.ToString(), "Nam", true) == 0)
                {
                    rbtn_nam.Checked = true;
                    rbtn_nu.Checked = false;
                }
                else
                {
                    rbtn_nam.Checked = false;
                    rbtn_nu.Checked = true;

                }
                txt_cmnd.Text = dgv_khach.Rows[i].Cells[5].Value.ToString();
                txt_quoctich.Text = dgv_khach.Rows[i].Cells[6].Value.ToString();
                txt_diachi.Text = dgv_khach.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void ckb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_makh.Enabled == false)
                txt_makh.Enabled = true;
            else
                txt_makh.Enabled = false;
        }
        private int key;
        private void hlh()
        {
            btn_luu.Show();
            btn_KHhuy.Show();
        }
        private void alh()
        {
            btn_KHhuy.Hide();
            btn_luu.Hide();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            txt_makh.Enabled = false;
            dgv_khach.Enabled = false;
            clear();
            txt_makh.Text = busKhach.tuTangMK();
            hlh();
            key = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_makh.Text))
            {
                MetroMessageBox.Show(this, "Chọn khách hàng cần sửa", "Chú ý!");
            }
            else
            {
                txt_makh.Enabled = false;
                dgv_khach.Enabled = false;
                hlh();
                key = 2;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_makh.Text))
            {
                MetroMessageBox.Show(this, "Chọn khách hàng cần xóa", "Chú ý!");
            }
            else
            {
                txt_makh.Enabled = false;
                hlh();
                key = 3;
            }
        }

        private void btn_KHhuy_Click(object sender, EventArgs e)
        {
            clear();
            alh();
            dgv_khach.Enabled = true;
        }
        private bool batloinhap()
        {
            if (String.IsNullOrEmpty(txt_makh.Text))
            {
                MetroMessageBox.Show(this, "Mời nhập mã khách", "Chú ý!");
                txt_makh.Focus();
                return false;
            }
            
            else if (String.IsNullOrEmpty(txt_tenkh.Text))
            {
                MetroMessageBox.Show(this, "Mời nhập tên khách", "Chú ý!");
                txt_tenkh.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txt_cmnd.Text))
            {
                MetroMessageBox.Show(this, "Mời số CMND hoặc Hộ chiếu", "Chú ý!");
                txt_cmnd.Focus();
                return false;
            }
            else if (!KiemTraSo(txt_cmnd.Text))
            {
                MetroMessageBox.Show(this, "Nhập sai định dạng CMND hoặc Hộ chiếu", "Chú ý!");
                txt_cmnd.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txt_quoctich.Text))
            {
                MetroMessageBox.Show(this, "Mời nhập quốc tịch", "Chú ý!");
                txt_cmnd.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txt_diachi.Text))
            {
                MetroMessageBox.Show(this, "Mời nhập địa chỉ", "Chú ý!");
                txt_cmnd.Focus();
                return false;
            }
            return true;
        }
        private bool KiemTraSo(string so)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(so);
        }
        DTO_Khach khach = new DTO_Khach();
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (batloinhap())
            {
                khach.Makhach = txt_makh.Text;
                khach.Tenkhach = txt_tenkh.Text;
                khach.Ngaysinh = dt_ngaysinh.Value;
                if (rbtn_nam.Checked == true)
                {
                    khach.Gioitinh = "Nam";
                }
                else if (rbtn_nu.Checked == true)
                {
                    khach.Gioitinh = "Nữ";
                }
                khach.Quoctich = txt_quoctich.Text;
                khach.Diachi = txt_diachi.Text;
                khach.Cmnd = txt_cmnd.Text;
                if (key == 1)
                {


                    if (busKhach.themKhach(khach))
                    {
                        clear();
                        MetroMessageBox.Show(this, "Thêm thành công", "Thông báo!");
                        frm_dangkiphong_Load(sender, e);
                        dgv_khach.Enabled = true;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Thêm lỗi", "Thông báo!");
                        dgv_khach.Enabled = true;
                    }
                }
                if (key == 2)
                {

                    if (busKhach.suaKhach(khach))
                    {
                        clear();
                        MetroMessageBox.Show(this, "Cập nhật thành công", "Thông báo!");
                        frm_dangkiphong_Load(sender, e);
                    }
                    else
                    {

                        MetroMessageBox.Show(this, "Cập nhật lỗi", "Thông báo!");
                    }
                }
                if (key == 3)
                {

                    if (busKhach.xoaKhach(khach))
                    {
                        clear();
                        MetroMessageBox.Show(this, "Xóa  thành công", "Thông báo!");
                        frm_dangkiphong_Load(sender, e);
                    }
                    else
                    {

                        MetroMessageBox.Show(this, "Xóa lỗi", "Thông báo!");
                    }
                    dgv_khach.Enabled = true;
                }
            }
        }
        DTO_PhieuThue dtoPhieu = new DTO_PhieuThue();
        DTO_Phong dtoPhong = new DTO_Phong();
        BUS_NhanVien busNhanvien = new BUS_NhanVien();
        BUS_PhieuThue busPhieuThue = new BUS_PhieuThue();
        BUS_Phong busPhong = new BUS_Phong();
        private void btn_dkthue_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txt_makh.Text))
            {
                MetroMessageBox.Show(this, "Chọn khách hàng thuê", "Chú ý!");
            }
            else
            {
                if (String.IsNullOrEmpty(txt_soluongnguoi.Text))
                {
                    MetroMessageBox.Show(this, "Nhập số lượng người", "Chú ý");
                    txt_soluongnguoi.Focus();

                }
                else if (!KiemTraSo(txt_soluongnguoi.Text))
                {
                    MetroMessageBox.Show(this, "Nhập sai định dạng số lượng người", "Chú ý");
                    txt_soluongnguoi.Focus();
                }
                else if (dt_ngaythue.Value.CompareTo(dt_ngaytra.Value) == 1)
                {
                    MetroMessageBox.Show(this, "Ngày trả phải sau ngày thuê", "Chú ý!");
                    dt_ngaytra.Focus();
                }

                else
                {
                    dtoPhieu.Maphieuthue = txt_maphieu.Text;
                    dtoPhieu.Manhanvien = busNhanvien.layManv(txt_NVlap.Text).Rows[0]["MANV"].ToString();
                    dtoPhieu.Ngaythue = dt_ngaythue.Value;
                    dtoPhieu.Ngaytra = dt_ngaytra.Value;
                    dtoPhieu.Ngaylap = dt_ngaylap.Value;
                    dtoPhieu.Maphong = maphong;
                    dtoPhong.Maphong = maphong;
                    dtoPhieu.Soluongnguoi = Int32.Parse(txt_soluongnguoi.Text);
                    dtoPhieu.Makhach = txt_makh.Text;
                    dtoPhong.Tinhtrang = "KHÔNG TRỐNG";
                    if (busPhieuThue.themPhieuThue(dtoPhieu))
                    {
                        MetroMessageBox.Show(this, "Đăng kí thuê thành công", "Thông báo!");
                        busPhong.capnhatphong(dtoPhong);
                        this.Close();

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Có lỗi khi đăng kí", "Thông báo!");
                    }

                }
            }
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
