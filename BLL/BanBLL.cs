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
        public bool addBan(Ban ban)
        {
            return banDAL.addBan(ban);
        }
        public bool deleteBan(int maBan) 
        {
            return banDAL.deleteBan(maBan);
        }
        public bool editBan(int maBan, Ban bNew)
        {
            return banDAL.editBan(maBan, bNew);
        }
    }
}
