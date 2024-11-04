using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();
        public NguoiDungDAL() { }
        public List<NguoiDung> getListNguoiDung()
        {
            return _dataContext.NguoiDungs.ToList<NguoiDung>();  
        }

        public NguoiDung GetNguoiDungTheoTenDangNhap(string username)
        {
            return _dataContext.NguoiDungs.Where(nguoiDung => nguoiDung.TenDangNhap.Equals(username)).FirstOrDefault();
        }
    }
}
