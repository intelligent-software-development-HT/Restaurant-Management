using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MonAnDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public MonAnDAL() { }
        public List<MonAn> getList()
        {
            return dataContext.MonAns.ToList<MonAn>();
        }
    }
}
