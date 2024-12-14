using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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
        public ISingleResult<getRevenueResult> GetDoanhThu(DateTime startDate, DateTime endDate)
        {

            return _hoaDonDAL.GetDoanhThu(startDate, endDate);

        }
        public ISingleResult<sp_ThongKeMonAnResult> thongKeMonAn(DateTime startDate, DateTime endDate)
        {
            return _hoaDonDAL.thongKeMonAn(startDate,endDate);
        }
        
        public ISingleResult<GetDoanhThuTheoNgay3Result> getDT()
        {
            return _hoaDonDAL.getDT();
        }

        internal IEnumerable<object> GetDoanhThuTheoNgay3()
        {
            throw new NotImplementedException();
        }
    }
}
