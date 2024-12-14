using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public NhanVienDAL() { }

        public List<NhanVien> getListNhanVien()
        {
            return _dataContext.NhanViens.ToList<NhanVien>();
        }

        public NhanVien GetById(int id)
        {
            return _dataContext.NhanViens.FirstOrDefault(r => r.MaNV.Equals(id));
        }

        public NhanVien GetByTenDangNhap(string tenDangNhap)
        {
            return _dataContext.NhanViens.FirstOrDefault(r => r.TenDangNhap.Equals(tenDangNhap));
        }
    }
}
