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
        var collectionView = sender as CollectionView;
        if (e.CurrentSelection.FirstOrDefault() is Games selectedGame)
        {
            await Navigation.PushAsync(new GameLibDetailsPage(selectedGame));

            collectionView.SelectedItem = null;
        }
    }


    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }

    async void OnSearchBarTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }



    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
    private async void OnBrowseCategoriesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GameLibCategoriesPage());
    }

}