using System;
using System.Text.Json.Serialization;

namespace Maui10ExWeather.Models.AzureModel
{
    public class Day
    {
        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }
    }
}

