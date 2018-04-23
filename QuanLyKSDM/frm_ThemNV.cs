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
using DTO;
using System.Text.RegularExpressions;


namespace QuanLyKSDM
{
    public partial class frm_ThemNV : MetroForm
    {
        public frm_ThemNV()
        {
            InitializeComponent();
        }
        private void frm_ThemNV_Load(object sender, EventArgs e)
        {
            txt_mnv.Enabled = false;
            txt_mnv.Text = bus_nv.TuTangMNV();
            txt_tnv.Focus();
        }
        private void clear()
        {
            txt_mnv.Clear();
            txt_dc.Clear();
            txt_pass.Clear();
            txt_rePass.Clear();
            txt_chucvu.Clear();
            txt_user.Clear();
            txt_sdt.Clear();
            txt_tnv.Clear();
            dt_ns.Value = DateTime.Now;
        }
        DTO_NhanVien NV;
        DTO_DangNhap DN;
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_DangNhap bus_dn = new BUS_DangNhap();
        string gioitinh;
        private bool Batloinhap()
        {
            if (String.IsNullOrEmpty(txt_tnv.Text))
            {
                MetroMessageBox.Show(this, "Tên nhân viên không được bỏ trống", "Chú ý!");
                txt_tnv.Focus();
                return true;
            }
            else if (String.IsNullOrEmpty(txt_dc.Text))
            {

                MetroMessageBox.Show(this, "Địa chỉ không được bỏ trống", "Chú ý!");
                txt_dc.Focus();
                return true;

            }
           
            else if (String.IsNullOrEmpty(txt_sdt.Text))
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
            else if (String.IsNullOrEmpty(txt_chucvu.Text))
            {
                MetroMessageBox.Show(this, "Chức vụ không được bỏ trống", "Chú ý!");
                txt_chucvu.Focus();
                return true;
            }
            else if(bus_dn.ichecktk(txt_user.Text))
            {
                MetroMessageBox.Show(this, "Tài khoản đã tồn tại", "Chú ý!");
                txt_user.Focus();
                return true;
            }
            else if (txt_user.Text.Length>50)
            {
                MetroMessageBox.Show(this, "Tên đăng nhập không được lớn hơn 50 kí tự", "Chú ý!");
                txt_user.Focus();
                return true;
            }
            else if(String.Compare(txt_pass.Text,txt_rePass.Text)!=0)
            {
                MetroMessageBox.Show(this,"Mật khẩu không khớp","Chú ý!");
                txt_rePass.Focus();
                return true;
            }
            return false;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!Batloinhap())
            {
                if (rbtn_nam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else if (rbtn_nu.Checked == true)
                {
                    gioitinh = "Nữ";
                }
                NV = new DTO_NhanVien(txt_mnv.Text, txt_tnv.Text, dt_ns.Value, gioitinh, txt_dc.Text, txt_sdt.Text, txt_chucvu.Text);
                DN = new DTO_DangNhap(txt_user.Text, txt_pass.Text);

                if (bus_nv.themNV(NV, DN))
                {
                    MetroMessageBox.Show(this, "Thêm thành công","Thông báo!");
                    clear();
                    frm_ThemNV_Load(sender, e);
                }
                else
                {
                    MetroMessageBox.Show(this, "Thêm lỗi, vui lòng kiểm tra lại","Thông báo!");
                }
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_nhanvien nv = new frm_nhanvien();
            nv.frm_nhanvien_Load(sender,e);
            nv.ShowDialog();
            
        }
        private bool KiemTraSDT(string sdt)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(sdt);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}

