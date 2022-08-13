using System;
namespace Maui10ExWeather.Models.Domain
{
    public class WeatherSnapshot
    {
        public DateTimeOffset DateTime { get; set; }
        public string Phrase { get; set; }
        public Temperature Temperature { get; set; }
        public int ChanceOfPercipitation { get; } = new Random().Next(0, 100);

        public DateTimeOffset Date
        {
            set { DateTime = value; }
        }

        public string IconPhrase
        {
            set { Phrase = value; }
        }
    }
}

