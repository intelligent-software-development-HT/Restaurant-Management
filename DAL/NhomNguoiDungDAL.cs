using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNguoiDungDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public NhomNguoiDungDAL() { }
        public List<NhomNguoiDung> getListNhomNguoiDung()
        {
            return dataContext.NhomNguoiDungs.ToList<NhomNguoiDung>();
        }
    }
}
