using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public ChiTietHoaDonDAL() { }
        public ChiTietHoaDon GetById(int id)
        {
            _dataContext.Refresh(RefreshMode.OverwriteCurrentValues, _dataContext.ChiTietHoaDons);
            return _dataContext.ChiTietHoaDons.FirstOrDefault(r => r.MaCTHD.Equals(id));
        }
        public List<ChiTietHoaDon> getListChiTietHoaDon()
        {
            return _dataContext.ChiTietHoaDons.ToList<ChiTietHoaDon>();
        }

        public ChiTietHoaDon GetByMonVaHoaDon(int maMon, int maHoaDon)
        {
            return _dataContext.ChiTietHoaDons.FirstOrDefault(r => r.MaMonAn.Equals(maMon) && r.MaHD.Equals(maHoaDon));
        }

        public List<ChiTietHoaDon> GetDanhSachMonDat(int maHoaDon)
        {
            _dataContext.Refresh(RefreshMode.OverwriteCurrentValues, _dataContext.ChiTietHoaDons);
            return _dataContext.ChiTietHoaDons.Where(r => r.MaHD.Equals(maHoaDon)).ToList();
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
