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
    public partial class Resumen : TabbedPage
    {
        public Resumen(string usuario1, string nombre, string apellido, string  edad, string  fecha, string pais, string ciudad, string montoInicial, string montoMensual)
        {
            InitializeComponent();
        }
    }
}