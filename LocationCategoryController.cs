using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;

namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationCategoryController : Controller
    {
        private readonly LocationCategoryService _locationCategoryService = new LocationCategoryService();
        public ActionResult Index()
        {
            return View();
        }
    }
}