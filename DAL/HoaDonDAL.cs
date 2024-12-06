using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public HoaDonDAL() { }
        public List<HoaDon> getListHoaDon()
        {
            return _dataContext.HoaDons.ToList();
        }

        public HoaDon GetByBan(int maBan)
        {
            return _dataContext.HoaDons.FirstOrDefault(r => r.MaBan.Equals(maBan) && r.TrangThaiThanhToan.Equals("Chưa thanh toán"));
        }
    }
}
