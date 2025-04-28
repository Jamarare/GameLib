using Views;

namespace MauiPlanets.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        var parentAnimation = new Animation();

        //PlanetsAnimation
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgLogo.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.3, 0.5, new Animation(v => imgSteam.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.4, 0.6, new Animation(v => imgUbisoft.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgEpic.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.6, 0.8, new Animation(v => imgRockstar.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.7, 0.9, new Animation(v => imgXbox.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.7, 0.9, new Animation(v => imgGog.Opacity = v, 0, 1, Easing.CubicIn));

        //intro box
        parentAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new GameLibPage());
}