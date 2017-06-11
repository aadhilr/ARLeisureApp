using ARLeisureApp.Domain.LocationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARLeisureApp.LeisureService;

namespace ARLeisureApp.Web.Areas.Leisure.Controllers
{
    public class LocationArticleController : Controller
    {
        private readonly LocationArticleService _locationArticleService = new LocationArticleService();
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
        public ActionResult Create(LocationArticle locationArticle)
        {
            var entitySaved = _locationArticleService.InsertLocationArticle(locationArticle);
            return View();


        }
    }
}