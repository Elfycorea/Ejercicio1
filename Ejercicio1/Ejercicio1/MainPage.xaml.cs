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

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }

        private void Pickerope_SelectIndexChanged(object sender, EventArgs e)
        {

        }
        private  void btnsuma_Clicked(object sender, EventArgs e)
        {


            int n1 = Convert.ToInt32(txtnumero1.Text);
            int n2 = Convert.ToInt32(txtnumero2.Text);
            int suma = n1 + n2;
            DisplayAlert("Mensaje", suma.ToString(), "total");
            


        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnumero1.Text);
            int n2 = Convert.ToInt32(txtnumero2.Text);
            int resta = n1 - n2;
            DisplayAlert("Mensaje", resta.ToString(), "total");

        }

        private void btndivision_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnumero1.Text);
            int n2 = Convert.ToInt32(txtnumero2.Text);
            int division = n1 / n2;
            DisplayAlert("Mensaje", division.ToString(), "total");
        }

        private void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnumero1.Text);
            int n2 = Convert.ToInt32(txtnumero2.Text);
            int multiplicacion = n1 * n2;
            DisplayAlert("Mensaje", multiplicacion.ToString(), "total");

        }
    }

       
}
