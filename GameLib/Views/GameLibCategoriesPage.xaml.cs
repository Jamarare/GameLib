using Models;

namespace Views;

public partial class GameLibCategoriesPage : ContentPage
{
	public GameLibCategoriesPage()
	{
		InitializeComponent();
        BindingContext = new CategoriesViewModel();
    }
}