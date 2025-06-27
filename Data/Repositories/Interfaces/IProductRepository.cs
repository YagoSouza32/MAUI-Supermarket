using MauiAppSupermarket.Mvvm.Models;

namespace MauiAppSupermarket.Data.Repositories.Interfaces;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
}
