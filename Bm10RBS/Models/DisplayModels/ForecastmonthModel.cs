using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bm10RBS.Models.DisplayModels
{
    public class ForecastmonthModel
    {
        public string Maand { get; set; }
        public string GemiddeldeTemperatuur { get; set; }
        public string LaagsteTemperatuur { get; set; }
        public string HoogsteTemperatuur { get; set; }

        public int GemiddeldeRegen { get; set; }
        public int TotaalRegen { get; set; }

        public int GemiddeldeWind { get; set; }
        
        public ForecastmonthModel() { }

        public ForecastmonthModel(IQueryable<BM10Voorspellingen> list)
        {
            Maand = list.OrderBy(p => p.Date).FirstOrDefault().Date.Value.ToString("MMMM");
            var gemiddeldetemperatuur = Math.Round(list.Average(p => p.Temperatuur).Value, 0).ToString();
            GemiddeldeTemperatuur = gemiddeldetemperatuur + "°C";

            LaagsteTemperatuur = list.OrderBy(p => p.Temperatuur).FirstOrDefault().Temperatuur.ToString() + "°C";
            HoogsteTemperatuur = list.OrderByDescending(p => p.Temperatuur).First().Temperatuur.ToString() + "°C";

            GemiddeldeRegen = Convert.ToInt32(list.Average(p => p.SomNeerslag).Value);
            TotaalRegen = list.Sum(p => p.SomNeerslag).Value;

            GemiddeldeWind = Convert.ToInt32(list.Average(p => p.Windsnelheid).Value);
         }
    }
}