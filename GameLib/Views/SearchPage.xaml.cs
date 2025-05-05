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

        private void OnGameSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Games selectedGame)
            {
                GameName.Text = selectedGame.Name;
                GameCategory.Text = selectedGame.Category;
                GameDescription.Text = selectedGame.Description;

                if (!string.IsNullOrWhiteSpace(selectedGame.HeroImage))
                {
                    GameImage.Source = ImageSource.FromFile(selectedGame.HeroImage);
                }
                else
                {
                    GameImage.Source = null;
                }

                GameDetailsLayout.IsVisible = true;
            }
        }
    }
}