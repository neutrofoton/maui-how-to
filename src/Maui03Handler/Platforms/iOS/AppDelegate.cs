using Foundation;
using Maui03Handler.Controls;

namespace Maui03Handler;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    //protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    protected override MauiApp CreateMauiApp()
    {
        //method 3
        HandlerHelper.InitCustomControl();
        return MauiProgram.CreateMauiApp();
    }
}
