using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bm10RBS.Models.DisplayModels;

namespace Bm10RBS.ViewModels.Main
{
    public class ForecastWeekModel
    {
        public string Date { get; set; }
        public string Temperature { get; set; }
        public int Rain { get; set; }
        public string Wind { get; set; }
        public List<ForecastModel> ForecastList { get; set; }

        public ForecastWeekModel()
        {

        }
        public ForecastWeekModel(List<ForecastModel> list)
        {
            ForecastList = list;
        }
    }
}