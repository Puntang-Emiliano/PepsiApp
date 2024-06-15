namespace PepsiApp.Views;

public partial class PaginaPrincipal : ContentPage
{
	public PaginaPrincipal()
	{
		InitializeComponent();
	}

    public async void  Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Acercade());

    }

    private async void Button_Clicked_Salir(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }
}