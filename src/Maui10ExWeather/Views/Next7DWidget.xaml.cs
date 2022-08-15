using Maui10ExWeather.ViewModels;

namespace Maui10ExWeather.Views;

public partial class Next7DWidget
{
	public Next7DWidget()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }

    
}
