using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resultado : ContentPage
    {
        public resultado(int resultado, string operador)
        {
            InitializeComponent();
            laberesultado.Text = "El resultado de la " + operador + " es: " +resultado;
        }
    }
}