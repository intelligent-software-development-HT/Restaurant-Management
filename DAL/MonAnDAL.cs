using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MonAnDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public MonAnDAL() { }
        public List<MonAn> getList()
        {
            return dataContext.MonAns.ToList();
        }
        public bool addMonAn(MonAn monAn)
        {
            try
            {
                dataContext.MonAns.InsertOnSubmit(monAn);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteMonAn(int maMonAn)
        {
            try
            {
                MonAn m = dataContext.MonAns.Where(p => p.MaMonAn == maMonAn).FirstOrDefault();
                dataContext.MonAns.DeleteOnSubmit(m);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool editMonAn(int maMonAn, MonAn mNew)
        {
            try
            {
                MonAn monAn = dataContext.MonAns.Where(p => p.MaMonAn == maMonAn).FirstOrDefault();
                monAn.TenMonAn = mNew.TenMonAn;
                monAn.DonGia = mNew.DonGia;

                if (monAn.MaLoaiMonAn != mNew.MaLoaiMonAn)
                {
                    var newLoaiMonAn = dataContext.LoaiMonAns.FirstOrDefault(l => l.MaLoaiMonAn == mNew.MaLoaiMonAn);
                    if (newLoaiMonAn != null)
                    {
                        monAn.LoaiMonAn = newLoaiMonAn; // Cập nhật đối tượng liên quan
                    }
                }

                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public MonAn getById(int maMonAn)
        {
            return dataContext.MonAns.Where(p => p.MaMonAn == maMonAn).FirstOrDefault();
        }

        public List<MonAn> GetMonAnsByLoaiMon(int maLoaiMonAn)
        {
            return dataContext.MonAns.Where(r => r.MaLoaiMonAn.Equals(maLoaiMonAn)).ToList();
        }
    }
}
