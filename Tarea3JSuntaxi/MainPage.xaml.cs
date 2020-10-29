using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea3JSuntaxi
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string password)
        {
            InitializeComponent();

            lblUser.Text = "Usuario: " + usuario;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //asignacion de valores desde xaml
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);

                double dato3 = Convert.ToDouble(txtDato3.Text);
                double dato4 = Convert.ToDouble(txtDato4.Text);

                //accion sumar

                double suma = (dato1*0.3) + (dato2*0.2);
                txtResultado1.Text = suma.ToString();

                double suma2 = (dato3 * 0.3) + (dato4 * 0.2);
                txtResultado2.Text = suma2.ToString();

                double final = suma+suma2;
                txtResultadoFinal.Text = final.ToString();

                //Estado

                if (final>=7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }

            }

            catch (Exception ex)
            {

                DisplayAlert("Mensaje de error", "ERROR" + ex, "ok");
            }

        }
    }
}
