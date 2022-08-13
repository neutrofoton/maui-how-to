using System;
using System.Text.Json.Serialization;

namespace Maui10ExWeather.Models.AzureModel
{
    public class Temperature
    {
        [JsonPropertyName("minimum")]
        public Minimum Minimum { get; set; }

        [JsonPropertyName("maximum")]
        public Maximum Maximum { get; set; }
    }
}

