using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;

namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationImageController : Controller
    {
        private readonly LocationImageService _locationImageService = new LocationImageService();
        public ActionResult Index()
        {
            return View();
        }
    }
}