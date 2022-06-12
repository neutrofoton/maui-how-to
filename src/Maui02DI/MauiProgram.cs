using Maui02DI.Extensions;

namespace Maui02DI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterFonts()
            .RegisterHandlers()
            .RegisterViewModels()
            .RegisterPages()
            ;

        return builder.Build();
	}
}
