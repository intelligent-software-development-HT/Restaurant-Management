using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDatBanDAL
    {
        private readonly QLNHDataContext _context = new QLNHDataContext();

        public PhieuDatBanDAL()
        {

        }

        public List<DatBan> GetDanhSachDatBan()
        {
            return _context.DatBans.Where(r => r.ThoiGianDat >= DateTime.Now).OrderBy(r => r.ThoiGianDat).ToList();
        }

        public int KiemTraBanKhaDung()
        {
            return _context.sp_kiemTraBanKhaDung();
        }

        public void XuLyTrangThaiDatBan()
        {
            _context.sp_xuLyTrangThaiDatBan();
        }

        public bool DuyetTrangThaiDatBan(int maDatBan, string trangThai)
        {
            try
            {
                DatBan datBan = _context.DatBans.FirstOrDefault(r => r.MaPhieuDatBan.Equals(maDatBan));

                if (datBan == null)
                {
                    return false;
                }

                datBan.TrangThai = trangThai;
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
