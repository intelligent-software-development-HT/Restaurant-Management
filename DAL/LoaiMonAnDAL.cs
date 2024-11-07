using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiMonAnDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public LoaiMonAnDAL()
        {

        }
        public List<LoaiMonAn> getListLoaiMonAn()
        {
            return dataContext.LoaiMonAns.ToList<LoaiMonAn>();
        }
        public bool addLoaiMonAn(LoaiMonAn loaiMonAn)
        {
            try
            {
                dataContext.LoaiMonAns.InsertOnSubmit(loaiMonAn);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteLoaiMonAn(int maLoaiMonAn)
        {
            try
            {
                LoaiMonAn l = dataContext.LoaiMonAns.Where(p=>p.MaLoaiMonAn == maLoaiMonAn).FirstOrDefault();
                dataContext.LoaiMonAns.DeleteOnSubmit(l);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editLoaiMonAn(int maLoaiMonAn, LoaiMonAn lNew)
        {
            try
            {
                LoaiMonAn l = dataContext.LoaiMonAns.Where(p => p.MaLoaiMonAn == maLoaiMonAn).FirstOrDefault();
                l.TenLoaiMonAn = lNew.TenLoaiMonAn;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public LoaiMonAn getById(int MaLoaiMonAn)
        {
            return dataContext.LoaiMonAns.Where(p => p.MaLoaiMonAn == MaLoaiMonAn).FirstOrDefault();
        }
    }
}
