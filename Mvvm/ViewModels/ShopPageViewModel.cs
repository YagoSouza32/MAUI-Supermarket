using MauiAppSupermarket.Mvvm.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiAppSupermarket.Services.Interfaces;

namespace MauiAppSupermarket.Mvvm.ViewModels;

public class ShopPageViewModel : ObservableObject
{
    private readonly IProductService _productService;

    public ObservableCollection<Product> Products { get; } = new();

    public ShopPageViewModel(IProductService productService)
    {
        _productService = productService;
    }

    public async Task LoadProductsAsync()
    {
        Products.Clear();

        var items = await _productService.GetAllAsync();

        foreach (var item in items)
            Products.Add(item);
    }
}