using System;
using System.Text.Json.Serialization;

namespace Maui10ExWeather.Models.AzureModel
{
    public class Forecast
    {
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonPropertyName("temperature")]
        public Temperature Temperature { get; set; }

        [JsonPropertyName("day")]
        public Day Day { get; set; }

        [JsonPropertyName("night")]
        public Night Night { get; set; }
    }
}

