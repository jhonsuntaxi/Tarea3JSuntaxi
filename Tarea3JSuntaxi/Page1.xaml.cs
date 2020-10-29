using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea3JSuntaxi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string password = txtPasswd.Text;
            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";


            try
            {
                if (user_val == usuario && pass_val == password)
                {
                    await Navigation.PushAsync(new MainPage(usuario,password));
                }
                else
                {
                    string mensaje = "Usuario o Contraseña incorrectos";
                    DisplayAlert("Mensaje de Alerta", mensaje, "Aceptar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }

        }
    }
}