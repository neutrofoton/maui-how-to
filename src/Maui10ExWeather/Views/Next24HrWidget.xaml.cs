using Maui10ExWeather.ViewModels;

namespace Maui10ExWeather.Views;

public partial class Next24HrWidget
{
	public Next24HrWidget()
	{
		InitializeComponent();

        BindingContext = new HomeViewModel();
    }
}
