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

namespace QuanLyKSDM
{
    public partial class frm_HoaDonThanhToan : MetroForm
    {
        public frm_HoaDonThanhToan()
        {
            InitializeComponent();
        }
        public static string mapt;
        private void frm_HoaDonThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKHACHSANDataSet.HOADON_XEM_THEOMA' table. You can move, or remove it, as needed.
            this.HOADON_XEM_THEOMATableAdapter.Fill(this.QLKHACHSANDataSet.HOADON_XEM_THEOMA,mapt);
            this.reportViewer1.RefreshReport();
        }
    }
}
