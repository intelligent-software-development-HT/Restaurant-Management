using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();

        public IEnumerable<NguoiDung> ReadNguoiDungs()
        {
            return _dataContext.NguoiDungs.OrderBy(gr => gr.TenDangNhap);
        }

        public NguoiDung ReadNguoiDung(string tenDangNhap)
        {
            return _dataContext.NguoiDungs.Where(u => u.TenDangNhap.Equals(tenDangNhap)).FirstOrDefault();
        }

        public bool IsExists(string tenDangNhap)
        {
            return _dataContext.NguoiDungs.Any(gr => gr.TenDangNhap.Equals(tenDangNhap));
        }

        public bool Create(NguoiDung nguoiDung)
        {
            try
            {
                _dataContext.NguoiDungs.InsertOnSubmit(nguoiDung);
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        //Đổi mật khẩu hoặc đổi hoạt động
        public bool Update(NguoiDung nguoiDung)
        {
            try
            {
                NguoiDung nguoiDungUpdate = _dataContext.NguoiDungs.Where(gr => gr.TenDangNhap.Equals(nguoiDung.TenDangNhap)).FirstOrDefault();

                if (nguoiDungUpdate == null)
                {
                    return false;
                }

                nguoiDungUpdate.MatKhau = nguoiDung.MatKhau;
                nguoiDungUpdate.HoatDong = nguoiDung.HoatDong;

                _dataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(string tenDangNhap)
        {
            try
            {
                NguoiDung nguoiDungDelete = _dataContext.NguoiDungs.Where(gr => gr.TenDangNhap.Equals(tenDangNhap)).FirstOrDefault();

                if (nguoiDungDelete == null)
                {
                    return false;
                }

                _dataContext.NguoiDungs.DeleteOnSubmit(nguoiDungDelete);
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
