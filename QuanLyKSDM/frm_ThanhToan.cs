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

namespace QuanLyKSDM
{
    public partial class frm_ThanhToan : MetroForm
    {
        public frm_ThanhToan()
        {
            InitializeComponent();
        }
        public static string maphong;
        DTO_Phong dtoPhong = new DTO_Phong();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_HoaDonDV hddv = new BUS_HoaDonDV();
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            dtoPhong.Tinhtrang = "TRỐNG";
            dtoPhong.Maphong = frm_dangkiphong.maphong;
            busPhong.capnhatphong(dtoPhong);
            hddv.capnhat(dtoPhong.Maphong, "2");
            this.Close();
        }

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {  
            lbl_maphong.Text = maphong;
            dgv_dichvusd.DataSource= hddv.xemDV(maphong);
            
            string makhach = hddv.makhachtheomaphong(maphong);
            string maphieutt = hddv.maphieuthuetheomakhach(makhach);
            string mpt= hddv.maphieuthuetheomakhach(makhach);
            frm_HoaDonThanhToan.mapt = mpt;
            DataTable dt = hddv.xemHDTR(mpt);
            txt_mpt.Text = dt.Rows[0]["MAPHIEUTHUE"].ToString();
            txt_nvl.Text = dt.Rows[0]["TENNV"].ToString();
            txt_ngaythue.Text = dt.Rows[0]["NGAYTHUE"].ToString();
            txt_ngaytra.Text = dt.Rows[0]["NGAYTRA"].ToString();
            txt_mkh.Text = dt.Rows[0]["MAKHACH"].ToString();
            txt_tenkh.Text = dt.Rows[0]["TENKHACH"].ToString();
            txt_cmnd.Text = dt.Rows[0]["CMND"].ToString();
            txt_sln.Text = dt.Rows[0]["SLNGUOI"].ToString();
            lbl_tienphong.Text = dt.Rows[0]["TIENPHONG"].ToString();
            lbl_tiendv.Text = dt.Rows[0]["TIENDICHVU"].ToString();
            lbl_tong.Text = dt.Rows[0]["TONG"].ToString();
                
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frm_HoaDonThanhToan hd = new frm_HoaDonThanhToan();
            hd.ShowDialog();
        }




    }
}
