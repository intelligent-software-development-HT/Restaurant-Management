using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanBLL
    {
        BanDAL banDAL = new BanDAL();
        public BanBLL() { }
        public Ban GetById(int id)
        {
            return banDAL.GetById(id);
        }
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

        public bool CapNhatTrangThaiBan(int maBan, int trangThai)
        {
            return banDAL.CapNhatTrangThaiBan(maBan, trangThai);
        }
    }
}
