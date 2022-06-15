using Maui03Handler.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if __IOS__
using UIKit;
#endif

namespace Maui03Handler;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//Method 2
		//HandlerHelper.InitCustomControl();

		MainPage = new AppShell();
	}

	
}
