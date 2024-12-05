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
        private readonly ChiTietHoaDonDAL _chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        public ChiTietHoaDonBLL() { }
        public List<ChiTietHoaDon> getListChiTietHoaDon()
        {
            return _chiTietHoaDonDAL.getListChiTietHoaDon();
        }

        public bool UpdateTrangThaiMon(int id, string trangThai)
        {
            return _chiTietHoaDonDAL.CapNhatTrangThaiDonMon(id, trangThai);
        }
    }
}
