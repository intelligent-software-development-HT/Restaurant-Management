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
        public IEnumerable<NguoiDung> ReadNguoiDungs()
        {
            return _nguoiDungDAL.ReadNguoiDungs();
        }

        public NguoiDung GetNguoiDungTheoTenDangNhap(string username)
        {
            return _nguoiDungDAL.ReadNguoiDung(username);
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

        public bool IsExists(string username)
        {
            return _nguoiDungDAL.IsExists(username);
        }

        public bool Create(NguoiDung nguoiDung)
        {
            if (IsExists(nguoiDung.TenDangNhap))
            {
                return false;
            }

            nguoiDung.MatKhau = BCrypt.Net.BCrypt.HashPassword(nguoiDung.MatKhau, workFactor: 12);
            
            return _nguoiDungDAL.Create(nguoiDung);
        }

        public bool DoiMatKhau(NguoiDung nguoiDung)
        {
            nguoiDung.MatKhau = BCrypt.Net.BCrypt.HashPassword(nguoiDung.MatKhau, workFactor: 12);

            return _nguoiDungDAL.Update(nguoiDung);
        }

        public bool Delete(string username)
        {
            return _nguoiDungDAL.Delete(username);
        }
    }
}
