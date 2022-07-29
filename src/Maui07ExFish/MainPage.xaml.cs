namespace Maui07ExFish;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        //MainViewModel mainVm = this.BindingContext as MainViewModel;
        //var locationViewModel = FishingLocationCarousel.CurrentItem as FishingLocationViewModel;
        //PanoramaViewModel panViewModel = new PanoramaViewModel(locationViewModel);
        //panViewModel.WeatherIcon = mainVm.WeatherIcon;

        //var locationPage = new FishingLocationPage(panViewModel);
        //this.Navigation.PushAsync(locationPage);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);
    }
}

