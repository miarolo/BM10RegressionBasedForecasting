using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bm10RBS.Models.DisplayModels;

namespace Bm10RBS.ViewModels.Main
{
    public class ForecastYearModel
    {
        public List<ForecastmonthModel> ForecastList { get; set; }

        public ForecastYearModel()
        {

        }
        public ForecastYearModel(List<ForecastmonthModel> list)
        {
            ForecastList = list;
        }
    }
}