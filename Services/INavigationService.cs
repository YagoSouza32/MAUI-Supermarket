namespace MauiAppSupermarket.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route, IDictionary<string, object> parameters = null);
    Task NavigateBackAsync();
    T? GetPageViewModel<T>() where T : new();
}
