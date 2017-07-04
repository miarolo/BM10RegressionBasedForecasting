using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bm10RBS.Models.DisplayModels
{
    public class ForecastModel
    {
        public string Date { get; set; }
        public string Day { get; set; }
        public string Temperature { get; set; }
        public int Rain { get; set; }
        public int Wind { get; set; }

        public ForecastModel(DateTime date, int temperature, int rain, int wind)
        {
            Date = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
            Day = date.DayOfWeek.ToString() + ", " +  date.Date.ToString("dd MMMM");
            Temperature = temperature.ToString() + "°C";
            Rain = rain;
            Wind = wind;
        }
    }
}