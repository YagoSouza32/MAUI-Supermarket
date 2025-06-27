using MauiAppSupermarket.Mvvm.Models;
using System.Net.Http.Json;

namespace MauiAppSupermarket.CloudServices;

public class ProductCloudService
{
    private readonly HttpClient _http;

    public ProductCloudService(HttpClient http)
    {
        _http = http;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _http.GetFromJsonAsync<IEnumerable<Product>>("http://192.168.254.211:3000/products");
    }
}
