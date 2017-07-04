using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bm10RBS.Models.DisplayModels;
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
            using (BM10RBSContext context = new BM10RBSContext())
            {
                var startdate = DateTime.Now.Date;
                var enddate = DateTime.Now.AddDays(6).Date;

                List<ForecastModel> list = new List<ForecastModel>();


                var forecasts = context.BM10Voorspellingen.Where(p => p.Date >= startdate && p.Date <= enddate);

                foreach (var item in forecasts)
                {
                    list.Add(new ForecastModel(item.Date.Value, item.Temperatuur.Value, item.SomNeerslag.Value, item.Windsnelheid.Value));
                  
                }

                ForecastWeekModel model = new ForecastWeekModel(list);

                return View(model);
            }                
        }

        public ActionResult ForecastYear()
        {
            using (BM10RBSContext context = new BM10RBSContext())
            {
                var monthcount = 1;
                List<Models.DisplayModels.ForecastmonthModel> list = new List<Models.DisplayModels.ForecastmonthModel>();

                while (monthcount <= 12)
                {
                    var query = context.BM10Voorspellingen.Where(p => p.Date.Value.Month == monthcount && p.Date.Value.Year == 2017);

                    list.Add(new Models.DisplayModels.ForecastmonthModel(query));
                    monthcount = monthcount + 1;
                }

               ForecastYearModel model = new ForecastYearModel(list);

                return View(model);
            }
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