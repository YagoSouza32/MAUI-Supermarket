namespace MauiAppSupermarket.Services;

class NavigationService : INavigationService
{
    public Task NavigateToAsync(string route, IDictionary<string, object> parameters)
    {
        if (parameters != null)
            return Shell.Current.GoToAsync(route, parameters);
        else
            return Shell.Current.GoToAsync(route);
    }

    public Task NavigateBackAsync() => Shell.Current.GoToAsync("..");
    public T? GetPageViewModel<T>() where T : new()
    {
        var page = Shell.Current.CurrentItem.CurrentItem.Stack.Where(f => f != null && f.BindingContext.GetType() == typeof(T)).FirstOrDefault();

        if (page != null)
            return (T)page.BindingContext;

        return default(T);
    }
}
