using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public ChiTietHoaDonDAL() { }
        public List<ChiTietHoaDon> getListChiTietHoaDon()
        {
            return _dataContext.ChiTietHoaDons.ToList<ChiTietHoaDon>();
        }

        public bool CapNhatTrangThaiDonMon(int id, string trangThai)
        {
            try
            {
                var donMon = _dataContext.ChiTietHoaDons.FirstOrDefault(r => r.MaCTHD.Equals(id));

                if (donMon == null)
                {
                    return false;
                }

                donMon.TrangThaiMon = trangThai;

                _dataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
