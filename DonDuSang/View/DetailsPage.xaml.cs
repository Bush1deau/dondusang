namespace DonDuSang;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(CentreDeDonDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}