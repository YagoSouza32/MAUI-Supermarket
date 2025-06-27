using MauiAppSupermarket.Mvvm.Models;

namespace MauiAppSupermarket.Services.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
}
