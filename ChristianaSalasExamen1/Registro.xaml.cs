using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristianaSalasExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();

            lbluser.Text = "Usuario Conectado: " + user;



        }

        private void btnCuota_Clicked(object sender, EventArgs e)
        {
            float montoInicial = 1800;
            float interes;
            float restante;


            try
            {
                string nombre = Convert.ToString(txtNombre.Text);
                double monto = Convert.ToDouble(txtMontoIni.Text);
                double cuota = Convert.ToDouble(txtCuotaPar.Text);
                double fin = Convert.ToDouble(txtFinalF.Text);

                if (monto < montoInicial)
                {
                    restante = (float)(montoInicial - monto);

                    interes = (float)(montoInicial * 0.05);

                    cuota = (restante / 3) + interes;
                    fin = (float)((monto) + (cuota * 3));
                    txtCuotaPar.Text = cuota.ToString();
                    txtFinalF.Text = fin.ToString();

                }
                else
                {
                    monto = 0;
                    txtCuotaPar.Text = monto.ToString();
                }

            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.Message, "Cerrar");
            }

        }

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Informacion almacenada con exito ", "cerrar");
            string nombre = txtNombre.Text;
            string user = lbluser.Text;
            string fina = txtFinalF.Text;
            await Navigation.PushAsync(new Resumen(nombre, user, fina));
        }
    }
}