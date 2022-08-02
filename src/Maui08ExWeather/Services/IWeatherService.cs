using System;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.Services
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherDataAsync();
    }
}

