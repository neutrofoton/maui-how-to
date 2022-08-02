using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class WindViewModel : ObservableObject
    {
        [ObservableProperty]
        double speed;

        [ObservableProperty]
        long deg;

        public static implicit operator WindViewModel(Wind value)
        {
            if (value == null)
                return null;

            return new WindViewModel()
            {
                Deg = value.Deg,
                Speed = value.Speed
            };
        }
    }
}

