using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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
                if (thongTinDatMon.MaChiTietHoaDon == 0)
                {
                    var chiTietHoaDon = new ChiTietHoaDon
                    {
                        MaMonAn = thongTinDatMon.MaMonAn,
                        MaHD = thongTinDatMon.MaHoaDon,
                        SoLuong = thongTinDatMon.SoLuong,
                        TrangThaiMon = "preparing",
                        ThoiGianDatMon = DateTime.Now
                    };

                    _context.ChiTietHoaDons.InsertOnSubmit(chiTietHoaDon);

                    _context.SubmitChanges();
                }
                else
                {
                    var chiTietHoaDon = _context.ChiTietHoaDons.FirstOrDefault(r => r.MaCTHD.Equals(thongTinDatMon.MaChiTietHoaDon));

                    if (chiTietHoaDon == null)
                    {
                        return false;
                    }

                    chiTietHoaDon.SoLuong += thongTinDatMon.SoLuong;

                    //_context.sp_CapNhatMonVaoHoaDon(thongTinDatMon.MaChiTietHoaDon, thongTinDatMon.SoLuong);

                    //_context.Refresh(RefreshMode.OverwriteCurrentValues, _context.ChiTietHoaDons);

                    _context.SubmitChanges();
                }
                return true;
            }
            catch (ChangeConflictException)
            {
                foreach (var conflict in _context.ChangeConflicts)
                {
                    conflict.Resolve(RefreshMode.KeepChanges);
                }
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
