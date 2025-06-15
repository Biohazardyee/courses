namespace MoonshotTestApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
	}

	private void RegisterRoutes()
	{
		// Register any additional routes here
		Routing.RegisterRoute(nameof(Pages.RegisterPage), typeof(Pages.RegisterPage));
		Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
		Routing.RegisterRoute(nameof(Pages.MenuPage), typeof(Pages.MenuPage));
    }
}
