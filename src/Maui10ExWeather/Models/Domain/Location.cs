using System;
namespace Maui10ExWeather.Models.Domain
{
    public class Location
    {
        public string Name { get; set; }
        public Coordinate Coordinate { get; set; }
        public string Icon { get; set; }
        public string WeatherStation { get; set; }
        public string Value { get; set; }
    }
}

