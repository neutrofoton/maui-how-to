using Maui10ExWeather.Pages;

namespace Maui10ExWeather;

public partial class App : Application
{
    //public App()
    //{
    //	InitializeComponent();

    //	MainPage = new AppShell();
    //}

    public App()
    {
        InitializeComponent();

        //App.Current.UserAppTheme = OSAppTheme.Light;

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            Shell.Current.CurrentItem = PhoneTabs;

        //Routing.RegisterRoute("settings", typeof(SettingsPage));
        Routing.RegisterRoute("settings", typeof(EmptyPage));
    }

    void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("///settings");

    }
}
