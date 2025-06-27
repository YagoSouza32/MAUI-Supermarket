using MauiAppSupermarket.CloudServices;
using MauiAppSupermarket.Data.Repositories.Interfaces;
using MauiAppSupermarket.Mvvm.Models;

namespace MauiAppSupermarket.Data.Repositories.Implementations;

public class ProductRepository : IProductRepository
{
    private readonly ProductCloudService _cloudService;

    public ProductRepository(ProductCloudService cloudService)
    {
        _cloudService = cloudService;
    }

    public Task<IEnumerable<Product>> GetAllAsync() => _cloudService.GetAllProductsAsync();

}
