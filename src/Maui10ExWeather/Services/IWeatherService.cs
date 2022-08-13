using System;
using Maui10ExWeather.Models.Domain;
using Location = Maui10ExWeather.Models.Domain.Location;

namespace Maui10ExWeather.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<Location>> GetLocations(string query);
        Task<WeatherResponse> GetWeather(Coordinate location);
    }
}

