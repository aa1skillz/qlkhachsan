using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien NhanVien = new DAL_NhanVien();

        public string TuTangMNV()
        {
            return NhanVien.TuTangMNV();
        }
        public bool CheckTonTai(DTO_NhanVien obj)
        {
            return NhanVien.iCheckTonTai(obj);
        }
        public DataTable HienThi()
        {
            return NhanVien.Display();
        }
        public bool themNV(DTO_NhanVien obj1, DTO_DangNhap obj2)
        {
            return NhanVien.ThemNhanVien(obj1, obj2);
        }
        public bool suaNV(DTO_NhanVien obj)
        {
            return NhanVien.CapNhatNhanVien(obj);
        }
        public bool xoaNV(DTO_NhanVien obj)
        {
            return NhanVien.XoaNhanVien(obj);
        }
        public DataTable layManv(string tennhanvien)
        {
            return NhanVien.getMaNV(tennhanvien);
        }
    }
}
