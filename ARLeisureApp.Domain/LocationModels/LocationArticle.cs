using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLeisureApp.Domain.LocationModels
{
    public class LocationArticle
    {
        public int LocationId { get; set; }
        public int LocationArticleId { get; set; }
        public string ArticleUrl { get; set; }
        public virtual Location Location { get; set; }
    }
}
