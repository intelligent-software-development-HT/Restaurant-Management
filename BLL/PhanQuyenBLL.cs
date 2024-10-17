using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();
        public PhanQuyenBLL() { }
        public List<PhanQuyen> getListPhanQuyen()
        {
            return phanQuyenDAL.getListPhanQuyen();
        }
    }
}
