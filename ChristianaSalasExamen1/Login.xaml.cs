using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChristianaSalasExamen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if ((user == "Christian") && (pass == "Exa12345"))
            {
                await Navigation.PushAsync(new Registro(user, pass));

            }
            else
            {
                await DisplayAlert("Alerta", "Credenciales Incorectas", "cerrar");
            }

        }
    }
}