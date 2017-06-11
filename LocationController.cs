using System.Web.Mvc;
using ARLeisureApp.LeisureService;


namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationController : Controller
    {
        private readonly LocationService _locationService = new LocationService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Location location)
        //{
        //    return View();
        //}
    }
}