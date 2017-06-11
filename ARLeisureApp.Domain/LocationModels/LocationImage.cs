using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLeisureApp.Domain.LocationModels
{
    public class LocationImage
    {
        public int LocationId { get; set; }
        public int LocationImageId { get; set; }
        public string ImageUrl { get; set; }
        public virtual Location Location { get; set; }
    }
}
