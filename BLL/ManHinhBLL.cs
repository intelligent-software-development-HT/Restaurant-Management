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
        ManHinhDAL manHinhDAL = new ManHinhDAL();
        public ManHinhBLL() { }
        public List<ManHinh> getListManHinh()
        {
            return manHinhDAL.getListManHinh();
        }
    }
}
