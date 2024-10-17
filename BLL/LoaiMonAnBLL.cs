using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiMonAnBLL
    {
        LoaiMonAnDAL loaiMonAnDAL = new LoaiMonAnDAL();
        public LoaiMonAnBLL() { }
        public List<LoaiMonAn> getListLoaiMonAn()
        {
            return loaiMonAnDAL.getListLoaiMonAn();
        }
    }
}
