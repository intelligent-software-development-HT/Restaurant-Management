using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguoiDungNhomNguoiDungBLL
    {
        private readonly NguoiDungNhomNguoiDungDAL _nguoiDungNhomNguoiDungDAL = new NguoiDungNhomNguoiDungDAL();

        public IEnumerable<NguoiDungNhomNguoiDung> getListNguoiDungNhomNguoiDung()
        {
            return _nguoiDungNhomNguoiDungDAL.ReadNguoiDungNhomNguoiDungs();
        }

        public bool IsExists(int maNhomNguoiDung, string tenDangNhap)
        {
            return _nguoiDungNhomNguoiDungDAL.IsExists(maNhomNguoiDung, tenDangNhap);
        }

        public bool AddNguoiDungVaoNhom(NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung)
        {
            if (nguoiDungNhomNguoiDung == null)
            {
                return false;
            }

            if (IsExists(nguoiDungNhomNguoiDung.MaNhomNguoiDung, nguoiDungNhomNguoiDung.TenDangNhap))
            {
                return false;
            }

            return _nguoiDungNhomNguoiDungDAL.AddNguoiDungVaoNhom(nguoiDungNhomNguoiDung);
        }

        public bool RemoveNguoiDungKhoiNhom(NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung)
        {
            if (nguoiDungNhomNguoiDung == null)
            {
                return false;
            }

            if (!IsExists(nguoiDungNhomNguoiDung.MaNhomNguoiDung, nguoiDungNhomNguoiDung.TenDangNhap))
            {
                return false;
            }

            return _nguoiDungNhomNguoiDungDAL.RemoveNguoiDungKhoiNhom(nguoiDungNhomNguoiDung);
        }
    }
}
