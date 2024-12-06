using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public HoaDonBLL() { }  
        public List<HoaDon> getListHoaDon()
        {
            return hoaDonDAL.getListHoaDon();
        }

        public HoaDon GetByBan(int maBan)
        {
            return hoaDonDAL.GetByBan(maBan);
        }
    }
}
