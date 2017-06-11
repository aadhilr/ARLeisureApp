using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;
using ARLeisureApp.Domain.LocationModels;

namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationCategoryController : Controller
    {
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
        public ActionResult Create(LocationCategory locationCategory)
        {
            var entitySaved = _locationCategoryService.InsertLocationCategory(locationCategory);
            return View();
        }
    }
}