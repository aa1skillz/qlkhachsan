using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string manhanvien;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public DTO_DangNhap()
        {
        }
        public DTO_DangNhap(string user)
        {
            this.user = user;
        }
       public DTO_DangNhap(string user,string password)
        {
            this.user = user;
            this.password = password;
        }
    }
}
