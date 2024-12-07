using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public BanDAL() { }
        public Ban GetById(int id)
        {
            return dataContext.Bans.FirstOrDefault(r => r.MaBan.Equals(id));
        }
        public List<Ban> getListBan()
        {
            return dataContext.Bans.ToList<Ban>();
        }
        public bool addBan(Ban ban)
        {
            try
            {
                dataContext.Bans.InsertOnSubmit(ban);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteBan(int maBan)
        {
            try
            {
                Ban b = dataContext.Bans.Where(p => p.MaBan == maBan).FirstOrDefault();
                dataContext.Bans.DeleteOnSubmit(b);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool editBan(int maBan,Ban bNew)
        {
            try
            {
                Ban b = dataContext.Bans.Where(p => p.MaBan == maBan).FirstOrDefault();
                b.TenBan = bNew.TenBan;
                b.TrangThai = bNew.TrangThai;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
