using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungNhomNguoiDungDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public NguoiDungNhomNguoiDungDAL() { }
        public List<NguoiDungNhomNguoiDung> getListNguoiDungNhomNguoiDung()
        {
            return dataContext.NguoiDungNhomNguoiDungs.ToList<NguoiDungNhomNguoiDung>();
        }
    }
}
