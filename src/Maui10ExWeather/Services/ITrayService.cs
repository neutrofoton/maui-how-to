using System;
namespace Maui10ExWeather.Services
{
    public interface ITrayService
    {
        void Initialize();

        Action ClickHandler { get; set; }
    }
}

