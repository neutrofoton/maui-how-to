using System;
using System.Text.Json.Serialization;

namespace Maui10ExWeather.Models.AzureModel
{
    public class Minimum
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}

