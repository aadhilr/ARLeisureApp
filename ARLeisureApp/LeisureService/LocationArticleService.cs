using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLeisureApp.DAL;
using ARLeisureApp.Domain.LocationModels;

namespace ARLeisureApp.LeisureService
{
    public class LocationArticleService
    {
        private readonly UnitOfWork _contextUow = new UnitOfWork();

        public bool InsertLocationArticle(LocationArticle locationArticle)
        {
            try
            {
                _contextUow.LocationArticleRepository.Insert(locationArticle);
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
