using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class WeatherViewModel : ObservableObject
    {
        [ObservableProperty]
        long id;

        [ObservableProperty]
        string visibility;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        string icon;

        public static implicit operator WeatherViewModel(Weather value)
        {
            if (value == null)
                return null;

            return new WeatherViewModel()
            {
                Id=value.Id,
                Visibility = value.Visibility,
                Description = value.Description,
                Icon=value.Icon
            };
        }
    }
}

