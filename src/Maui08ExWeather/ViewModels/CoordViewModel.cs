using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui08ExWeather.ViewModels
{
    public partial class CoordViewModel : ObservableObject
    {
        [ObservableProperty]
        double lon;

        [ObservableProperty]
        double lat;
    }
}

