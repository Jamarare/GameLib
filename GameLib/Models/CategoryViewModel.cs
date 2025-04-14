using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.VisualBasic;

namespace Models
{
    class CategoryViewModel
    {
        ObservableCollection<Category> Categories { get; set; }

        public CategoryViewModel() 
        {
            Categories = new ObservableCollection<Category>
            {
                new Category { Name = "FPS Games", Icon = "fps_games.png" },
                new Category { Name = "RPG Games", Icon = "fps_games.png"},
                new Category { Name = "MOBA Games", Icon = "fps_games.png"},
                new Category { Name = "Sports Game", Icon = "fps_games.png"},
                new Category { Name = "Action Games ", Icon = "fps_games.png"},
                new Category { Name = "Free To Play Games", Icon = "fps_games.png"},
                new Category { Name = "Payed Games", Icon = "fps_games.png"}
                

            };
        }
    }
}
