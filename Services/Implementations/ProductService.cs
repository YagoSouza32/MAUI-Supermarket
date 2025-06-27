using MauiAppSupermarket.Data.Repositories.Interfaces;
using MauiAppSupermarket.Mvvm.Models;
using MauiAppSupermarket.Services.Interfaces;

namespace MauiAppSupermarket.Services.Implementations;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Product>> GetAllAsync() => _repository.GetAllAsync();
}
