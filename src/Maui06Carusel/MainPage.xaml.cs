using Maui06Carusel.ViewModels;

namespace Maui06Carusel;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

