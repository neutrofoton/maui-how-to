using System;
using System.Text.Json.Serialization;

namespace Maui08ExWeather.Model
{
    public class Clouds
    {
        [JsonPropertyName("all")]
        public long All { get; set; }
    }
}

