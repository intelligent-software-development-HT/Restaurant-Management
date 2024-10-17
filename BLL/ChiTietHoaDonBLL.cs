using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        public ChiTietHoaDonBLL() { }
        public List<ChiTietHoaDon> getListChiTietHoaDon()
        {
            return chiTietHoaDonDAL.getListChiTietHoaDon();
        }
    }
}
