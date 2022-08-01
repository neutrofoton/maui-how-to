using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui08ExWeather.ViewModels
{
    public partial class WeatherDataViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        string _base;

        [ObservableProperty]
        long visibility;

        [ObservableProperty]
        long dt;

        [ObservableProperty]
        long id;

        [ObservableProperty]
        long cod;

        [ObservableProperty]
        MainViewModel min;

        [ObservableProperty]
        CoordViewModel coord;

        [ObservableProperty]
        WindViewModel wind;

        [ObservableProperty]
        CloudsViewModel clouds;

        [ObservableProperty]
        SysViewModel sys;

        ObservableCollection<WeatherViewModel> Weather { get; } = new();
        
    }
}

