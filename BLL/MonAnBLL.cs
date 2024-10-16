using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class MonAnBLL
    {
        MonAnDAL monAnDAL = new MonAnDAL();
        public MonAnBLL() { }
        public List<MonAn> listMonAn()
        {
            return monAnDAL.getList();
        }
    }
}
