using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        double temperature;

        [ObservableProperty]
        long pressure;

        [ObservableProperty]
        long humidity;

        [ObservableProperty]
        double tempMin;

        [ObservableProperty]
        double tempMax;

        public static implicit operator MainViewModel(Main value)
        {
            if (value == null)
                return null;

            return new MainViewModel()
            {
                Temperature=value.Temperature,
                Pressure=value.Pressure,
                Humidity=value.Humidity,
                TempMin=value.TempMin,
                TempMax=value.TempMax
            };
        }
    }
}

