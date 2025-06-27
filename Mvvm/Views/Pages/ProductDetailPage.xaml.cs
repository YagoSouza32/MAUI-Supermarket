using MauiAppSupermarket.Mvvm.Models;

namespace MauiAppSupermarket.Mvvm.Views.Pages;

public partial class ProductDetailPage : ContentPage
{
    private readonly Product _product;

    public ProductDetailPage(Product product)
	{
		InitializeComponent();
        _product = product;
        BindingContext = _product;
    }

    private void QuantityStepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        QuantityLabel.Text = $"Quantidade: {(int)e.NewValue}";
    }
}