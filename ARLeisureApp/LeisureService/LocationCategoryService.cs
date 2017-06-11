using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLeisureApp.DAL;
using ARLeisureApp.Domain.LocationModels;

namespace ARLeisureApp.LeisureService
{
    public class LocationCategoryService
    {
        private readonly UnitOfWork _contextUow = new UnitOfWork();

        public bool InsertLocationCategory(LocationCategory locationCategory)
        {
            try
            {
                _contextUow.LocationCategoryRepository.Insert(locationCategory);
                _contextUow.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
