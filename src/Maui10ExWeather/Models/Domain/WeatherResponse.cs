using System;
namespace Maui10ExWeather.Models.Domain
{
    public class WeatherResponse
    {
        public WeatherSnapshot CurrentWeather { get; set; }
        public WeatherSnapshot[] HourlyForecasts { get; set; }
        public FullDayForecast[] DailyForecasts { get; set; }
    }
}

