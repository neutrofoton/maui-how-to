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

		InitCustomControl();
		MainPage = new AppShell();
	}

	private void InitCustomControl()
    {
		EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) => {


            //#if __ANDROID__
            //			handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());

            //#elif __IOS__
            //            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
            //			//handler.PlatformView.SetBackgroundColor(Colors.SpringGreen.ToPlatform());

            //#elif __WINDOWS__
            //            handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;

            //#endif


            if (view is MyEntry)
            {

#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Colors.SteelBlue.ToPlatform());

#elif __MACCATALYST__
                handler.PlatformView.BackgroundColor = Colors.Violet.ToPlatform();
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;


#elif __IOS__
                handler.PlatformView.BackgroundColor = Colors.YellowGreen.ToPlatform();
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
#elif __WINDOWS__
                handler.PlatformView.Background = Colors.LightGray.ToPlatform();


#endif

            }

        });

    }
}
