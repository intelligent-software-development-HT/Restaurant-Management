using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNguoiDungDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();

        public IEnumerable<NhomNguoiDung> ReadNhomNguoiDungs()
        {
            return _dataContext.NhomNguoiDungs.OrderBy(gr => gr.MaNhom);
        }

        public bool IsExists(int maNhomNguoiDung)
        {
            return _dataContext.NhomNguoiDungs.Any(gr => gr.MaNhom.Equals(maNhomNguoiDung));
        }

        public bool Create(NhomNguoiDung nhomNguoiDung)
        {
            try
            {
                _dataContext.NhomNguoiDungs.InsertOnSubmit(nhomNguoiDung);
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Update(NhomNguoiDung nhomNguoiDung)
        {
            try
            {
                NhomNguoiDung nhomNguoiDungUpdate = _dataContext.NhomNguoiDungs.Where(gr => gr.MaNhom.Equals(nhomNguoiDung.MaNhom)).FirstOrDefault();

                if (nhomNguoiDungUpdate == null)
                {
                    return false;
                }

                nhomNguoiDungUpdate.TenNhom = nhomNguoiDung.TenNhom;
                nhomNguoiDungUpdate.GhiChu = nhomNguoiDung.GhiChu;

                _dataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(int maNhomNguoiDung)
        {
            try
            {
                NhomNguoiDung nhomNguoiDungDelete = _dataContext.NhomNguoiDungs.Where(gr => gr.MaNhom.Equals(maNhomNguoiDung)).FirstOrDefault();

                if (nhomNguoiDungDelete == null)
                {
                    return false;
                }

                _dataContext.NhomNguoiDungs.DeleteOnSubmit(nhomNguoiDungDelete);
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
