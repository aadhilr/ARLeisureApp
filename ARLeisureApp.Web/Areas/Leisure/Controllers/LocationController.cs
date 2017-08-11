using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;
using ARLeisureApp.Domain.LocationModels;
using Newtonsoft.Json;

namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationController : Controller
    {
        private readonly LocationService _locationService = new LocationService();
        private readonly LocationCategoryService _locationCategoryService = new LocationCategoryService();
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
        public ActionResult Create(Location location, FormCollection form)
        {
            var entitySaved = _locationService.InsertLocation(location);
            ViewBag.LocationId = location.LocationId;
            return View();
        }

        [HttpGet]

        public JsonResult GetLocationCategoryListJsonResult()
        {
            var locationCategories = _locationCategoryService.GetLocationCategories("");
            return Json(JsonConvert.SerializeObject(locationCategories), JsonRequestBehavior.AllowGet); //converting c# object to json, mvc default deny get
        }
    }
}