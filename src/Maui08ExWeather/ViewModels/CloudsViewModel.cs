using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Maui08ExWeather.Model;

namespace Maui08ExWeather.ViewModels
{
    public partial class CloudsViewModel : ObservableObject
    {
        [ObservableProperty]
        private long all;

        public static implicit operator CloudsViewModel(Clouds value)
        {
            if (value == null)
                return null;

            return new CloudsViewModel()
            {
                All = value.All
            };
        }
    }
}

