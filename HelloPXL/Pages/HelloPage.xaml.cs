namespace HelloPXL.Pages;

public partial class HelloPage : ContentPage
{
	public HelloPage()
	{
		InitializeComponent();
	}
	private async void Img_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//HomePage");

    }
}