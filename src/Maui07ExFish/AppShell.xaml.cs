namespace Maui07ExFish;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//register route
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
	}
}
