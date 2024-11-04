using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguoiDungBLL
    {
        private readonly NguoiDungDAL _nguoiDungDAL = new NguoiDungDAL();
        public NguoiDungBLL() { }
        public List<NguoiDung> getListNguoiDung()
        {
            return _nguoiDungDAL.getListNguoiDung();
        }

        public NguoiDung GetNguoiDungTheoTenDangNhap(string username)
        {
            return _nguoiDungDAL.GetNguoiDungTheoTenDangNhap(username);
        }

        public bool DangNhap(string username, string password)
        {
            NguoiDung nguoiDung = GetNguoiDungTheoTenDangNhap(username);

            if (nguoiDung == null)
            {
                return false;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, nguoiDung.MatKhau))
            {
                return false;
            }

            return true;
        }
    }
}
