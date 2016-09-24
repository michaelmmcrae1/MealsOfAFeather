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
                title = "1",
                lat = "41.8540900",
                lng = "-87.6279000",
                description = "This is marker #1"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "2",
                lat = "41.856642",
                lng = "-87.734361",
                description = "This is marker #2"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "3",
                lat = "41.8566788",
                lng = "-87.739990",
                description = "This is marker #3"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "4",
                lat = "41.8960000",
                lng = "-87.749800",
                description = "This is marker #4"
            });
            mapMarkers.Add(new MapInstitutionMarkerModel
            {
                title = "5",
                lat = "41.9069000",
                lng = "-87.738000",
                description = "This is marker #5"
            });

            return Json(new { markers = mapMarkers }, JsonRequestBehavior.AllowGet);
        }
    }
}