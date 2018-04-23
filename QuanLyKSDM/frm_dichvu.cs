using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using DTO;
using System.Windows.Forms;
using MetroFramework;
using System.Text.RegularExpressions;

namespace QuanLyKSDM
{
    public partial class frm_dichvu : MetroForm
    {
        public frm_dichvu()
        {
            InitializeComponent();

        }
        public static string maphong;
        private void load_listviewDV()
        {

        }
        BUS_HoaDonDV hddv = new BUS_HoaDonDV();
        DTO_HoaDonDV dtoDV = new DTO_HoaDonDV();
        private void frm_dichvu_Load(object sender, EventArgs e)
        {
            cbb_dv.DataSource = hddv.getTenDV();
            cbb_dv.DisplayMember ="TENDV";
            cbb_dv.ValueMember ="MADV";
            
        }
        
        private bool KiemTraSo(string so)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(so);
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            if(dmup_sl.Text=="" || dmup_sl.Text=="0")
            {
                MetroMessageBox.Show(this, "Nhập số lượng sử dung thỏa mãn!", "Chú ý");
                dmup_sl.Focus();
            }
            else if(!KiemTraSo(dmup_sl.Text))
            {
                MetroMessageBox.Show(this, "Số lượng phải là số!", "Chú ý");
                dmup_sl.Focus();
            }
            else
            {
                string makhach = hddv.makhachtheomaphong(maphong);
                string maphieutt = hddv.maphieuthuetheomakhach(makhach);
                dtoDV.Maphieuthue = maphieutt;
                dtoDV.Madichvu = cbb_dv.SelectedValue.ToString();
                dtoDV.Ngaysudung = dt_nsd.Value;
                dtoDV.Soluongdv = Int32.Parse(dmup_sl.Text);
                dtoDV.Tinhtrang = "1";
                if(hddv.them(dtoDV))
                {
                    dgv_dv.DataSource = hddv.xemDV(maphong);
                }
                else
                {
                    MetroMessageBox.Show(this, "Đăng kí dịch vụ thất bại", "Thông báo!");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
    }
}
