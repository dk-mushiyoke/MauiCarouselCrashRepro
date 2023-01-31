namespace MauiApp3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
        Container.IsVisible = !Container.IsVisible;
    }
}

