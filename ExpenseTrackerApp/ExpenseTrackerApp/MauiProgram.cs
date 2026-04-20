using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Services;
using ExpenseTrackerApp.ViewModels;
using ExpenseTrackerApp.Views;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace ExpenseTrackerApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

#pragma warning disable CA1416 // Platform compatibility: extension APIs flagged for specific platforms
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#pragma warning restore CA1416

            builder.Services.AddSingleton<IExpenseService, ExpenseService>();
            builder.Services.AddSingleton<DatabaseService>();


            builder.Services.AddTransient<CategoriesViewModel>();
            builder.Services.AddTransient<CategoriesPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

namespace ExpenseTrackerApp.ViewModels
{
    public class CategoriesViewModel
    {
        // add properties/commands here
    }
}