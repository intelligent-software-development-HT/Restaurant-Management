using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungNhomNguoiDungDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public NguoiDungNhomNguoiDungDAL() { }
        public IEnumerable<NguoiDungNhomNguoiDung> ReadNguoiDungNhomNguoiDungs()
        {
            return dataContext.NguoiDungNhomNguoiDungs.OrderBy(ru => ru.MaNhomNguoiDung);
        }

        public bool AddNguoiDungVaoNhom(NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung)
        {
            try
            {
                dataContext.NguoiDungNhomNguoiDungs.InsertOnSubmit(nguoiDungNhomNguoiDung);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool RemoveNguoiDungKhoiNhom(NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung)
        {
            try
            {
                NguoiDungNhomNguoiDung nguoiDungNhomNguoiDungDelete = GetNguoiDungNhomNguoiDung(nguoiDungNhomNguoiDung.TenDangNhap, nguoiDungNhomNguoiDung.MaNhomNguoiDung);

                if (nguoiDungNhomNguoiDungDelete == null)
                {
                    return false;
                }

                dataContext.NguoiDungNhomNguoiDungs.DeleteOnSubmit(nguoiDungNhomNguoiDungDelete);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool IsExists(int maNhomNguoiDung, string tenDangNhap)
        {
            return dataContext.NguoiDungNhomNguoiDungs.Where(ru => ru.MaNhomNguoiDung.Equals(maNhomNguoiDung) && ru.TenDangNhap.Equals(tenDangNhap)).Any();
        }

        public NguoiDungNhomNguoiDung GetNguoiDungNhomNguoiDung(string tenDangNhap, int maNhom)
        {
            return dataContext.NguoiDungNhomNguoiDungs.Where(ru => ru.TenDangNhap.Equals(tenDangNhap) && ru.MaNhomNguoiDung.Equals(maNhom)).FirstOrDefault();
        }
    }
}
