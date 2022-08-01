using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui08ExWeather.ViewModels
{
    public partial class WindViewModel : ObservableObject
    {
        [ObservableProperty]
        double speed;

        [ObservableProperty]
        long deg;
    }
}

