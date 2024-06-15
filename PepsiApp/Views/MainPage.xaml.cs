using PepsiApp.Views;

namespace PepsiApp
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }
        
        public async void btnIniciarSesionn(object sender, EventArgs e)
        {
            string usuario = UsuarioEntry.Text;
            string contraseña = ContraseñaEntry.Text;

            if (usuario == "alumno" && contraseña == "1234")
            {
                await Navigation.PushAsync(new PaginaPrincipal() );
            }
        }


    }

}
