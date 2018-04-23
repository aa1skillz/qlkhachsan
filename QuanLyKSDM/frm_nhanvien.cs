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
using DTO;
using BUS;
using MetroFramework;
using System.Text.RegularExpressions;

namespace QuanLyKSDM
{
    public partial class frm_nhanvien :MetroForm
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }



        private void Btn_KichHoat()
        {
            btn_huy.Hide();
            btn_Luu.Hide();
            btn_Thoat.Enabled=true;
            btn_XoaNV.Enabled = true;
            btn_ThemNV.Enabled = true;
            btn_SuaNV.Enabled = true;

        }
        private void Btn_Ngung()
        {
            btn_huy.Show();
            btn_Luu.Show();
            btn_Thoat.Enabled=false;
            btn_XoaNV.Enabled = false;
            btn_ThemNV.Enabled = false;
            btn_SuaNV.Enabled = false;
            
        }
        private void clear()
        {
            txt_manv.Clear();
            txt_Tennv.Clear();
            rbtnNam.Checked = true;
            dt_Ngaysinh.Value=DateTime.Now;
            txt_Diachi.Clear();
            txt_Chucvu.Clear();
            txt_Sdt.Clear();
            dgv_NhanVien.Enabled = true;
        }
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Enabled = false;
           int  i = e.RowIndex;
           if (i >= 0)
           {

               txt_manv.Text = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
               txt_Tennv.Text = dgv_NhanVien.Rows[i].Cells[1].Value.ToString();
               if (String.Compare(dgv_NhanVien.Rows[i].Cells[3].Value.ToString(), "Nam", true) == 0)
               {
                   rbtnNam.Checked = true;
                   RbtnNu.Checked = false;
               }
               else
               {
                   RbtnNu.Checked = true;
                   rbtnNam.Checked = false;
               }
               dt_Ngaysinh.Text = dgv_NhanVien.Rows[i].Cells[2].Value.ToString();
               txt_Diachi.Text = dgv_NhanVien.Rows[i].Cells[4].Value.ToString();
               txt_Sdt.Text = dgv_NhanVien.Rows[i].Cells[5].Value.ToString();
               txt_Chucvu.Text = dgv_NhanVien.Rows[i].Cells[6].Value.ToString();
           }
        }
       
       public void frm_nhanvien_Load(object sender, EventArgs e)
        {
            Btn_KichHoat();
            dgv_NhanVien.DataSource = BUS_NV.HienThi();
            clear();
          
        }
         private bool Batloinhap()
        {
            if (String.IsNullOrEmpty(txt_Tennv.Text))
            {
                MetroMessageBox.Show(this, "Tên nhân viên không được bỏ trống", "Chú ý!");
                txt_Tennv.Focus();
                return true;
            }
            else if (String.IsNullOrEmpty(txt_Diachi.Text))
            {

                MetroMessageBox.Show(this, "Địa chỉ không được bỏ trống", "Chú ý!");
                txt_Diachi.Focus();
                return true;

            }
           
            else if (String.IsNullOrEmpty(txt_Sdt.Text))
            {
                MetroMessageBox.Show(this, "Số điện thoại không được bỏ trống", "Chú ý!");
                txt_Sdt.Focus();
                return true;
            }
            else if (!KiemTraSDT(txt_Sdt.Text))
            {
                MetroMessageBox.Show(this, "Số điện thoại không đúng", "Chú ý!");
                txt_Sdt.Focus();
                return true;
            }
            else if (String.IsNullOrEmpty(txt_Chucvu.Text))
            {
                MetroMessageBox.Show(this, "Chức vụ không được bỏ trống", "Chú ý!");
                txt_Chucvu.Focus();
                return true;
            }
            return false;
        }
           private bool KiemTraSDT(string sdt)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(sdt);
        }
        private int a;
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThemNV themnv = new frm_ThemNV();
            themnv.ShowDialog();
            
        }
        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_manv.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn nhân viên cần sửa thông tin", "Chú ý!");
            }
            else
            {
                txt_manv.Enabled = false;
                Btn_Ngung();
                a = 1;
            }
        }
        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_manv.Text))
            {
                MetroMessageBox.Show(this, "Vui lòng chọn nhân viên cần xóa ", "Chú ý!");
            }
            else
            {
                Btn_Ngung();
                a = 2;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DTO_NhanVien NV;
        private BUS_NhanVien BUS_NV = new BUS_NhanVien();
        private BUS_DangNhap BUS_DN = new BUS_DangNhap();

        private string giotinh;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (!Batloinhap())
                {
                    if (rbtnNam.Checked == true)
                        giotinh = "Nam";
                    else if (RbtnNu.Checked == true)
                        giotinh = "Nữ";

                        NV = new DTO_NhanVien(txt_manv.Text, txt_Tennv.Text, dt_Ngaysinh.Value, giotinh, txt_Diachi.Text, txt_Sdt.Text, txt_Chucvu.Text);
                        if (BUS_NV.suaNV(NV))
                        {
                            MetroMessageBox.Show(this, "Cập nhật thành công", "Thông báo!");
                            frm_nhanvien_Load(sender, e);
                            clear();
                        }
                        else
                            MetroMessageBox.Show(this, "Cập nhật thất bại", "Thông báo!");
                    }
                }
                    if (a == 2)
                    {
                        NV = new DTO_NhanVien(txt_manv.Text);
                        if (BUS_NV.xoaNV(NV))
                        {
                            MetroMessageBox.Show(this, "Xóa thành công", "Thông báo!");
                            frm_nhanvien_Load(sender, e);
                        }
                        else
                            MetroMessageBox.Show(this, "Xóa thất bại", "Thông báo!");
                    }

                }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            frm_nhanvien_Load(sender, e);
            dgv_NhanVien.Enabled = true;
            txt_manv.Enabled = true;
        }
    }
}
