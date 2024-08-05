using Microsoft.Extensions.Logging;
using PlatformImageView;
using CommunityToolkit.Maui;

namespace PlatformImageView
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder()
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()

#if WINDOWS || ANDROID

                .ConfigureMauiHandlers(handlers =>
                 {

                     handlers.AddHandler<CustomView, CustomViewHandler>();

                 })
#endif
            .ConfigureFonts(fonts =>
             {

                 fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                 fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
             });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
