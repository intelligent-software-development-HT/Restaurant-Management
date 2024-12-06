using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatMonDAL
    {
        private readonly QLNHDataContext _context = new QLNHDataContext();

        public DatMonDAL()
        {

        }

        public bool ThemMonVaoHoaDon(DatMonDTO thongTinDatMon)
        {
            try
            {
                _context.sp_ThemMonVaoHoaDonMoi(thongTinDatMon.MaNhanVien, thongTinDatMon.MaBan, thongTinDatMon.MaMonAn, thongTinDatMon.SoLuong);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatDatMon(DatMonDTO thongTinDatMon)
        {
            try
            {
                _context.sp_CapNhatMonVaoHoaDon(thongTinDatMon.MaChiTietHoaDon, thongTinDatMon.SoLuong);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
