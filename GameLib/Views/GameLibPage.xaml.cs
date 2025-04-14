using Models;
using Services;

namespace Views;

public partial class GameLibPage : ContentPage
{
    private const uint AnimationDuration = 800u;

    public GameLibPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularGames.ItemsSource = GameLibService.GetFeaturedGames();
        lstAllGames.ItemsSource = GameLibService.GetAllGames();
    }

    async void Games_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new GameLibDetailsPage(e.CurrentSelection.First() as Games));
    }

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.ScaleTo(0.8, AnimationDuration);
    }
    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}