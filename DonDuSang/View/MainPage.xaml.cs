using DonDuSang.ViewModel;

namespace DonDuSang.View;

public partial class MainPage : ContentPage
{
	public MainPage(CentresDeDonViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}

