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
        private readonly QLNHDataContext _dataContext = new QLNHDataContext();

        public ManHinhDAL()
        {

        }

        public IEnumerable<ManHinh> ReadManHinhs()
        {
            return _dataContext.ManHinhs.OrderBy(sc => sc.MaManHinh);
        }

        public bool Create(ManHinh manHinh)
        {
            try
            {
                _dataContext.ManHinhs.InsertOnSubmit(manHinh);
                _dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Update(ManHinh manHinh)
        {
            try
            {
                ManHinh manHinhUpdate = _dataContext.ManHinhs.Where(sc => sc.MaManHinh.Equals(manHinh.MaManHinh)).FirstOrDefault();

                if (manHinhUpdate == null)
                {
                    return false;
                }

                manHinhUpdate.TenManHinh = manHinh.TenManHinh;

                _dataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(int maManHinh)
        {
            try
            {
                ManHinh manHinhDelete = _dataContext.ManHinhs.Where(sc => sc.MaManHinh.Equals(maManHinh)).FirstOrDefault();

                if (manHinhDelete == null)
                {
                    return false;
                }

                _dataContext.ManHinhs.DeleteOnSubmit(manHinhDelete);
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
