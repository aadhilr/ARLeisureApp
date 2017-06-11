using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLeisureApp.DAL;
using ARLeisureApp.Domain.LocationModels;

namespace ARLeisureApp.LeisureService
{
    public class LocationService
    {
        private readonly UnitOfWork _contextUow = new UnitOfWork();

        public bool InsertLocation(Location location)
        {
            try
            {
                _contextUow.LocationRepository.Insert(location);
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
