using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace Models
{
    public class CategoriesViewModel
    {
        public ObservableCollection<Category> Category { get; set; }
        public ICommand CategorySelectedCommand { get; }

        public CategoriesViewModel()
        {
            Category = new ObservableCollection<Category>
            {
                new Category { Name = "FPS Games", Icon = "fps_games.png" },
                new Category { Name = "RPG Games", Icon = "fps_games.png"},
                new Category { Name = "MOBA Games", Icon = "fps_games.png"},
                new Category { Name = "Sports Games", Icon = "fps_games.png"},
                new Category { Name = "Action Games", Icon = "fps_games.png"},
                new Category { Name = "Free To Play Games", Icon = "fps_games.png"},
                new Category { Name = "Payed Games", Icon = "fps_games.png"},
                new Category { Name = "Horror Games", Icon = "fps_games.png"}
            };
            CategorySelectedCommand = new Command<Category>( async (selectedCategory) => await OnCategorySelected(selectedCategory)); 
        }
        private async Task OnCategorySelected(Category selectedCategory)
        {
            if (selectedCategory == null)
                return;

            Debug.WriteLine($"You Choosed Category: {selectedCategory.Name}");


            await Shell.Current.GoToAsync($"//MainPage?selectedCategory={Uri.EscapeDataString(selectedCategory.Name)}");



        }
    }
}
