using MauiAppSupermarket.Mvvm.Views;

namespace MauiAppSupermarket
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ShopPage), typeof(ShopPage));

        }
    }
}
