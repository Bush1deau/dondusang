namespace DonDuSang;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute("DetailsPage", typeof(DetailsPage));
	}
}
