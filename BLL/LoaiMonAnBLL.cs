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
        public bool addLoaiMonAn(LoaiMonAn loaiMonAn)
        {
            return loaiMonAnDAL.addLoaiMonAn(loaiMonAn);
        }
        public bool deleteLoaiMonAn(int maLoaiMonAn)
        {
            return loaiMonAnDAL.deleteLoaiMonAn(maLoaiMonAn);
        }
        public bool editLoaiMonAn(int maLoaiMonAn, LoaiMonAn lNew)
        {
            return loaiMonAnDAL.editLoaiMonAn(maLoaiMonAn , lNew);
        }
    }
}
