using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatMonBLL
    {
        private readonly DatMonDAL _datMonDAL = new DatMonDAL();
        private readonly ChiTietHoaDonDAL _chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public DatMonBLL()
        {
            
        }

        public bool XuLyDatMon(DatMonDTO thongTin)
        {
            ChiTietHoaDon chiTietHoaDon = _chiTietHoaDonDAL.GetByMonVaHoaDon(thongTin.MaMonAn, thongTin.MaHoaDon);

            if (chiTietHoaDon != null)
            {
                thongTin.MaChiTietHoaDon = chiTietHoaDon.MaCTHD;
            }

            return thongTin.MaHoaDon == 0 ? _datMonDAL.ThemMonVaoHoaDon(thongTin) : _datMonDAL.CapNhatDatMon(thongTin);
        }
    }
}
