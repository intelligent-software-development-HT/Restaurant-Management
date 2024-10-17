using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanBLL
    {
        BanDAL banDAL = new BanDAL();
        public BanBLL() { }
        public List<Ban> getListBan()
        {
            return banDAL.getListBan();
        }
    }
}
