using Microsoft.Extensions.Logging;

namespace CabreraVelascoProyectoLayout
{
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
                    fonts.AddFont("Pacifico.ttf", "Pacifico");
                    fonts.AddFont("Amatic-Bold.ttf", "AmaticBold");
                    fonts.AddFont("AmaticSC-Regular.ttf", "Amatic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
