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
    public partial class frm_baocao : MetroForm
    {
        public frm_baocao()
        {
            InitializeComponent();
        }

        private void fm_baocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKHACHSANDataSet.VIEW_REPORT1' table. You can move, or remove it, as needed.
            this.VIEW_REPORT1TableAdapter.Fill(this.QLKHACHSANDataSet.VIEW_REPORT1);

            this.reportViewer1.RefreshReport();
        }
    }
}
