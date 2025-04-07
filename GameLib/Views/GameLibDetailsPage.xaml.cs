using Models;

namespace Views;

public partial class GameLibDetailsPage : ContentPage
{
	public GameLibDetailsPage(Games game)
	{
		InitializeComponent();

		this.BindingContext = game;
	}

	async void BackButton_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
}