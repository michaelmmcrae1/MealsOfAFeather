using MealOfAFeather2.Controllers.Services;
using MealOfAFeather2.Models;
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

        public ActionResult GetMapMarkersJSON()
        {
            List<MapInstitutionMarkerModel> mapMarkers = new List<MapInstitutionMarkerModel>();

            // Prototype/mock data
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "My title 1",
                lat = "123.9429",
                lng = "180.9441",
                description = "This is marker #1"
            });

            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "My title 2",
                lat = "125.9429",
                lng = "183.9441",
                description = "This is marker #2"
            });

            return Json(new { markers = mapMarkers });
        }
    }
}