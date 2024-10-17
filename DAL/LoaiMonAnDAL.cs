using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiMonAnDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public LoaiMonAnDAL()
        {

        }
        public List<LoaiMonAn> getListLoaiMonAn()
        {
            return dataContext.LoaiMonAns.ToList<LoaiMonAn>();
        }
    }
}
