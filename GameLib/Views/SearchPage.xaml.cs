using Models;
using Services;

namespace Views
{
    public partial class SearchPage : ContentPage
    {
        private List<Games> allGames;

        public SearchPage()
        {
            InitializeComponent();
            LoadGames();
        }

        private void LoadGames()
        {
            allGames = GameLibService.GetAllGames();
            GamesListView.ItemsSource = allGames;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var filtered = allGames
                .Where(g => g.Name.Contains(e.NewTextValue, StringComparison.OrdinalIgnoreCase))
                .ToList();

            GamesListView.ItemsSource = filtered;
        }

        private async void OnGameSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Games selectedGame)
            {
                await Navigation.PushAsync(new GameLibDetailsPage(selectedGame));

                ((CollectionView)sender).SelectedItem = null;
            }
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
}