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
                lat = "46.5040851",
                lng = "-81.6279098",
                description = "This is marker #1"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "My title 2",
                lat = "41.85664",
                lng = "-87.734361",
                description = "This is marker #2"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "My title 3",
                lat = "37.85664",
                lng = "-84.734361",
                description = "This is marker #3"
            });

            return Json(new { markers = mapMarkers }, JsonRequestBehavior.AllowGet);
        }
    }
}