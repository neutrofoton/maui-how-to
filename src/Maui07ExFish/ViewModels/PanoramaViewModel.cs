using System;
using Maui07ExFish.Models;

namespace Maui07ExFish.ViewModels
{
    public class PanoramaViewModel : BaseViewModel
    {
        private FishingLocationModel location;
        private FishModel selectedFish;

        public string WeatherIcon { get; set; }

        public FishModel SelectedFish
        {
            get => selectedFish;
            set => SetProperty(ref selectedFish, value);
        }

        public string LocationName { get; set; }
        public string LatLong { get; set; }

        public PanoramaViewModel(FishingLocationViewModel locationViewModel)
        {
            this.location = locationViewModel.Location;
        }

        public FishingLocationModel Location
        {
            get => location;
            private set => location = value;
        }
    }
}

