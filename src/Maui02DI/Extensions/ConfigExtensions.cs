using System;
using Maui02DI.ViewModels;

namespace Maui02DI.Extensions
{
    public static class ConfigExtensions
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

            // Default method
            //builder.Services.Add();

            // Scoped objects are the same within a request, but different across different requests.
            //builder.Services.AddScoped();     

            // Singleton objects are created as a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.
            //builder.Services.AddSingleton();  

            // Transient objects lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
            //builder.Services.AddTransient();  


            return builder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            _ = builder.Services.AddSingleton<MainPageViewModel>();

            return builder;
        }

        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            _ = builder.Services.AddTransient<MainPage>();

            return builder;
        }
    }
}

