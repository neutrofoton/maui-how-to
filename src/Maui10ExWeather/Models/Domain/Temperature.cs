using System;
namespace Maui10ExWeather.Models.Domain
{
    public class Temperature
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public override string ToString() => $"{Value}˚{Unit}";
    }
}

