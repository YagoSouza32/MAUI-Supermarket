namespace MauiAppSupermarket.Mvvm.Views;

public partial class TabbedPageMenu : TabbedPage
{
	public TabbedPageMenu()
	{
		InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);
    }
}