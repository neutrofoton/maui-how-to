﻿using Maui06Carusel.Services;
using Maui06Carusel.ViewModels;

namespace Maui06Carusel;

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

		builder.Services.AddSingleton<MonkeyService>();
		builder.Services.AddTransient<MonkeysViewModel>();
		builder.Services.AddTransient<MainPage>();

		return builder.Build();
	}
}
