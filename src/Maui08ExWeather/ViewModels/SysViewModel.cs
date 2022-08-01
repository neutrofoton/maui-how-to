using System;
using CommunityToolkit.Mvvm.ComponentModel;

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
    }
}

