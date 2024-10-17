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
        QLNHDataContext dataContext = new QLNHDataContext();
        public NguoiDungDAL() { }
        public List<NguoiDung> getListNguoiDung()
        {
            return dataContext.NguoiDungs.ToList<NguoiDung>();  
        }
    }
}
