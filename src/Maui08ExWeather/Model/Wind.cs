using System;
using System.Text.Json.Serialization;

namespace Maui08ExWeather.Model
{
    public class Wind
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public long Deg { get; set; }
    }
}

