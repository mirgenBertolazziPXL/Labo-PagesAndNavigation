
namespace HelloPXL.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Menu_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MenuPage");

    }
    private async void About_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AboutPage"); 
    }
}