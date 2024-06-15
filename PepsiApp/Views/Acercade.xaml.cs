namespace PepsiApp.Views;

public partial class Acercade : ContentPage
{
	public Acercade()
	{
		InitializeComponent();
	}

    private async void Button_ClickedVolver(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaPrincipal());
    }

    
}