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
        public List<Ban> getListBan()
        {
            return dataContext.Bans.ToList<Ban>();
        }
    }
}
