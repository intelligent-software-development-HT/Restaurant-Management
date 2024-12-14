using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public NhanVienBLL() { }

        public NhanVien GetById(int maNhanVien)
        {
            return nhanVienDAL.GetById(maNhanVien);
        }

        public List<NhanVien> listNhanVien()
        {
            return nhanVienDAL.getListNhanVien();
        }

        public NhanVien GetByTenDangNhap(string tenDangNhap)
        {
            return nhanVienDAL.GetByTenDangNhap(tenDangNhap);
        }
    }
}
