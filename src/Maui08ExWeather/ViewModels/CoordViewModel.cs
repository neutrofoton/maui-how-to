using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class CoordViewModel : ObservableObject
    {
        [ObservableProperty]
        double lon;

        [ObservableProperty]
        double lat;

        public static implicit operator CoordViewModel(Coord value)
        {
            if (value == null)
                return null;

            return new CoordViewModel()
            {
                Lat=value.Lat,
                Lon=value.Lon
            };
        }
    }
}

