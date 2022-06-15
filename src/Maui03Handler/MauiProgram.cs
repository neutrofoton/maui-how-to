using Maui03Handler.Controls;

namespace Maui03Handler;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//Method 1:
		//HandlerHelper.InitCustomControl();

		//Method 4:
		CustomButtonHandler.DoHandle();

		return builder.Build();
	}
}
