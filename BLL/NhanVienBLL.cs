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
        public List<NhanVien> listNhanVien()
        {
            return nhanVienDAL.getListNhanVien();
        }
    }
}
