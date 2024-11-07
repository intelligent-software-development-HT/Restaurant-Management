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
        public bool addMonAn(MonAn monAn)
        {
            return monAnDAL.addMonAn(monAn);
        }
        public bool deleteMonAn(int maMonAn)
        {
            return monAnDAL.deleteMonAn(maMonAn);
        }
        public bool editMonAn(int maMonAn, MonAn monAn)
        {
            return monAnDAL.editMonAn(maMonAn, monAn);
        }
        public MonAn getById(int maMonAn)
        {
            return monAnDAL.getById(maMonAn);
        }
    }
}
