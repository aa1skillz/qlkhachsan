
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BUS;
using MetroFramework.Forms;
using MetroFramework;


namespace QuanLyKSDM
{
    public partial class frm_cauhinh : MetroForm
    {
        public frm_cauhinh()
        {
            InitializeComponent();
        }
        private BUS_CSDL database = new BUS_CSDL();
        private string strConnect = "";
        private void frm_cauhinh_Load(object sender, EventArgs e)
        {
            cbbServerName.Items.Add(Environment.MachineName);
            cbbServerName.Items.Add(Environment.MachineName + @"\EXPRESS");
            cbbAuthentication.SelectedIndex = 0;
           
        }

        private void SaveConnectString(string connectString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["QLKhachSanConnectString"].ConnectionString = connectString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            strConnect = "";
            if (cbbAuthentication.SelectedIndex == 0)
            {
                strConnect = "Data Source=" + cbbServerName.Text + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                strConnect = "Data Source=" + cbbServerName.Text + ";Initial Catalog=master;Persist Security Info=True;User ID=" + txtUserName.Text + ";Password=" + txtPassWord.Text + "";
            }
            if (database.KiemTraChuoiKetNoi(strConnect))
            {
                if (cbbDatabase.Items.Count > 0)
                {
                    MetroMessageBox.Show(this, "Kết nối thành công","Thông Báo");
                    ((DataTable)cbbDatabase.DataSource).Clear();
                    
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Kết nối thất bại","Thông Báo");
            }
            cbbDatabase.DataSource = database.LayCSDL();
            cbbDatabase.DisplayMember = "DATABASE_NAME";
            cbbDatabase.ValueMember = "DATABASE_NAME";
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strConnect = "";
            if (cbbAuthentication.SelectedIndex == 0)
            {
                strConnect = "Data Source=" + cbbServerName.Text + ";Initial Catalog=" + cbbDatabase.Text + ";Integrated Security=True";
            }
            else
            {
                strConnect = "Data Source=" + cbbServerName.Text + ";Initial Catalog=" + cbbDatabase.Text + ";Persist Security Info=True;User ID=" + txtUserName.Text + ";Password=" + txtPassWord.Text + "";
            }
            SaveConnectString(strConnect);
            frm_dangnhap dangNhap = new frm_dangnhap();
            dangNhap.Show();
            this.Close();
        }

        private void cbbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAuthentication.SelectedIndex == 0)
            {
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
            }
            else if (cbbAuthentication.SelectedIndex == 1)
            {
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
            }
        }
    }
}
