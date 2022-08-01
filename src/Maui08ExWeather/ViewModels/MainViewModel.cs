using System;
using CommunityToolkit.Mvvm.ComponentModel;

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
    }
}

