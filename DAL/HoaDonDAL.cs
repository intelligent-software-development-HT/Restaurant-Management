using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public HoaDonDAL() { }
        public HoaDon GetById(int maHoaDon)
        {
            _dataContext.Refresh(RefreshMode.OverwriteCurrentValues, _dataContext.HoaDons);
            return _dataContext.HoaDons.FirstOrDefault(r => r.MaHD.Equals(maHoaDon));
        }
        public List<HoaDon> getListHoaDon()
        {
            return _dataContext.HoaDons.ToList();
        }

        public HoaDon GetByBan(int maBan)
        {
            _dataContext.Refresh(RefreshMode.OverwriteCurrentValues, _dataContext.HoaDons);
            return _dataContext.HoaDons.FirstOrDefault(r => r.MaBan.Equals(maBan) && r.TrangThaiThanhToan.Equals("Chưa thanh toán"));
        }

        public bool ThanhToan(int maHoaDon, int maBan)
        {
            try
            {
                _dataContext.sp_thanhToan(maHoaDon, maBan);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ISingleResult<getRevenueResult> GetDoanhThu(DateTime startDate, DateTime endDate)
        {
            
            var rs = _dataContext.getRevenue(startDate, endDate);
            return rs;
            
        }
        public ISingleResult<sp_ThongKeMonAnResult> thongKeMonAn(DateTime startDate, DateTime endDate)
        {
            var rs = _dataContext.sp_ThongKeMonAn(startDate, endDate);
            return rs;
        }
        public ISingleResult<GetDoanhThuTheoNgay3Result> getDT()
        {
            return _dataContext.GetDoanhThuTheoNgay3();
        }
    }
}
