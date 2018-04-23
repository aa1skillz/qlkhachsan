using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string manhanvien;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }

        private string tennhanvien;

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }


        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sodienthoai;

        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public DTO_NhanVien(string Manhanvien)
        {
            this.manhanvien = Manhanvien;
        }
        public DTO_NhanVien(string Manhanvien,string Tennhanvien,DateTime Ngaysinh,string Gioitinh,string Diachi,string Sodienthoai,string Chucvu)
        {
            this.ngaysinh = Ngaysinh;
            this.chucvu = Chucvu;
            this.diachi = Diachi;
            this.gioitinh = Gioitinh;
            this.sodienthoai = Sodienthoai;
            this.tennhanvien = Tennhanvien;
            this.manhanvien = Manhanvien;
        }
    }
}
