using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        private readonly PhanQuyenDAL _phanQuyenDAL = new PhanQuyenDAL();

        public IEnumerable<PhanQuyen> getListPhanQuyen()
        {
            return _phanQuyenDAL.getListPhanQuyen();
        }

        public IEnumerable<PhanQuyenDK> GetQuyenTruyCapTheoNhom(int maNhom)
        {
            return _phanQuyenDAL.GetQuyenTruyCapTheoNhom(maNhom);
        }

        public bool IsExists(int maNhom, int maManHinh)
        {
            return _phanQuyenDAL.IsExists(maNhom, maManHinh);
        }

        public bool AddPhanQuyen(PhanQuyen phanQuyen)
        {
            return phanQuyen != null ? _phanQuyenDAL.AddPhanQuyen(phanQuyen) : false;
        }

        public bool EditPhanQuyen(PhanQuyen phanQuyen)
        {
            return phanQuyen != null ? _phanQuyenDAL.EditPhanQuyen(phanQuyen) : false;
        }

        public bool PhanQuyenTruyCap(int maNhom, List<PhanQuyenDK> quyenTruyCaps)
        {
            try
            {
                foreach (PhanQuyenDK item in quyenTruyCaps)
                {
                    PhanQuyen phanQuyen = new PhanQuyen
                    {
                        MaNhomNguoiDung = maNhom,
                        MaManHinh = item.MaManHinh,
                        CoQuyen = item.CoQuyen
                    };

                    if (IsExists(maNhom, item.MaManHinh))
                    {
                        EditPhanQuyen(phanQuyen);
                    }
                    else
                    {
                        AddPhanQuyen(phanQuyen);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
