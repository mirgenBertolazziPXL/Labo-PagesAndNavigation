namespace HelloPXL.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void GoToMenuPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MenuPage));
    }

    private async void GoToAboutPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }
}