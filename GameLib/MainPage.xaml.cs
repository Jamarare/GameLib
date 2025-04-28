using System.Collections.ObjectModel;
using System.Diagnostics;
using Models;
using Services;

namespace GameLib
{
    public partial class MainPage : ContentPage, IQueryAttributable
    {

        public ObservableCollection<Games> FilteredGames { get; set; } = new ObservableCollection<Games>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("selectedCategory"))
            {
                string selectedCategory = query["selectedCategory"]?.ToString();
                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    LoadGamesByCategory(selectedCategory);  
                }
                else
                {
                    Debug.WriteLine("Erorr: Choosed category is wrong.");
                }


            }
        }

        private void LoadGamesByCategory(string category)
        {
            var allGames = GameLibService.GetAllGames();
            var filtered = allGames.Where(g => g.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

            FilteredGames.Clear();
            foreach (var game in filtered)
            {
                FilteredGames.Add(game);
            }
        }



    }

}
