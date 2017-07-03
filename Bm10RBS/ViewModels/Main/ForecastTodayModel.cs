using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bm10RBS.ViewModels.Main
{
    public class ForecastTodayModel
    {
        public string Date { get; set; }
        public string Temperature { get; set; }
        public int Rain { get; set; }
        public string Wind { get; set; }

        public ForecastTodayModel()
        {

        }

        public ForecastTodayModel(DateTime date, int temperature, int rain, int wind)
        {
            Date = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
            Temperature = temperature.ToString();
            Rain = rain;
            Wind = wind.ToString();
        }
    }
}