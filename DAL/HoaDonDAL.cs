using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public HoaDonDAL() { }
        public List<HoaDon> getListHoaDon()
        {
            return dataContext.HoaDons.ToList();
        }
    }
}
