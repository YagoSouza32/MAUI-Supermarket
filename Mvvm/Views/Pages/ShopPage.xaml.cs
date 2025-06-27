using MauiAppSupermarket.Mvvm.Models;
using MauiAppSupermarket.Mvvm.ViewModels;
using MauiAppSupermarket.Mvvm.Views.Pages;

namespace MauiAppSupermarket.Mvvm.Views;

public partial class ShopPage : ContentPage
{
    public ShopPage() : this(App.Services.GetRequiredService<ShopPageViewModel>())
    {
    }

    public ShopPage(ShopPageViewModel viewModel)
    {
        InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);

        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is ShopPageViewModel vm)
            await vm.LoadProductsAsync();
    }

    private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            if (e.CurrentSelection.FirstOrDefault() is Product selectedProduct)
            {
                ((CollectionView)sender).SelectedItem = null;

                await Navigation.PushAsync(new ProductDetailPage(selectedProduct));
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
