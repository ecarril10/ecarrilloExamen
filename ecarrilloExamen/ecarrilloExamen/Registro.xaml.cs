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
    public partial class Registro : ContentPage
    {
        String usuario1;

        public Registro(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = "Usuario Conectado: " + usuario;
            usuario1 = usuario;
        }

        private void btPagoMensual_Clicked(object sender, EventArgs e)
        {
            double datoMontoInicial = Convert.ToDouble(txtMontoInicial.Text);

            double datoPagoMensual;

            double valorTotal = 1500;

            double calculo;

            calculo = (valorTotal - datoMontoInicial) / (4);

            datoPagoMensual = calculo * 1.04;

            txtMontoMensual.Text = datoPagoMensual.ToString();
        }

        private void btResumen_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string fecha = pkFecha.AutomationId;
            string pais = pkPais.Items[pkPais.SelectedIndex];
            string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
            string montoInicial = txtMontoInicial.Text;
            string montoMensual = txtMontoMensual.Text;


            Navigation.PushAsync(new Resumen(usuario1, nombre, apellido, edad, fecha, pais, ciudad, montoInicial, montoMensual));
        }
    }
}