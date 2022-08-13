using System;
namespace Maui10ExWeather.Models.Domain
{
    public class FullDayForecast
    {
        public DateTimeOffset DateTime { get; set; }
        public MinMaxTemperature Temperature { get; set; }

        public PhraseOnly Day { get; set; }
        public PhraseOnly Night { get; set; }

        public int ChanceOfPercipitation { get; } = new Random().Next(0, 100);

        public DateTimeOffset Date
        {
            set { DateTime = value; }
        }
    }
}

