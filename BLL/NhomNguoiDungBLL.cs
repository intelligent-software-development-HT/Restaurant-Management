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
        NhomNguoiDungDAL nhomNguoiDungDAL = new NhomNguoiDungDAL();
        public NhomNguoiDungBLL() { }
        public List<NhomNguoiDung> getListNhomNguoiDung()
        {
            return nhomNguoiDungDAL.getListNhomNguoiDung();
        }
    }
}
