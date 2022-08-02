using Maui08ExWeather.ViewModels;

namespace Maui08ExWeather;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();

		WeatherDataViewModel vm = this.BindingContext as WeatherDataViewModel;
		if(vm!=null)
        {
			vm.Title = "New Title";
        }
	}

	
}

