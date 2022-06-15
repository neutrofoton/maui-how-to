using System;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Maui03Handler.Controls
{
	public partial class CustomButtonHandler
	{
		static partial void ProcessCustomHandler()
        {
            Microsoft.Maui.Handlers.ButtonHandler.ElementMapper.AppendToMapping("MyCustomButton", (handler, view) =>
            {
                if(view is MyButton)
                {
                    (handler.PlatformView as UIKit.UIView).BackgroundColor = Colors.Red.ToPlatform();
                }
            });

            //EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) => {


            //    if (view is MyEntry)
            //    {


            //        handler.PlatformView.BackgroundColor = Colors.YellowGreen.ToPlatform();
            //        handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;


            //    }

            //});

        }
	}
}

