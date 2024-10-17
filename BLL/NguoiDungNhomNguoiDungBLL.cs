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
        NguoiDungNhomNguoiDungDAL nguoiDungNhomNguoiDungDAL = new NguoiDungNhomNguoiDungDAL();
        public NguoiDungNhomNguoiDungBLL()
        {

        }
        public List<NguoiDungNhomNguoiDung> getListNguoiDungNhomNguoiDung()
        {
            return nguoiDungNhomNguoiDungDAL.getListNguoiDungNhomNguoiDung();
        }
    }
}
