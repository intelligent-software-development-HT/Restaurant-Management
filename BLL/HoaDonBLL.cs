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
        private readonly HoaDonDAL _hoaDonDAL = new HoaDonDAL();
        private readonly WordExport export = new WordExport();

        public HoaDonBLL() { }  

        public HoaDon GetById(int maHoaDon)
        {
            return _hoaDonDAL.GetById(maHoaDon);
        }

        public List<HoaDon> getListHoaDon()
        {
            return _hoaDonDAL.getListHoaDon();
        }

        public HoaDon GetByBan(int maBan)
        {
            return _hoaDonDAL.GetByBan(maBan);
        }

        public bool XuLyThanhToan(int maHoaDon, int maBan)
        {
            return _hoaDonDAL.ThanhToan(maHoaDon, maBan);
        }

        public void InHoaDon(int maHoaDon, string ngayTao, string tenBan, string tenNhanVien, int tongTien, List<ChiTietHoaDon> chiTietHoaDons)
        {
            export.HoaDonBanHang(maHoaDon, ngayTao, tenBan, tenNhanVien, tongTien, chiTietHoaDons);
        }
    }
}
