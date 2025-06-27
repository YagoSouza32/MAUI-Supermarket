using MauiAppSupermarket.CloudServices;
using MauiAppSupermarket.Data.Repositories.Implementations;
using MauiAppSupermarket.Data.Repositories.Interfaces;
using MauiAppSupermarket.Mvvm.ViewModels;
using MauiAppSupermarket.Mvvm.Views;
using Microsoft.Extensions.Http;
using MauiAppSupermarket.Services.Implementations;
using MauiAppSupermarket.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace MauiAppSupermarket
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // HttpClient para CloudServices
            builder.Services.AddHttpClient();

            // CloudService (um por controller)
            builder.Services.AddSingleton<ProductCloudService>();

            // Repositories e Services
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IProductService, ProductService>();

            // ViewModel + View
            builder.Services.AddTransient<ShopPageViewModel>();
            builder.Services.AddTransient<ShopPage>();

            return builder.Build();
        }
    }
}
