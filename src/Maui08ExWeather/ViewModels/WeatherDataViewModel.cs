using System;
using System.Linq;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui08ExWeather.Model;
using Maui08ExWeather.Services;
using Maui08ExWeather.Services.Impl;

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
        MainViewModel main;

        [ObservableProperty]
        CoordViewModel coord;

        [ObservableProperty]
        WindViewModel wind;

        [ObservableProperty]
        CloudsViewModel clouds;

        [ObservableProperty]
        SysViewModel sys;

        ObservableCollection<WeatherViewModel> Weather { get; } = new();

        [ObservableProperty]
        WeatherViewModel aWeather;

        //public static implicit operator WeatherDataViewModel(WeatherData value)
        //{
        //    if (value == null)
        //        return null;

        //    var vm = new WeatherDataViewModel()
        //    {
        //        Base=value.Base,
        //        Title=value.Title,
        //        Visibility=value.Visibility,
        //        Dt=value.Dt,
        //        Id=value.Id,
        //        Cod=value.Cod,

        //        Main=value.Main,
        //        Coord=value.Coord,
        //        Wind=value.Wind,
        //        Clouds=value.Clouds,
        //        Sys=value.Sys
        //    };

        //    if(value.Weather!=null && value.Weather.Length>0)
        //    {
        //        foreach(var val in value.Weather)
        //        {
        //           vm.Weather.Add(val);
        //        }
        //    }

        //    return vm;
        //}

        private void Apply(WeatherData value)
        {
            if (value == null)
                return;

            Base = value.Base;
            Title = value.Title;
            Visibility = value.Visibility;
            Id = value.Id;
            Cod = value.Cod;

            Main = value.Main;
            Coord = value.Coord;
            Wind = value.Wind;
            Clouds = value.Clouds;
            Sys = value.Sys;

            if (value.Weather != null && value.Weather.Length > 0)
            {
                foreach (var val in value.Weather)
                {
                    Weather.Add(val);
                }

                AWeather = Weather.FirstOrDefault();
            }
        }

        [ICommand]
        public async Task GetWeather()
        {
           
            IWeatherService weatherService = new WeatherService();
            WeatherData weatherData= await weatherService.GetWeatherDataAsync();

            Apply(weatherData);
        }
        
    }
}

