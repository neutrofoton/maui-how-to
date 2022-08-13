using System;
using System.Text.Json.Serialization;

namespace Maui10ExWeather.Models.AzureModel
{
    public class ForecastsPayload
    {
        [JsonPropertyName("forecasts")]
        public List<Forecast> Forecasts { get; set; }
    }
}

