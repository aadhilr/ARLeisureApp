using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;
using ARLeisureApp.Domain.LocationModels;

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

        [HttpPost]
        public ActionResult Create(Location location)
        {
            var entitySaved = _locationService.InsertLocation(location);
            return View();
        }
    }
}