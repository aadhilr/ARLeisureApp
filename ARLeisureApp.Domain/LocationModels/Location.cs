using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLeisureApp.Domain.LocationModels
{
   public class Location
    {
        public int LocationId { get; set; }
        public int LocationCategoryId { get; set; }
        [DisplayName("Location")]
        public string LocationName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LocationCategory LocationCategories { get; set; }
        public ICollection<LocationArticle> Locationarticles { get; set; }
        public ICollection<LocationImage> LocationImages { get; set; }
    }
}
