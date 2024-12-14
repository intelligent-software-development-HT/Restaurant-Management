using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNguoiDungBLL
    {
        private readonly NhomNguoiDungDAL _nhomNguoiDungDAL = new NhomNguoiDungDAL();

        public IEnumerable<NhomNguoiDung> ReadNhomNguoiDungs()
        {
            return _nhomNguoiDungDAL.ReadNhomNguoiDungs();
        }

        public bool Create(NhomNguoiDung nhomNguoiDung)
        {
            return nhomNguoiDung != null ? _nhomNguoiDungDAL.Create(nhomNguoiDung) : false;
        }

        public bool Update(NhomNguoiDung nhomNguoiDung)
        {
            return nhomNguoiDung != null ? _nhomNguoiDungDAL.Update(nhomNguoiDung) : false;
        }

        public bool Delete(int maNhomNguoiDung)
        {
            return _nhomNguoiDungDAL.Delete(maNhomNguoiDung);
        }

        public bool IsExists(int maNhomNguoiDung)
        {
            return _nhomNguoiDungDAL.IsExists(maNhomNguoiDung);
        }
    }
}
