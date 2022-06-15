using Maui03Handler.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if __IOS__
using UIKit;
#endif

namespace Maui03Handler.Controls
{
	public static class HandlerHelper
	{
        public static void InitCustomControl()
        {
            EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) => {


                if (view is MyEntry)
                {

#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Colors.SteelBlue.ToPlatform());

#elif __MACCATALYST__
                handler.PlatformView.BackgroundColor = Colors.Violet.ToPlatform();
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.Line;


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
}

