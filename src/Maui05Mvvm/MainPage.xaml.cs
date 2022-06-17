using Maui05Mvvm.ViewModels;

namespace Maui05Mvvm;

public partial class MainPage : ContentPage
{
	
	//public MainPage()
	//{
	//	InitializeComponent();
	//}

	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	
}

