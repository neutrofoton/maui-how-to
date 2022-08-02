using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class SysViewModel : ObservableObject
    {
        [ObservableProperty]
        long type;

        [ObservableProperty]
        long id;

        [ObservableProperty]
        double message;

        [ObservableProperty]
        string country;

        [ObservableProperty]
        long sunrise;

        [ObservableProperty]
        long sunset;

        public static implicit operator SysViewModel(Sys value)
        {
            if (value == null)
                return null;

            return new SysViewModel()
            {
                Type = value.Type,
                Id = value.Id,
                Message = value.Message,
                Country = value.Country,
                Sunrise = value.Sunrise,
                Sunset = value.Sunset
            };
        }
    }
}

