using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecarrilloExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";

            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync( new Registro(usuario));

            }
            else
            {
                DisplayAlert("ERROR", "Usuario7 contraseña incorrectos", "CERRAR");
            }
        }
    }
}