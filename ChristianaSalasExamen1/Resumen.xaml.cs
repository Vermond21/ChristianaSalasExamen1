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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string user, string fin)
        {
            InitializeComponent();
            lblusereg.Text = user;
            lbluser.Text = nombre;
            txtFinal.Text = fin;


        }

        private void btnCuota_Clicked(object sender, EventArgs e)
        {

        }
    }
}