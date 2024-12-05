using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDatBanBLL
    {
        private readonly PhieuDatBanDAL _phieuDatBanDAL = new PhieuDatBanDAL();
        public PhieuDatBanBLL()
        {
            
        }

        public List<DatBan> GetDanhSachDatBan()
        {
            return _phieuDatBanDAL.GetDanhSachDatBan();
        }
    }
}
