using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public PhanQuyenDAL() { }
        public List<PhanQuyen> getListPhanQuyen()
        {
            return dataContext.PhanQuyens.ToList<PhanQuyen>(); 
        }
    }
}
