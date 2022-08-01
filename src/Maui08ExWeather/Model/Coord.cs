using System;
using System.Text.Json.Serialization;

namespace Maui08ExWeather.Model
{
    public class Coord
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}

