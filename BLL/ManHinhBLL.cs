using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManHinhBLL
    {
        private readonly ManHinhDAL _manHinhDAL = new ManHinhDAL();

        public ManHinhBLL() { }

        public IEnumerable<ManHinh> ReadNhomNguoiDungs()
        {
            return _manHinhDAL.ReadManHinhs();
        }

        public bool Create(ManHinh manHinh)
        {
            return manHinh != null ? _manHinhDAL.Create(manHinh) : false;
        }

        public bool Update(ManHinh manHinh)
        {
            return manHinh != null ? _manHinhDAL.Update(manHinh) : false;
        }

        public bool Delete(int maManHinh)
        {
            return _manHinhDAL.Delete(maManHinh);
        }
    }
}
