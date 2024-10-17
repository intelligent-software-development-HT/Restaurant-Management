using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public ChiTietHoaDonDAL() { }
        public List<ChiTietHoaDon> getListChiTietHoaDon()
        {
            return dataContext.ChiTietHoaDons.ToList<ChiTietHoaDon>();
        }
    }

}
