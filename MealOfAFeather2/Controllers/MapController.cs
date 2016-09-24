using MealOfAFeather2.Controllers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MealOfAFeather2.Controllers
{
    public class MapController : Controller
    {
        private MapService _mapService;
        public MapController()
        {
            _mapService = new MapService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetMapJSON()
        {
            return Json(new { isSuccess = true });
        }
    }
}