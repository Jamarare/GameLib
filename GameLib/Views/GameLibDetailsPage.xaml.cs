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
    private async void OnReviewsTapped(object sender, EventArgs e)
    {
        var game = (sender as Label)?.BindingContext as Games;
        if (game != null && !string.IsNullOrEmpty(game.ReviewsUrl))
        {
            await Launcher.OpenAsync(new Uri(game.ReviewsUrl));
        }
    }
}