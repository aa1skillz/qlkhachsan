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
using System.Drawing.Imaging;
using BUS;
using DAL;
using DTO;
using MetroFramework;
using System.Drawing.Drawing2D;

namespace QuanLyKSDM
{
    public partial class frm_home : MetroForm
    {
        public frm_home()
        {
            InitializeComponent();
        }

        public void frm_home_Load(object sender, EventArgs e)
        {
            lb_NguoiDung.Text = TaiKhoan;
            PhanQuyen();
            load_phong();

        }
        public static string TaiKhoan;
        public static string QuyenNguoiDung;
        private void PhanQuyen()
        {
            if (QuyenNguoiDung != "Admin")
            {
                grb_quanly.Dispose();
            }
        }
        BUS_Phong phong = new BUS_Phong();
        private string tinhtrang;
        private void load_phong()
        {

            listView1.Items.Clear();
            foreach (DataRow dr in phong.GetPhong().Rows)
            {
                DTO_Phong dto_phong = new DTO_Phong();
                dto_phong.Maloaiphong = (string)dr.ItemArray[1];
                dto_phong.Maphong = (string)dr.ItemArray[0];
                dto_phong.Tinhtrang = (string)dr.ItemArray[2];
                tinhtrang = dto_phong.Tinhtrang;
                ListViewItem item = new ListViewItem(dto_phong.Maphong);

                if (String.Compare(dto_phong.Tinhtrang, "TRỐNG", true) == 0)
                {
                    item.ImageIndex = 0;


                }
                else if (String.Compare(dto_phong.Tinhtrang, "KHÔNG TRỐNG", true) == 0)
                {
                    item.ImageIndex = 1;

                }
                listView1.Items.Add(item);

            }
        }
        //doi mau button 
        #region
        Color a = Color.Yellow;
        private void btn_taikhoan_MouseHover(object sender, EventArgs e)
        {
            btn_taikhoan.BackColor = a;

        }

        private void btn_taikhoan_MouseLeave(object sender, EventArgs e)
        {
            btn_taikhoan.BackColor = Color.White;
        }


        private void btn_dangxuat_MouseHover(object sender, EventArgs e)
        {
            btn_dangxuat.BackColor = a;
        }

        private void btn_dangxuat_MouseLeave(object sender, EventArgs e)
        {
            btn_dangxuat.BackColor = Color.White;
        }



        private void btn_thoat_MouseHover(object sender, EventArgs e)
        {
            btn_thoat.BackColor = a;
        }

        private void btn_thoat_MouseLeave(object sender, EventArgs e)
        {
            btn_thoat.BackColor = Color.White;
        }

        private void btn_tkphong_MouseHover(object sender, EventArgs e)
        {
            btn_tkphong.BackColor = a;
        }


        private void btn_tkphong_MouseLeave(object sender, EventArgs e)
        {
            btn_tkphong.BackColor = Color.White;

        }

        private void btn_tkkhachhang_MouseHover(object sender, EventArgs e)
        {
            btn_tkkhachhang.BackColor = a;
        }

        private void btn_tkkhachhang_MouseLeave(object sender, EventArgs e)
        {
            btn_tkkhachhang.BackColor = Color.White;
        }

        private void btn_qlphong_MouseHover(object sender, EventArgs e)
        {
            btn_qlphong.BackColor = a;
        }

        private void btn_qlphong_MouseLeave(object sender, EventArgs e)
        {
            btn_qlphong.BackColor = Color.White;
        }

        private void btn_qlloaiphong_MouseHover(object sender, EventArgs e)
        {
            btn_qlloaiphong.BackColor = a;
        }

        private void btn_qlloaiphong_MouseLeave(object sender, EventArgs e)
        {
            btn_qlloaiphong.BackColor = Color.White;
        }

        private void btn_qlnhanvien_MouseHover(object sender, EventArgs e)
        {
            btn_qlnhanvien.BackColor = a;
        }

        private void btn_qlnhanvien_MouseLeave(object sender, EventArgs e)
        {
            btn_qlnhanvien.BackColor = Color.White;
        }

        private void btn_baocao_MouseHover(object sender, EventArgs e)
        {
            btn_dicvu.BackColor = a;
        }

        private void btn_baocao_MouseLeave(object sender, EventArgs e)
        {
            btn_dicvu.BackColor = Color.White;
        }
        #endregion
        //he thong
        #region
        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            frm_taikhoan frmTK = new frm_taikhoan();
            frmTK.ShowDialog();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dangnhap dangnhap = new frm_dangnhap();
            dangnhap.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }
        #endregion
        //tim kiem
        #region
        private void btn_tkphong_Click(object sender, EventArgs e)
        {
            frm_TKPhong tkp = new frm_TKPhong();
            tkp.ShowDialog();
        }

        private void btn_tkkhachhang_Click(object sender, EventArgs e)
        {
            frm_TKKhach tkk = new frm_TKKhach();
            tkk.ShowDialog();
        }
        #endregion
        //quan ly
        #region
        private void btn_qlphong_Click(object sender, EventArgs e)
        {
            frm_phong frmPhong = new frm_phong();
            frmPhong.ShowDialog();


        }

        private void btn_qlloaiphong_Click(object sender, EventArgs e)
        {
            frm_loaiphong frmloaiphong = new frm_loaiphong();

            frmloaiphong.ShowDialog();

        }

        private void btn_qlnhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nv = new frm_nhanvien();

            nv.ShowDialog();

        }

        #endregion


        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            DTO_Phong dto_phong = new DTO_Phong();
            ListViewItem item = listView1.FocusedItem;
            frm_ThanhToan.maphong = item.Text;
            frm_dangkiphong.maphong = item.Text;
            if (String.Compare(phong.getTinhTrang(item.Text).Rows[0]["TINHTRANG"].ToString(), "TRỐNG", true) == 0)
            {

                frm_dangkiphong dkphong = new frm_dangkiphong();
                dkphong.ShowDialog();


            }
            else
            {

                frm_ThanhToan frmThanhToan = new frm_ThanhToan();

                frmThanhToan.ShowDialog();

            }
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            frm_dichvu.maphong = item.Text;
            if (frm_dichvu.maphong != "")
            {
                frm_dichvu frmDV = new frm_dichvu();
                frmDV.ShowDialog();
            }


        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            if (String.Compare(phong.getTinhTrang(item.Text).Rows[0]["TINHTRANG"].ToString(), "TRỐNG", true) == 0)
            {
                ts_DV.Enabled = false;
            }
            else
            {
                ts_DV.Enabled = true;
            }

        }

        private void frm_home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frm_NhaPT npt = new frm_NhaPT();
            npt.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frm_home_Load(sender, e);
        }

        private void btn_dicvu_Click(object sender, EventArgs e)
        {
            frm_LoaiDV dv = new frm_LoaiDV();
            dv.ShowDialog();
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            frm_baocao bc = new frm_baocao();
            bc.ShowDialog();
        }

    }
}


