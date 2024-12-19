using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();

        public BanDAL() { }

        public Ban GetById(int id)
        {
            return _dataContext.Bans.FirstOrDefault(r => r.MaBan.Equals(id));
        }

        public List<Ban> getListBan()
        {
            _dataContext.Refresh(RefreshMode.OverwriteCurrentValues, _dataContext.Bans);
            return _dataContext.Bans.ToList<Ban>();
        }

        public bool addBan(Ban ban)
        {
            try
            {
                _dataContext.Bans.InsertOnSubmit(ban);
                _dataContext.SubmitChanges();
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
                Ban b = _dataContext.Bans.Where(p => p.MaBan == maBan).FirstOrDefault();
                _dataContext.Bans.DeleteOnSubmit(b);
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editBan(int maBan, Ban bNew)
        {
            try
            {
                Ban b = _dataContext.Bans.Where(p => p.MaBan == maBan).FirstOrDefault();
                b.TenBan = bNew.TenBan;
                b.TrangThai = bNew.TrangThai;
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatTrangThaiBan(int maBan, int trangThai)
        {
            try
            {
                Ban ban = _dataContext.Bans.FirstOrDefault(r => r.MaBan.Equals(maBan));

                ban.TrangThai = trangThai;
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
