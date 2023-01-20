using DonDuSang.Services;

namespace DonDuSang.ViewModel;

public partial class CentresDeDonViewModel : BaseViewModel
{
	CentreDeDonService service;
	public ObservableCollection<CentreDeDon> Centres { get; } = new();

	public CentresDeDonViewModel(CentreDeDonService service)
	{
		Titre = "Don du sang";
		this.service = service;
	}

	[RelayCommand]
	async Task GetCentresDeDon()
	{
		if (EstOccupé)
			return;

		EstOccupé= true;
		var centres = await this.service.GetCentreDeDons();
		if (Centres.Count != 0)
			Centres.Clear();
		foreach (var centre in centres)
		{
			Centres.Add(centre);
		}
		EstOccupé= false;
	}
}
