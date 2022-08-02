using System;
using System.Text.Json;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.Services.Impl
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherData> GetWeatherDataAsync()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("jakarta.json");
            using var reader = new StreamReader(stream);

            string json = reader.ReadToEnd();

            return JsonSerializer.Deserialize<WeatherData>(json);
        }
    }
}

