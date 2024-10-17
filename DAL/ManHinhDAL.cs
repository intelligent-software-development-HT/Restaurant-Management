using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManHinhDAL
    {
        QLNHDataContext dataContext = new QLNHDataContext();
        public ManHinhDAL()
        {

        }
        public List<ManHinh> getListManHinh()
        {
            return dataContext.ManHinhs.ToList<ManHinh>();
        }
    }
}
