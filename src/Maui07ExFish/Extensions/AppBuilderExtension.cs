using System;
using Maui07ExFish.Services;
using Maui07ExFish.Services.Impl;
using Maui07ExFish.ViewModels;

namespace Maui07ExFish.Extensions
{
    public static class AppBuilderExtension
    {
        public static MauiAppBuilder RegisterFonts(this MauiAppBuilder builder)
        {
            return builder.ConfigureFonts(fonts =>
            {
                // Your fonts here...
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        }

        public static MauiAppBuilder RegisterHandlers(this MauiAppBuilder builder)
        {
            //RegisterMappers();

            return builder.ConfigureMauiHandlers(handlers =>
            {
                // Your handlers here...
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
            });
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            // Add your services here...

            builder.Services.AddScoped(typeof(IAlertService), typeof(AlertService));
            return builder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            _ = builder.Services.AddSingleton<MainViewModel>();
            _ = builder.Services.AddSingleton<OnboardingViewModel>();

            return builder;
        }

        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            //_ = builder.Services.AddTransient<MainPage>();

            return builder;
        }
    }
}

