using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MauiApp14.PersonelModule;
using MauiApp14.Utils;

namespace MauiApp14
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });




            builder.Services.GkAddTransientWithShellRoute<PersonelListView, PersonelListVM>("PersonelListPage");
            builder.Services.GkAddTransientWithShellRoute<PersonelEditView, PersonelEditVM>("PersonelEdit");



          //  builder.Services.GkAddSingletonWithShellRoute<PersonelListView, PersonelListVM>("PersonelListPage");


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
