using System;
namespace Bm10RBS.ViewModels.Main
{
    public class ForecastTomorrowModel
    {
		public string Date { get; set; }
		public string Temperature { get; set; }
		public int Rain { get; set; }
		public string Wind { get; set; }

		public ForecastTomorrowModel()
		{

		}

		public ForecastTomorrowModel(DateTime date, int temperature, int rain, int wind)
		{
			Date = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
			Temperature = temperature.ToString();
			Rain = rain;
			Wind = wind.ToString();
		}

    }
}
