using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui08ExWeather.ViewModels
{
    public partial class CloudsViewModel : ObservableObject
    {
        [ObservableProperty]
        private long all;
    }
}

