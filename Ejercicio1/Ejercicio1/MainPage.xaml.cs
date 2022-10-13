using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtnum1.Text);
            int b = Convert.ToInt32(txtnum2.Text);
            int resultado = a+b;
            string operador = "suma";
            await Navigation.PushAsync(new Views.resultado(resultado,operador));

                }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtnum1.Text);
            int b = Convert.ToInt32(txtnum2.Text);
            int resultado = a * b;
            string operador = "multiplicacion";
            await Navigation.PushAsync(new Views.resultado(resultado, operador));

        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtnum1.Text);
            int b = Convert.ToInt32(txtnum2.Text);
            int resultado = a - b;
            string operador = "resta";
            await Navigation.PushAsync(new Views.resultado(resultado, operador));

        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtnum1.Text);
            int b = Convert.ToInt32(txtnum2.Text);
            int resultado = a / b;
            string operador = "division";
            await Navigation.PushAsync(new Views.resultado(resultado, operador));

        }
    }
}
