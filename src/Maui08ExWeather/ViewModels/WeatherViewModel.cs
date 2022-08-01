using System;
using CommunityToolkit.Mvvm.ComponentModel;

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
    }
}

