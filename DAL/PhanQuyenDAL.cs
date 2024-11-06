using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public PhanQuyenDAL() { }
        public IEnumerable<PhanQuyen> getListPhanQuyen()
        {
            return _dataContext.PhanQuyens;
        }

        public IEnumerable<PhanQuyenDK> GetQuyenTruyCapTheoNhom(int maNhom)
        {
            var quyenTruyCaps = new List<PhanQuyenDK>();

            var result = _dataContext.sp_LayQuyenTruyCapTheoNhom(maNhom);

            foreach (var item in result)
            {
                if (item == null)
                {
                    continue;
                }

                var quyenTruyCap = new PhanQuyenDK
                {
                    MaManHinh = item.MaManHinh,
                    TenManHinh = item.TenManHinh,
                    CoQuyen = item.CoQuyen
                };

                quyenTruyCaps.Add(quyenTruyCap);
            }

            return quyenTruyCaps.OrderBy(p => p.MaManHinh);
        }

        public bool IsExists(int maNhom, int maManHinh)
        {
            return _dataContext.PhanQuyens.Where(p => p.MaManHinh.Equals(maManHinh) && p.MaNhomNguoiDung.Equals(maNhom)).Any();
        }

        public bool AddPhanQuyen(PhanQuyen phanQuyen)
        {
            try
            {
                _dataContext.PhanQuyens.InsertOnSubmit(phanQuyen);
                _dataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditPhanQuyen(PhanQuyen phanQuyen)
        {
            try
            {
                PhanQuyen phanQuyenUpdate = _dataContext.PhanQuyens.Where(p => p.MaManHinh.Equals(phanQuyen.MaManHinh) && p.MaNhomNguoiDung.Equals(phanQuyen.MaNhomNguoiDung)).FirstOrDefault();

                if (phanQuyenUpdate == null)
                {
                    return false;
                }

                phanQuyenUpdate.CoQuyen = phanQuyen.CoQuyen;
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
