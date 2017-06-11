using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLeisureApp.Domain.LocationModels
{
    public class LocationCategory
    {
        public int LocationCategoryId { get; set; }
        public string LocationCategoryName { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
