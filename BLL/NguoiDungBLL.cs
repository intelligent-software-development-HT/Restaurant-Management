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
        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();
        public NguoiDungBLL() { }
        public List<NguoiDung> getListNguoiDung()
        {
            return nguoiDungDAL.getListNguoiDung();
        }
    }
}
