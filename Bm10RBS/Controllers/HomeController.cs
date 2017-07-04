using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bm10RBS.ViewModels.Main;

namespace Bm10RBS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ForecastToday()
        {
            
            using (BM10RBSContext context = new BM10RBSContext())
            {
                var date = DateTime.Now.Date;
                var forecast = context.BM10Voorspellingen.Where(p => p.Date.Value == date).FirstOrDefault();


                ForecastTodayModel model = new ForecastTodayModel(forecast.Date.Value, forecast.Temperatuur.Value, forecast.SomNeerslag.Value, forecast.Windsnelheid.Value);

                return View(model);
            }
            
        }
        public ActionResult ForecastTomorrow()
        {
            using (BM10RBSContext context = new BM10RBSContext())
            {
                var date = DateTime.Now.AddDays(1).Date;
                var forecast = context.BM10Voorspellingen.Where(p => p.Date.Value == date).FirstOrDefault();

                ForecastTomorrowModel model = new ForecastTomorrowModel(forecast.Date.Value, forecast.Temperatuur.Value, forecast.SomNeerslag.Value, forecast.Windsnelheid.Value);

                return View(model);

            }
        }


        public ActionResult ForecastWeek()
        {
            return View();
        }

        public ActionResult ForecastYear()
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
    }
}