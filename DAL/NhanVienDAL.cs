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
        QLNHDataContext dataContext = new QLNHDataContext();
        public NhanVienDAL() { }
        public List<NhanVien> getListNhanVien()
        {
            return dataContext.NhanViens.ToList<NhanVien>();
        }
    }
}
